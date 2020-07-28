using System.Collections.Generic;

namespace Playground.Core.Logic.Models
{
    public class AlbumViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Popularity { get; set; }

        public ICollection<ArtistViewModel> Artists { get; set; }

        public AlbumViewModel()
        {
            Artists = new List<ArtistViewModel>();
        }

        public AlbumViewModel(int id, string name, int popularity) : this()
        {
            Id = id;
            Name = name;
            Popularity = popularity;
        }
    }
}