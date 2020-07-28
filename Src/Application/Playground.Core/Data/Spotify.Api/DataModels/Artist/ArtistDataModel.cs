using Newtonsoft.Json;
using System.Collections.Generic;

namespace Playground.Core.Data.Spotify.Api.DataModels.Artist
{
    [JsonObject]
    public class ArtistDataModel
    {
        [JsonProperty("artists")]
        public ICollection<ArtistDetailDataModel> ArtistDetails { get; set; }
    }
}