using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EticaretMonolit.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EticaretMonolit.Data
{
    public class EticaretMonolitContext : IdentityDbContext<ApplicationUser>
    {
        public EticaretMonolitContext (DbContextOptions<EticaretMonolitContext> options)
            : base(options)
        {
        }

        public DbSet<EticaretMonolit.Models.Urun> Urun { get; set; }

        public DbSet<EticaretMonolit.Models.Kategori> Kategori { get; set; }
    }
}
