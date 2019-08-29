using LeagueInfo.Summoner;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInfo.Config
{
    public class Match_V4 : ConfigAPI
    {
        public Match_V4(string region) : base(region)
        {

        }

        public MatchDTO GetMatchByMatchId(long matchId)
        {
            string path = "match/v4/matches/" + matchId;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<MatchDTO>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
