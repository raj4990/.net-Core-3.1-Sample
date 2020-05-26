using MyNewTheme.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNewTheme.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public City? City { get; set; }
        public Gender? Gender { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }

        public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }

    }
}
