using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInfo.Config
{
   public class ConfigAPI
    {
        private string Key { get; set; }
        private string Region { get; set; }

        public ConfigAPI(string region)
        {
            Region = region;
            Key = "RGAPI-c5f14534-e6d3-4da9-bd71-3dd88e624420";/*GetKey("API /Key.txt");*/
        }

        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }

        protected string GetURI(string path)
        {
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }

        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
