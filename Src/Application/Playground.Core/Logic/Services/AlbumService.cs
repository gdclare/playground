using Playground.Core.Domain;
using Playground.Core.Logic.Abstract;
using Playground.Core.Logic.Models;
using Playground.Core.Logic.Services.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Playground.Core.Logic.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepo _albumRepo;

        public AlbumService(IAlbumRepo albumRepo)
        {
            _albumRepo = albumRepo;
        }

        public async Task<ICollection<AlbumModel>> GetAlbumsAsync()
        {
            var domainAlbums = await _albumRepo.GetAlbumsAsync();
            return MapUpAlbum(domainAlbums);
        }

        //TODO - Add Automapper here
        //TODO - If automapper remove me
        private ICollection<AlbumModel> MapUpAlbum(ICollection<Album> domainAlbums)
        {
            ICollection<AlbumModel> albums = new List<AlbumModel>();
            foreach (var domainAlbum in domainAlbums)
            {
                var album = new AlbumModel(
                    domainAlbum.Id,
                    domainAlbum.Name,
                    domainAlbum.Popularity
                    );

                foreach (var domainArtist in domainAlbum.Artists)
                {
                    album.Artists.Add(new ArtistModel(
                        domainArtist.Id,
                        domainArtist.Name,
                        domainArtist.FullDetailsLink,
                        domainArtist.Uri.ToString()
                        )
                    );
                }

                albums.Add(album);
            }

            return albums;
        }
    }
}