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
                    
                    //registratie van Users
                    services
                    .AddDefaultIdentity<IdentityUser>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<EventManagerDBContext>();

                    //zou roles moeten registreren maar crasht
                    //services.AddIdentity<IdentityUser, IdentityRole>();
                });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}