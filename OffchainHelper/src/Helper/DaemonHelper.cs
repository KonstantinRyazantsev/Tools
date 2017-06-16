using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;
using OffchainHelper.Entities;

namespace OffchainHelper.Helper
{
    public class DaemonHelper
    {
        public async Task<GetTransactionHexResult> GetTransactionHex(Settings settings, string transactionId)
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
            return new GetTransactionHexResult { HasErrorOccurred = errorOccured, Error = errorMessage, TransactionHex = transactionHex };
        }
    }
}
