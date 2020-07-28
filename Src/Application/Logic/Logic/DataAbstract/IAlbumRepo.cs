using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logic.DataAbstract
{
    public interface IAlbumRepo
    {
        Task<ICollection<Album>> GetAlbumsAsync();
    }
}
