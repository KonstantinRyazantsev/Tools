using NBitcoin;
using NBitcoin.BouncyCastle.Math;
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

            var settings = Settings.ReadAppSettings();

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

            Transaction transaction = null;
            try
            {
                transaction = new Transaction(unsignedText);
            }
            catch(Exception exp)
            {
                Alert(string.Format("Error in creating transaction: {0}", exp.ToString()));
                return;
            }

            try
            {
                var outputTx = await Helper.Helper.SignTransactionWorker
                    (new TransactionSignRequest { PrivateKey = privKey, TransactionToSign = unsignedText });
                textSignedTransaction.Text = outputTx;
            }
            catch(Exception exp)
            {
                Alert(exp.ToString());
            }
        }

        private void Alert(string text)
        {
            MessageBox.Show(text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
