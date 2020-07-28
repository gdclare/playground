using Newtonsoft.Json;
using Playground.Core.Data.Spotify.Api.DataModels.Artist;
using System.Collections.Generic;

namespace Playground.Core.Data.Spotify.Api.DataModels.Album
{
    [JsonObject]
    public class AlbumDetailDataModel
    {
        [JsonProperty("album_type")]
        public string AlbumType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("artists")]
        public ICollection<ArtistDetailDataModel> Artists { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }
    }
}