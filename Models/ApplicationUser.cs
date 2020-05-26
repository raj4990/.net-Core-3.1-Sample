using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNewTheme.Models
{
    public class ApplicationUser :IdentityUser
    {
        public City? City { get; set; }
        public Gender? Gender { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }

    }
}
