using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OffchainHelper
{
    public class Settings
    {
        public Network Network
        {
            get;
            set;
        }

        public string RPCIP
        {
            get;
            set;
        }

        public int RPCPort
        {
            get;
            set;
        }

        public string RPCUsername
        {
            get;
            set;
        }

        public string RPCPassword
        {
            get;
            set;
        }
        public static Settings ReadAppSettings()
        {
            Settings settings = new Settings();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            settings.Network = config.AppSettings.Settings["Network"].Value.ToLower().Equals("main") ? NBitcoin.Network.Main : NBitcoin.Network.TestNet;
            settings.RPCIP = config.AppSettings.Settings["RPCIP"].Value;
            settings.RPCPort = Int32.Parse(config.AppSettings.Settings["RPCPort"].Value);
            settings.RPCUsername = config.AppSettings.Settings["RPCUsername"].Value;
            settings.RPCPassword = config.AppSettings.Settings["RPCPassword"].Value;
            return settings;
        }
    }
}
