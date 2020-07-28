using Playground.Core.Domain;
using Playground.Core.Logic.Models;
using System.Collections.Generic;

namespace Playground.Core.Logic.Mapping
{
    //TODO - If we have automapper remove me
    public class AlbumToAlbumModel
    {
        public static ICollection<AlbumModel> Map(ICollection<Album> domainAlbums)
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