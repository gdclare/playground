using Playground.Core.Logic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Playground.Core.Logic.Services.Abstract
{
    public interface IAlbumService
    {
        Task<ICollection<AlbumViewModel>> GetAlbumsAsync();
    }
}
