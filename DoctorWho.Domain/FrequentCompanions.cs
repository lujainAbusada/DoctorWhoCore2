using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Domain
{
    public class FrequentCompanions:IFrequentCharacters
    {
        public int CompanionId { get; set; }
        public int Frequency { get; set; }
    }
}
