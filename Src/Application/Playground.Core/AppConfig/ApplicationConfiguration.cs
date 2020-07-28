using Playground.Core.AppConfig.Abstract;

namespace Playground.Core.AppConfig
{
    public class ApplicationConfiguration : IApplicationConfiguration
    {
        public SpotifyApiConfiguration SpotifyApiConfiguration { get; set; }
    }
}
