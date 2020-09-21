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
using FluentValidation.AspNetCore;

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
                   var connection = Configuration.GetConnectionString(Common.Constants.CONNECTION_NAME);
                   if (connection == null)
                       throw new Exception(Common.CommonMessages.ExceptionMessage.CONNECTION_INFO_NOT_FOUND);

                   var password = Configuration[Common.Constants.CONNECTION_PASSWORD];
                   if (password == null)
                       throw new Exception(Common.CommonMessages.ExceptionMessage.CONNECTION_PASSWORD_NOT_FOUND);

                   connection = string.Format(connection, password);
                   opt.UseMySql(connection);
               });

                services.AddMediatR(typeof(List.Handler).Assembly);
                services.AddControllers()
                    .AddFluentValidation(cfg =>
                    {
                        cfg.RegisterValidatorsFromAssemblyContaining<Create>();
                    });
            }
            catch (Exception)
            {
                throw;
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
