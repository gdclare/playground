using Newtonsoft.Json;

namespace Playground.Core.Logic.Api.Spotify.DataModels.Artist
{
    [JsonObject]
    public class ArtistDetailDataModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("href")]
        public string FullDetailsLink { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}