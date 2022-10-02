using Api.Configuration.AppSettings;
using Infrastructure;

namespace Api
{
    public static class EntryPoint
    {
        public static async Task Main(string[] args)
        {
            IHostBuilder webHostBuilder = BuildWebHost();

            IHost host = webHostBuilder.Build();

            await host.RunAsync();
        }

        private static IHostBuilder BuildWebHost()
        {
            return Host.CreateDefaultBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseEnvironment(EnvironmentVariables.Environment.GetValue())
                .ConfigureAppConfiguration(AppConfiguration.Configure)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}