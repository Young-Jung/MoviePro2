using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro2.Models
{
    public class Cast
    {
        public int Id { get; set; }

        [Display(Name = "Movie")]
        public int MovieId { get; set; }


        // TMDB castID used to identify cast across movies
        public int CastID { get; set; }

        public string Department { get; set; }
        // Real Name
        public string Name { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }

        // Profile Image
        [Display(Name = "Profile Pic")]
        public byte[] Profile { get; set; }
        public string ContentType { get; set; }

        public Movie Movie { get; set; }
    }
}
