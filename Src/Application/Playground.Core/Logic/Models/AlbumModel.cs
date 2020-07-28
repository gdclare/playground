using System.Collections.Generic;

namespace Playground.Core.Logic.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Popularity { get; set; }

        public ICollection<ArtistModel> Artists { get; set; }

        public AlbumModel()
        {
            Artists = new List<ArtistModel>();
        }

        public AlbumModel(int id, string name, int popularity) : this()
        {
            Id = id;
            Name = name;
            Popularity = popularity;
        }
    }
}