﻿using System;
using System.Collections.Generic;
using System.Text;
using EticaretMonolit.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EticaretMonolit.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EticaretMonolit.Models.Urun> Urun { get; set; }
        public DbSet<EticaretMonolit.Models.Kategori> Kategori { get; set; }

    }
}
