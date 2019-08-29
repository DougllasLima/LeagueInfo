using LeagueInfo.API.Match_V4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInfo.Summoner
{
   public class MatchlistDTO
    {
        public List<MatchReferenceDTO> matches { get; set; }
        public int totalGames { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
    }
}
