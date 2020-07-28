using Logic.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logic.Services.Abstract
{
    public interface IAlbumService
    {
        Task<ICollection<AlbumModel>> GetAlbumsAsync();
    }
}
