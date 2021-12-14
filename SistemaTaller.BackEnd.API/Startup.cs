using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SistemaTaller.BackEnd.API.Services;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SistemaTaller.BackEnd.API", Version = "v1" });
            });

            services.AddTransient<IUnitOfWork, UnitOfWorkSqlServer>();
            services.AddTransient<IVehiculosService, VehiculosService>();
            services.AddTransient<IClientesService, ClientesService>();
            services.AddTransient<IMecanicosService, MecanicosService>();
            services.AddTransient<ITalleresService, TalleresService>();
            services.AddTransient<IMecanicosDeTalleresService, MecanicosDeTalleresService>();
            services.AddTransient<IVehiculosDeClientesService, VehiculosDeClientesService>();
            services.AddTransient<IRepuestosService, RepuestosService>();
            services.AddTransient<IEstadoReparacionesService, EstadoReparacionesService>();
            services.AddTransient<IReparacionesService, ReparacionesService>();
            services.AddTransient<IRepuestosDeReparacionesService, RepuestosDeReparacionesService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SistemaTaller.BackEnd.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
