using Microsoft.Extensions.Configuration;
using Playground.Core.AppConfig.Abstract;

namespace Playground.Core.AppConfig.Factories
{
    public static class ApplicationConfigurationHelper
    {
        //Extend this out if we need to use different environments
        public static IApplicationConfiguration GetApplicationConfiguration(IConfiguration configuration)
        {
            return new ApplicationConfiguration
            {
                SpotifyApiConfiguration = configuration.GetSection("SpotifyApi").Get<SpotifyApiConfiguration>()
            };
        }
    }
}
