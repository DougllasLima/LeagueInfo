using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInfo.Summoner
{
   public class ParticipantDTO
    {
        public ParticipantStatsDTO stats { get; set; }
        public int participantId { get; set; }
        public List<RuneDTO> runes { get; set; }
        public ParticipantTimelineDTO timeline { get; set; }
        public int teamId { get; set; }
        public int spell2Id { get; set; }
        public List<MasteryDTO> masteries { get; set; }
        public string highestAchievedSeasonTier { get; set; }
        public int spell1Id { get; set; }
        public int championId { get; set; }
    }
}
