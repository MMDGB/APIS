using System;
using System.Collections.Generic;

namespace MovieAPI.Models
{
    public partial class Movies
    {
        public Movies()
        {
            Actors = new HashSet<Actors>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Crew { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Actors> Actors { get; set; }
    }
}
