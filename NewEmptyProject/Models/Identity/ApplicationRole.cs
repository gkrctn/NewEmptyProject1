using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmptyProject.Models.Identity
{
    public class ApplicationRole : IdentityRole // IdentityUser'dan sonra yaptık.
    {

        public ApplicationRole()
        {

        }

        public ApplicationRole(string name, string description)
        {
            this.Name = name;
            this.Description = description;
           
        }
        [StringLength(100)]
        public string Description { get; set; }

    }
}
