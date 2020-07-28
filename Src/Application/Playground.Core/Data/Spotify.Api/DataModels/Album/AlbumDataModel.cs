using Newtonsoft.Json;
using System.Collections.Generic;

namespace Playground.Core.Data.Spotify.Api.DataModels.Album
{
    [JsonObject]
    internal class AlbumDataModel
    {
        [JsonProperty("albums")]
        public ICollection<AlbumDetailDataModel> AlbumDetails { get; set; }
    }
}