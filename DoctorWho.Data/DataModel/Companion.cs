using System.Collections.Generic;

namespace DoctorWho.Data.DataModel
{
    public class Companion
    {
        public Companion()
        {
            EpisodeCompanions = new List<EpisodeCompanion>();
        }

        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
        public List<EpisodeCompanion> EpisodeCompanions { get; set; }
    }
}
