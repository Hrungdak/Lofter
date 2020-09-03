using System;
using Lofter.Areas.Identity.Data;
using Lofter.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Lofter.Areas.Identity.IdentityHostingStartup))]

namespace Lofter.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<LofterDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LofterDbContextConnection")));

                //ToDo: RequireConfirmedAccount = true when not in Development
                services.AddDefaultIdentity<LofterUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<LofterDbContext>();
            });
        }
    }
}