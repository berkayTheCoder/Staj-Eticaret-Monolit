using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretMonolit.Models
{
    public class AppUser:IdentityUser<string>
    {
        public AppUser() : base()
        {
        }
        public AppUser(string userName) : base(userName)
        {
        }


    }
}
