﻿using System.ComponentModel.DataAnnotations;

namespace Playground.Core.Logic.Models
{
    public class ArtistModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FullDetailsLink { get; set; }

        public string Uri { get; set; }

        public ArtistModel(int id, string name, string fullDetailsLink, string uri)
        {
            Id = id;
            Name = name;
            FullDetailsLink = fullDetailsLink;
            Uri = uri;
        }
    }
}
