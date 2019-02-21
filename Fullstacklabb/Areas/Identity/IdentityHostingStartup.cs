using System;
using Fullstacklabb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Fullstacklabb.Areas.Identity.IdentityHostingStartup))]
namespace Fullstacklabb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FullstacklabbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FullstacklabbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<FullstacklabbContext>();
            });
        }
    }
}