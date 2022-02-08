using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Domain
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
