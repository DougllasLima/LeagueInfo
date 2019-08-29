using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInfo.Summoner
{
   public class ChampionMasteryDTO
    {
        public bool chestGranted { get; set; }
        public int championLevel { get; set; }
        public int championPoints { get; set; }
        public long championId { get; set; }
        public long championPointsUntilNextLevel { get; set; }
        public long lastPlayTime { get; set; }
        public int tokensEarned { get; set; }
        public long championPointsSinceLastLevel { get; set; }
        public string summonerId { get; set; }
    }
}
