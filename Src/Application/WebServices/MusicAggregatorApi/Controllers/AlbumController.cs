using System.Threading.Tasks;
using Logic.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MusicAggregatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> _logger;
        private readonly IAlbumService _albumService;

        public AlbumController(ILogger<AlbumController> logger, IAlbumService albumService)
        {
            _logger = logger;
            _albumService = albumService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlbums()
        {
            var albums = await _albumService.GetAlbumsAsync();
            return Ok(new { response = albums });
        }
    }
}
