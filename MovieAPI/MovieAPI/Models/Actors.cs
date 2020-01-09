using System;
using System.Collections.Generic;

namespace MovieAPI.Models
{
    public partial class Actors
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Cnp { get; set; }
        public int Age { get; set; }

        public virtual Movies Movie { get; set; }
    }
}
