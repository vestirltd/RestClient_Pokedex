using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokedex.Services;
using Pokedex.Services.Interface;

namespace Pokedex
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Registering the poke services and ApiNetServices
            services.AddScoped<IPokemonServices, pokemonServices>();
            
            services.AddControllers();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}