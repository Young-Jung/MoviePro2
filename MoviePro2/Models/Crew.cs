using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro2.Models
{
    public class Crew
    {
        public int Id { get; set; }
        public int MovieID { get; set; }

        //used by TMDB to identify crew across movies
        public int CrewID { get; set; }

        public string Department { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public byte[] Profile { get; set; }
        public string ContentType { get; set; }

        public Movie Movie { get; set; }
    }
}
