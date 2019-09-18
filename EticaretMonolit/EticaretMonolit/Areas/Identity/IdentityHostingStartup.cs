using System;
using EticaretMonolit.Areas.Identity.Data;
using EticaretMonolit.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EticaretMonolit.Areas.Identity.IdentityHostingStartup))]
namespace EticaretMonolit.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EticaretMonolitContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("EticaretMonolitContextConnection")));

                services.AddDefaultIdentity<EticaretMonolitUser>()
                    .AddEntityFrameworkStores<EticaretMonolitContext>();
            });
        }
    }
}