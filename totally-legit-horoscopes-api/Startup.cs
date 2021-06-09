using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using Npgsql;
using totally_legit_horoscopes_api.Contexts;
using Microsoft.EntityFrameworkCore;

namespace totally_legit_horoscopes_api
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
            services.AddDbContext<TotallyLegitHoroscopesContext>(options => options.UseNpgsql(GetConnectionString()));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Totally Legit Horoscopes API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Totally Legit Horoscopes v1");
                c.RoutePrefix = string.Empty;
             });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private string GetConnectionString()
        {
            string DatabaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
            if (String.IsNullOrEmpty(DatabaseUrl))
            {
                DatabaseUrl = Configuration.GetConnectionString("pg");
            }
            Uri DatabaseUri = new Uri(DatabaseUrl);
            string[] UserInfo = DatabaseUri.UserInfo.Split(':');
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder
            {
                Host = DatabaseUri.Host,
                Port = DatabaseUri.Port,
                Username = UserInfo[0],
                Password = UserInfo[1],
                Database = DatabaseUri.LocalPath.TrimStart('/'),
                SslMode = SslMode.Require,
                TrustServerCertificate = true
            };
            return builder.ToString();
        }
    }
}
