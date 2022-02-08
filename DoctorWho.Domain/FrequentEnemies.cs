using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Domain
{
    public class FrequentEnemies:IFrequentCharacters
    {
        public int EnemyId { get; set; }
        public int Frequency { get; set; }
    }
}
