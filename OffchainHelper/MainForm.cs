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
                var dictionary = await Helper.ReadWordList();
                var settings = Settings.ReadAppSettings();

                var wordList = textWordList.Text;
                var splittedWordList = wordList.Split(new char[] { ' ' });
                splittedWordList = splittedWordList.Where(c => !string.IsNullOrEmpty(c)).ToArray();
                if (splittedWordList.Count() != 12)
                {
                    MessageBox.Show("The count of words should be exactly 12");
                }
                else
                {
                    uint[] indexes = new uint[12];

                    BigInteger binaryKey = new BigInteger(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
                    for (int i = 0; i < 12; i++)
                    {
                        if (!dictionary.ContainsKey(splittedWordList[i]))
                        {
                            MessageBox.Show(string.Format("{0} is not present in the dictionary", splittedWordList[i]));
                            return;
                        }
                        else
                        {
                            indexes[i] = dictionary[splittedWordList[i]];
                            binaryKey = binaryKey.ShiftLeft(11);
                            binaryKey = binaryKey.Add(BigInteger.ValueOf(indexes[i]));
                        }
                    }

                    binaryKey = binaryKey.ShiftRight(4);
                    var nonZeroArray = binaryKey.ToByteArrayUnsigned();
                    Key key = new Key((new byte[32 - nonZeroArray.Length]).Concat(nonZeroArray).ToArray());
                    BitcoinSecret secret = new BitcoinSecret(key, settings.Network);
                    textGeneratedPrivateKey.Text = secret.ToWif();

                    var addr = secret.GetAddress();
                    textPrivateAddr.Text = addr.ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
