using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Domain
{
    public class EpisodeCompanion
    {
        public int EpisodeCompanionId { get; set; }
        public int EpisodeId { get; set; }
        public int CompanionId { get; set; }
    }
}
