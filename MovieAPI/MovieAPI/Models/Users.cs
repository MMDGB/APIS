using System;
using System.Collections.Generic;

namespace MovieAPI.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IsAdmin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
