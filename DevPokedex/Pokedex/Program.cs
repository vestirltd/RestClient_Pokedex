using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
namespace Pokedex
{
    public class Program
    {
        public static void Main(string[] ar)
        {
            CreateHostBuilder(ar).Build().Run();
        }
        private static IHostBuilder CreateHostBuilder(string[] ar)=>
        Host.CreateDefaultBuilder(ar).ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });
    }
}