using Data.Abstract;
using Spotify.Api.Static;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Spotify.Api.DataModels.Album;
using Spotify.Api.DataModels;
using Logic.DataAbstract;
using System;

namespace Api.Repos
{
    public class AlbumRepo : ApiRepositoryBase, IAlbumRepo
    {
        public async Task<ICollection<Album>> GetAlbumsAsync()
        {
            var ids = new List<string>() {
                AlbumCodes.Mogwai.HappySongs,
                AlbumCodes.Mogwai.HardcoreWillNeverDie,
                AlbumCodes.Mono.TheLastDawn
                };

            var idsConcat = string.Join(",", ids.Select(x => x));
            var queryParameters = new QueryParams(new Dictionary<string, string>() { { "ids", idsConcat } });

            var albumDataModel = await ExecuteGet<AlbumDataModel>(APIEndpoints.Album.GetAlbums, queryParameters.ToString());

            return MapUpAlbum(albumDataModel);
        }

        //TODO - Add Automapper here
        //TODO - If automapper remove me
        private ICollection<Album> MapUpAlbum(AlbumDataModel albumDataModels)
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
                        new Uri(artistData.Uri) )
                    );
                }

                albums.Add(album);
            }

            return albums;
        }
    }
}
