using Api.Configuration.Scrutor;
using Application.Configuration;
using Infrastructure.Configuration;
using Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        private IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScrutorScan();
            
            services.AddInfrastructure(Configuration);
            
            services.AddApplication();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, OperationalContext operationalContext)
        {
            //TODO: Do not use direct context
            operationalContext.Database.Migrate();
            
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("R-phobia API");
                });
            });
        }
    }
}
