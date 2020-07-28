using Domain.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Album : IHasIdentifier, IHasName
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Popularity { get; set; }

        public ICollection<Artist> Artists { get; set; }

        public Album()
        {
            Artists = new List<Artist>();
        }
        
        public Album(int id, string name, int popularity) : this()
        {
            Id = id;
            Name = name;
            Popularity = popularity;
        }
    }
}