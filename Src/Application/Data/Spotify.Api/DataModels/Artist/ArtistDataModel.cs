﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Spotify.Api.DataModels.Artist
{
    [JsonObject]
    internal class ArtistDataModel
    {
        [JsonProperty("artists")]
        public ICollection<ArtistDetailDataModel> ArtistDetails { get; set; }
    }
}