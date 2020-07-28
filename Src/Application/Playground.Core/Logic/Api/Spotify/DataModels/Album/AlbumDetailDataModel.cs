using Newtonsoft.Json;
using Playground.Core.Logic.Api.Spotify.DataModels.Artist;
using System.Collections.Generic;

namespace Playground.Core.Logic.Api.Spotify.DataModels.Album
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