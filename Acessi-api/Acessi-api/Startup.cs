
using Acessi_api.Context;
using Acessi_api.Interfaces.User;
using Acessi_api.Services.User;
using Microsoft.EntityFrameworkCore;

namespace Acessi_api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddHealthChecks();

            services.AddDbContext<AcessiContext>(options =>
            options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserService,UserService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) 
                .AllowCredentials());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }


    }
}
