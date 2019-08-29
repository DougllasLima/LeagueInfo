using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueInfo.Summoner;
using Newtonsoft.Json;

namespace LeagueInfo.Config
{

    public class Champion_Mastery_V4 : ConfigAPI
    {
        public Champion_Mastery_V4(string region) : base(region)
        {
        }

        public List<ChampionMasteryDTO> GetChampMasteryList(string encryptedSummonerId)
        {
            string path = "champion-mastery/v4/champion-masteries/by-summoner/" + encryptedSummonerId;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<ChampionMasteryDTO>>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
