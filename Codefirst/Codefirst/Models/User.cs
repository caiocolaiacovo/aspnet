using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst.Models
{
    public class User : Person
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}