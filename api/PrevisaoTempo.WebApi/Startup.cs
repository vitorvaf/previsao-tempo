using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PrevisaoTempo.Application.SearchUser;
using PrevisaoTempo.Application.SearchUser.Interfaces;
using PrevisaoTempo.Data.Context;
using PrevisaoTempo.Data.ExternalServices;
using PrevisaoTempo.Data.Repository;
using PrevisaoTempo.Domain.Interfaces;

namespace PrevisaoTempo.WebApi
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

            services.AddCors();   
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>
                 (options => options.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=password"));
            services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<ISearchUserRepository, SearchUserRepository>();
            services.AddScoped<ISearchUserAppService, SearchUserAppService>();
            services.AddScoped<IOpenWeatherApi, OpenWeatherApi>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

           // global cors policy
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials           

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
