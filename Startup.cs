using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Abitasharp.Models;
using Microsoft.Extensions.Logging;
using Abitasharp.Controllers.Amministrazione;
using Abitasharp.Controllers.GestioneProfilo;
using Abitasharp.Controllers.Ricerca;
using Abitasharp.Controllers.GestioneAnnunci;
using Abitasharp.Controllers.Account;
using Microsoft.AspNetCore.Identity;

namespace Abitasharp
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
            services.AddMvc();

            services.AddDbContext<ApplicationContext>(options =>
                    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<Utente, RuoloUtente>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options => {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
            });

            _registerControllers(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, SignInManager<Utente> s)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();

                /*

                //test
                if (s.UserManager.FindByIdAsync("IDCAZZUTISSIMO").Result == null)
                {
                    var result = s.UserManager.CreateAsync(new ProfiloAzienda
                    {
                        Id = "IDCAZZUTISSIMO",
                        Email = "dev@app.com"
                    }, "Aut94L#G-a").Result;
                }

    */
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=CercaAnnunci}/{action=Index}/{id?}");
            });

        }

        private void _registerControllers(IServiceCollection services)
        {
            services.AddTransient<IAmministraPiattaforma, AmministraPiattaforma>();
            services.AddTransient<IBannaUtente, BannaUtente>();
            services.AddTransient<ICancellaProfilo, CancellaProfilo>();
            services.AddTransient<ICercaAnnunci, CercaAnnunci>();
            services.AddTransient<ICercaProfilo, CercaProfilo>();
            services.AddTransient<IChiudiAnnuncio, ChiudiAnnuncio>();
            services.AddTransient<ICreaAnnuncio, CreaAnnuncio>();
            services.AddTransient<IEliminaAnnuncio, EliminaAnnuncio>();
            services.AddTransient<IGestioneAnnunci, GestioneAnnunci>();
            services.AddTransient<IGestioneProfilo, GestioneProfilo>();
            services.AddTransient<ILogin, Login>();
            services.AddTransient<IModificaAnnuncio, ModificaAnnuncio>();
            services.AddTransient<IModificaInfo, ModificaInfo>();
            services.AddTransient<IRegCercaAnnunci, RegCercaAnnunci>();
            services.AddTransient<IRegistrazione, Registrazione>();
        }
    }
}
