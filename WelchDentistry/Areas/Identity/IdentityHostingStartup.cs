using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WelchDentistry.Areas.Identity.Data;
using WelchDentistry.Data;

[assembly: HostingStartup(typeof(WelchDentistry.Areas.Identity.IdentityHostingStartup))]
namespace WelchDentistry.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WelchDentistryContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WelchDentistryContextConnection")));

                services.AddDefaultIdentity<WelchDentistryUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WelchDentistryContext>();
            });
        }
    }
}