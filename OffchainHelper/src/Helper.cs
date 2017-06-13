using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffchainHelper.src
{
    public static class Helper
    {
        public static async Task<IDictionary<string, uint>> ReadWordList()
        {
            var retDict = new Dictionary<string, uint>();

            using (StreamReader reader = new StreamReader("data\\wordlist.txt"))
            {
                var wordlist = await reader.ReadToEndAsync();
                var words = wordlist.Split(new char[] { '\r', '\n', ' ' }).Where(w => !string.IsNullOrEmpty(w)).ToArray();
                
                for (uint i = 0; i < words.Count(); i++)
                {
                    retDict.Add(words[i], i);
                }
            }

            return retDict;
        }
    }
}
