using Playground.Core.Logic.Api.Spotify.DataModels.Album;
using Playground.Core.Logic.Models;
using System.Collections.Generic;

namespace Playground.Core.Logic.Mapping
{
    //TODO - If we have automapper remove me
    public class AlbumDtoToAlbumModel
    {
        public static ICollection<AlbumViewModel> Map(AlbumDataModel dataAlbums)
        {
            ICollection<AlbumViewModel> albums = new List<AlbumViewModel>();
            foreach (var dataAlbum in dataAlbums.AlbumDetails)
            {
                var album = new AlbumViewModel(
                    0,
                    dataAlbum.Name,
                    dataAlbum.Popularity
                    );

                foreach (var domainArtist in dataAlbum.Artists)
                {
                    album.Artists.Add(new ArtistViewModel(
                        0,
                        domainArtist.Name,
                        domainArtist.FullDetailsLink,
                        domainArtist.Uri
                        )
                    );
                }

                albums.Add(album);
            }

            return albums;
        }
    }
}