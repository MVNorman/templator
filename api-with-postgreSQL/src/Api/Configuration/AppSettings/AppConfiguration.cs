namespace Api.Configuration.AppSettings
{
    internal sealed class AppConfiguration
    {
        public static void Configure(HostBuilderContext hostContext, IConfigurationBuilder config)
        {
            IHostEnvironment environment = hostContext.HostingEnvironment;

            config
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", true, true);

            config.AddEnvironmentVariables();

            if (environment.IsDevelopment())
            {
                config.AddUserSecrets<AppConfiguration>();
            }
        }
    }
}