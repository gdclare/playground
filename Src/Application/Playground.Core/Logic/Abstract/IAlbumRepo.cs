using Playground.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Playground.Core.Logic.Abstract
{
    public interface IAlbumRepo
    {
        Task<ICollection<Album>> GetAlbumsAsync();
    }
}
