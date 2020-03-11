using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week_6.Models
{

    public class Movie
    {

        public List<PerMovie> lstMovies;
        public class PerMovie
        {
            public int MovieId { get; set; }
            public string MovieName { get; set; }
        }
    }
}
