using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretMonolit.Models
{
    public class AppRole : IdentityRole<string>
    {
        public AppRole() : base()
        {
        }
        public AppRole(string roleName) : base(roleName)
        {
        }

    }
}
