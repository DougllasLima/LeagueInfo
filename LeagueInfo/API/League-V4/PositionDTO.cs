using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInfo.Summoner
{
    public class PositionDTO
    {
        public string Tier { get; set; }
        public string Rank { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string QueueType { get; set; }
        public string summonerName { get; set; }
        public bool hotStreak { get; set; }
        public int leaguePoints { get; set; }
    }
}
