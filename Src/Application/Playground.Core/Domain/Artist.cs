using Playground.Core.Domain.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Playground.Core.Domain
{
    public class Artist : IHasIdentifier, IHasName
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string FullDetailsLink { get; set; }

        public Uri Uri { get; set; }

        public Artist(int id, string name, string fullDetailsLink, Uri uri)
        {
            Id = id;
            Name = name;
            FullDetailsLink = fullDetailsLink;
            Uri = uri;
        }
    }
}
