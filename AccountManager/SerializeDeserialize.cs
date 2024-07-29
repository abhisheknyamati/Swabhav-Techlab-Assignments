using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AccountManager
{
    internal class SerializeDeserialize: AccountManager
    {
        public static void Serialize(List<Account> accounts)
        {
            File.WriteAllText("AccountData.json", JsonConvert.SerializeObject(accounts));
        }

        public static List<Account> Deserialize()
        {
            List<Account> movies = new List<Account>();
            string fileName = "AccountData.json";
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                movies = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            else
            {
                File.WriteAllText(fileName, JsonConvert.SerializeObject(movies));
            }
            return movies;
        }
    }
}
