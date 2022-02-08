﻿using System.Collections.Generic;

namespace DoctorWho.Data.DataModel
{
    public class Author
    {
        public Author()
        {
            Episodes = new List<Episode>();
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
