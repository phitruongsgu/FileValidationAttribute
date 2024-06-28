using CustomArttribute.Utility;

namespace FileValidationAttribute.Entities
{
    public class Image
    {
        [MaxFileSize(1)]
        [FileExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        public IFormFile? File { get; set; }
    }
}
