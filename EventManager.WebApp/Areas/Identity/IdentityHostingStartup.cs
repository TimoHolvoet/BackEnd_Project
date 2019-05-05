using System;
using EventManager.Core.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EventManager.WebApp.Areas.Identity.IdentityHostingStartup))]
namespace EventManager.WebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            try
            {
                builder.ConfigureServices((context, services) => {
                    services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<EventManagerDBContext>();
                });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}