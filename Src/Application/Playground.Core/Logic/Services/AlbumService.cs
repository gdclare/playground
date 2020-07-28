using Playground.Core.Logic.Abstract;
using Playground.Core.Logic.Mapping;
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
            return AlbumToAlbumModel.Map(domainAlbums);
        }        
    }
}