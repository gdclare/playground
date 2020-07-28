using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Playground.Core.Data.Spotify.Api.DataModels.Album;
using Playground.Core.Data.Spotify.Api.DataModels;
using Playground.Core.Data.Spotify.Api.Static;
using Playground.Core.Data.Abstract;
using Playground.Core.Logic.Abstract;
using Playground.Core.Domain;
using Playground.Core.AppConfig.Abstract;
using Playground.Core.Data.Spotify.Api.Mapping;

namespace Playground.Core.Data.Spotify.Api.Repos
{
    public class AlbumRepo : ApiRepositoryBase, IAlbumRepo
    {
        public AlbumRepo(IApplicationConfiguration applicationConfiguration) : base(applicationConfiguration)
        {}

        public async Task<ICollection<Album>> GetAlbumsAsync()
        {
            var ids = new List<string>() {
                AlbumCodes.Mogwai.HappySongs,
                AlbumCodes.Mogwai.HardcoreWillNeverDie,
                AlbumCodes.Mono.TheLastDawn
                };

            var idsConcat = string.Join(",", ids.Select(x => x));
            var queryParameters = new QueryParams(new Dictionary<string, string>() { { "ids", idsConcat } });

            var albumDataModel = await ExecuteGet<AlbumDataModel>(APIEndpoints.AlbumEndpoints.GetAlbums, queryParameters.ToString());

            return AlbumDtoToAlbum.Map(albumDataModel);
        }
    }
}