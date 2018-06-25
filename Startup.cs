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
using Abitasharp.Controllers.Interfacce;
using Abitasharp.Controllers.Classi;
using Microsoft.Extensions.Logging;

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

            _registerControllers(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

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
