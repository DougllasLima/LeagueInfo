using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInfo.Summoner
{
   public class ParticipantTimelineDTO
    {
        public string lane { get; set; }
        public int participantId { get; set; }
        public Map csDiffPerMinDeltas { get; set; }
        public Map goldPerMinDeltas { get; set; }
        public Map xpDiffPerMinDeltas { get; set; }
        public Map creepsPerMinDeltas { get; set; }
        public Map xpPerMinDeltas { get; set; }
        public string role { get; set; }
        public Map damageTakenDiffPerMinDeltas { get; set; }
        public Map damageTakenPerMinDeltas { get; set; }
    }

    public class Map
    {
        public string A { get; set; }
        public double B { get; set; }
    }
}
