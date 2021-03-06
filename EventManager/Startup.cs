﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManager.Core.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using EventManager.Core;
using EventManager.Core.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace EventManager
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //dependency injection
            services.AddScoped<IEventRepo, EventRepo>();

            //use auto mapper
            services.AddAutoMapper();


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //access to database...
            //migrationsAssembly geeft mee waar de migrations bijgehouden zullen worden.
            services.AddDbContext<EventManagerDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),b => b.MigrationsAssembly("EventManager.API")
            ));

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<EventManagerDBContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
