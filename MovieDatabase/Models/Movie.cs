using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabase.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Runtime { get; set; }
    }
}

