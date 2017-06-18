using NBitcoin;
using NBitcoin.BouncyCastle.Math;
using OffchainHelper.Entities;
using OffchainHelper.Helper;
using OffchainHelper.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OffchainHelper.Helper.Helper;

namespace OffchainHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            toolTipCommitment.SetToolTip(textBoxFeeTransactionId, "Transaction id for the coin used for fee payment");
            toolTipCommitment.SetToolTip(textBoxFeeOutputNumber, "Transaction output number for the coin used for fee payment.");
            toolTipCommitment.SetToolTip(textFeePrivateKey, "The private key for the address holding the fee.");
        }

        private async void bGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                var dictionary = await ReadWordList();
                var settings = Settings.ReadAppSettings();

                var wordList = textWordList.Text;
                var splittedWordList = wordList.Split(new char[] { ' ' });
                splittedWordList = splittedWordList.Where(c => !string.IsNullOrEmpty(c)).ToArray();
                if (splittedWordList.Count() != 12)
                {
                    Alert("The count of words should be exactly 12");
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (!dictionary.ContainsKey(splittedWordList[i]))
                        {
                            Alert(string.Format("{0} is not present in the dictionary", splittedWordList[i]));
                            return;
                        }
                    }

                    var key = GenerateKeyFrom12Words(splittedWordList, dictionary);
                    BitcoinSecret secret = new BitcoinSecret(key, settings.Network);
                    textGeneratedPrivateKey.Text = secret.ToWif();

                    var addr = secret.GetAddress();
                    textPrivateAddr.Text = addr.ToString();
                }
            }
            catch (Exception exp)
            {
                Alert(exp.ToString());
            }
        }

        private async void buttonSign_Click(object sender, EventArgs e)
        {
            var privKey = textPrivateKey.Text;
            var unsignedText = textCommitmentToSign.Text;
            var feeTxId = textBoxFeeTransactionId.Text;
            var feeTxOutputNumber = textBoxFeeOutputNumber.Text;
            var feePrivateKey = textFeePrivateKey.Text;
            var sigHashType = SigHash.All | SigHash.AnyoneCanPay;

            var settings = Settings.ReadAppSettings();

            textSignedTransaction.Text = string.Empty;

            if (string.IsNullOrEmpty(privKey))
            {
                Alert("Private key should have a value.");
                return;
            }
            BitcoinSecret secret = null;
            try
            {
                secret = Base58Data.GetFromBase58Data(privKey, settings.Network) as BitcoinSecret;
                if (secret == null)
                {
                    Alert("Not a valid private key specified.");
                    return;
                }
            }
            catch (Exception exp)
            {
                Alert(exp.ToString());
                return;
            }

            if (string.IsNullOrEmpty(unsignedText))
            {
                Alert("Unsigned commitment should have a value.");
                return;
            }

            if(string.IsNullOrEmpty(feeTxId))
            {
                Alert("Transaction Id for fee should have a value.");
                return;
            }

            if(string.IsNullOrEmpty(feeTxOutputNumber))
            {
                Alert("Transaction output number for fee should have a value.");
                return;
            }

            if(string.IsNullOrEmpty(feePrivateKey))
            {
                Alert("The private key for the address holding the fee should have a value.");
                return;
            }

            BitcoinSecret feeSecret = null;
            try
            {
                feeSecret = Base58Data.GetFromBase58Data(feePrivateKey, settings.Network) as BitcoinSecret;
                if (feeSecret == null)
                {
                    Alert("Not a valid private key for fee specified.");
                    return;
                }
            }
            catch (Exception exp)
            {
                Alert(exp.ToString());
                return;
            }

            Transaction commitmentTransaction = null;
            try
            {
                commitmentTransaction = new Transaction(unsignedText);
            }
            catch(Exception exp)
            {
                Alert(string.Format("Error in creating transaction: {0}", exp.ToString()));
                return;
            }

            try
            {
                commitmentTransaction = await AddFeeToTx(commitmentTransaction, feeTxId, feeTxOutputNumber);
                var outputTx = commitmentTransaction.ToHex();

                outputTx = await Helper.Helper.SignTransactionWorker
                    (new TransactionSignRequest { PrivateKey = feePrivateKey, TransactionToSign = outputTx }, sigHashType);
                outputTx = await Helper.Helper.SignTransactionWorker
                    (new TransactionSignRequest { PrivateKey = privKey, TransactionToSign = outputTx }, sigHashType);

                textSignedTransaction.Text = outputTx;
            }
            catch(Exception exp)
            {
                Alert(exp.ToString());
            }
        }

        private async Task<Transaction> AddFeeToTx(Transaction tx, string feeTxId, string feeTxOutputNumber)
        {
            int feeOutptutNumber = Int32.Parse(feeTxOutputNumber);
            return await AddFeeToTx(tx, feeTxId, feeOutptutNumber);
        }

        private async Task<Transaction> AddFeeToTx(Transaction tx, string feeTxId, int feeTxOutputNumber)
        {
            BlockchainExplorerHelper explorerHelper = new BlockchainExplorerHelper();
            var settings = Settings.ReadAppSettings();

            var txResut = await explorerHelper.GetTransactionHex(settings, feeTxId);
            if(txResut.HasErrorOccurred)
            {
                throw new Exception(string.Format("An error has occurred while getting transaction with id {0} : {1}",
                    feeTxId, txResut.Error));
            }

            tx.AddInput(new Transaction(txResut.TransactionHex), feeTxOutputNumber);

            return tx;
        }

        private void Alert(string text)
        {
            MessageBox.Show(text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
