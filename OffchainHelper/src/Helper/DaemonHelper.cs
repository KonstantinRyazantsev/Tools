using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;

namespace OffchainHelper.Helper
{
    public class DaemonHelper
    {
        public async Task<Tuple<bool, string, string>> GetTransactionHex(Settings settings, string transactionId)
        {
            string transactionHex = "";
            bool errorOccured = false;
            string errorMessage = "";
            try
            {
                var client = Helper.GetRPCClient(settings);
                transactionHex = (await client.GetRawTransactionAsync(uint256.Parse(transactionId), true)).ToHex();
            }
            catch (Exception e)
            {
                errorOccured = true;
                errorMessage = e.ToString();
            }
            return new Tuple<bool, string, string>(errorOccured, errorMessage, transactionHex);
        }
    }
}
