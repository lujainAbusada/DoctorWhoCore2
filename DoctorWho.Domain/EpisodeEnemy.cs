using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Domain
{
    public class EpisodeEnemy
    {
        public int EpisodeEnemyId { get; set; }
        public int EpisodeId { get; set; }
        public int EnemyId { get; set; }
    }
}
