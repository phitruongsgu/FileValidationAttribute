using FileValidationAttribute.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FileValidationAttribute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> PostFile([FromForm] Image image)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
