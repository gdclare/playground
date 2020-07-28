using Newtonsoft.Json;
using System.Collections.Generic;

namespace Spotify.Api.DataModels.Album
{
    [JsonObject]
    internal class AlbumDataModel
    {
        [JsonProperty("albums")]
        public ICollection<AlbumDetailDataModel> AlbumDetails { get; set; }
    }
}