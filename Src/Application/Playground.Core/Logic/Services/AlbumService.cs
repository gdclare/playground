using Playground.Core.AppConfig.Abstract;
using Playground.Core.Logic.Api.Abstract;
using Playground.Core.Logic.Api.Models;
using Playground.Core.Logic.Api.Spotify.DataModels.Album;
using Playground.Core.Logic.Api.Spotify.Static;
using Playground.Core.Logic.Mapping;
using Playground.Core.Logic.Models;
using Playground.Core.Logic.Services.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.Core.Logic.Services
{
    public class AlbumService : ApiRepositoryBase, IAlbumService
    {
        public AlbumService(IApplicationConfiguration applicationConfiguration) : base(applicationConfiguration)
        {}

        public async Task<ICollection<AlbumViewModel>> GetAlbumsAsync()
        {
            var ids = new List<string>() {
                AlbumCodes.Mogwai.HappySongs,
                AlbumCodes.Mogwai.HardcoreWillNeverDie,
                AlbumCodes.Mono.TheLastDawn
                };

            var idsConcat = string.Join(",", ids.Select(x => x));
            var queryParameters = new QueryParams(new Dictionary<string, string>() { { "ids", idsConcat } });

            var albumDataModel = await ExecuteGet<AlbumDataModel>(APIEndpoints.AlbumEndpoints.GetAlbums, queryParameters.ToString());

            return AlbumDtoToAlbumModel.Map(albumDataModel);
        }        
    }
}