using Newtonsoft.Json;
using System.Collections.Generic;

namespace Playground.Core.Logic.Api.Spotify.DataModels.Artist
{
    [JsonObject]
    public class ArtistDataModel
    {
        [JsonProperty("artists")]
        public ICollection<ArtistDetailDataModel> ArtistDetails { get; set; }
    }
}