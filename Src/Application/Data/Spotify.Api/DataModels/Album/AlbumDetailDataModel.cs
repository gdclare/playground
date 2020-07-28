using Newtonsoft.Json;
using Spotify.Api.DataModels.Artist;
using System.Collections.Generic;

namespace Spotify.Api.DataModels.Album
{
    [JsonObject]
    internal class AlbumDetailDataModel
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