using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PluginFramework.Common;
using PluginFramework.DTO;
using PluginFramework.Service.Interfaces;

namespace PluginFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WireFrameController : ControllerBase
    {
        private readonly IChangeImage _changeImage;
        public WireFrameController(IChangeImage changeImage)
        {
            _changeImage = changeImage;
        }

        [HttpPost("ChangeImage")]
        public IActionResult ChangeImage(WireFrameInfo wireFrame)
        {
            return Ok(_changeImage.UpdateImage(wireFrame));
        }

        [HttpPost("ChangeImages")]
        public IActionResult ChangeImages(List<WireFrameInfo> wireFrames)
        {
            return Ok(_changeImage.UpdateImages(wireFrames));
        }
    }
}
