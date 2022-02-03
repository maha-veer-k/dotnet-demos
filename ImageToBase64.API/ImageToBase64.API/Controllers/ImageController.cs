using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames.Image;
using System.IO;
using System.Text;
using ImageToBase64.API.Repository;

namespace ImageToBase64.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageRepository _imageRepository;

        public ImageController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        [HttpGet("")]
        public string GetImageJson()
        {
            var Base64Image = _imageRepository.GetImageIntoJSON();
            return Base64Image;
        }
    }
}
