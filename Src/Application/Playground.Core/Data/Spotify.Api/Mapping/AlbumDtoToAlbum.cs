using Playground.Core.Data.Spotify.Api.DataModels.Album;
using Playground.Core.Domain;
using System;
using System.Collections.Generic;

namespace Playground.Core.Data.Spotify.Api.Mapping
{
    public static class AlbumDtoToAlbum
    {
        //TODO - If we have automapper remove me
        public static ICollection<Album> Map(AlbumDataModel albumDataModels)
        {
            ICollection<Album> albums = new List<Album>();
            foreach (var albumData in albumDataModels.AlbumDetails)
            {
                var album = new Album(1,
                    albumData.Name,
                    albumData.Popularity
                    );

                foreach (var artistData in albumData.Artists)
                {
                    album.Artists.Add(new Artist(1,
                        artistData.Name,
                        artistData.FullDetailsLink,
                        new Uri(artistData.Uri))
                    );
                }

                albums.Add(album);
            }

            return albums;
        }
    }
}
