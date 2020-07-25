using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Application.Books;
using MediatR;
using System;

namespace BookManagerAPI
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
            try
            {
                services.AddDbContext<DataContext>(opt =>
                {
                    var connection = Configuration.GetConnectionString("MysqlConnection");
                    if (connection == null)
                        throw new Exception("Connectionî•ñ‚ª“o˜^‚³‚ê‚Ä‚¢‚Ü‚¹‚ñB");

                    var password = Configuration["DbPassword"];
                    if (password == null)
                        throw new Exception("DBÚ‘±ƒpƒXƒ[ƒh‚ª“o˜^‚³‚ê‚Ä‚¢‚Ü‚¹‚ñB");

                    connection = string.Format(connection, password);                    
                    opt.UseMySql(connection);
                });

                services.AddMediatR(typeof(List.Handler).Assembly);
                services.AddControllers();

            }
            catch (Exception)
            {
                

                return;
            }        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
