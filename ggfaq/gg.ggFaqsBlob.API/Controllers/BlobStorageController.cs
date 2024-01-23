using gg.ggFaqsBlob.API.Interfaces;
using gg.ggFaqsBlob.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace gg.ggFaqsBlob.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BlobStorageController : Controller
    {
        private readonly IBlobRepository _blobRepository;

        public BlobStorageController(IBlobRepository blobRepository)
        {
            _blobRepository = blobRepository;
        }

        [HttpGet("GetBlob")]
        public async Task<IActionResult> GetBlobFile(string url)
        {
            BlobObject result = await _blobRepository.GetBlobFile(url);

            return File(result.Content, result.ContentType);
        }

        [HttpPost("UploadBlob")]
        public async Task<IActionResult> UploadBlobFile([FromBody] BlobContentModel model)
        {
            var result = await _blobRepository.UploadBlobFile(model.FilePath, model.FileName);
            return Ok(result);
        }


        [HttpDelete("DeleteBlob")]
        public IActionResult DeleteBlob(string path)
        {
            _blobRepository.DeleteBlob(path);
            return Ok();
        }

        [HttpGet("ShowAllBlobs")]
        public async Task<IActionResult> ListBlobs()
        {
            var result = await _blobRepository.ListBlobs();
            return Ok(result);
        }
    }
}
