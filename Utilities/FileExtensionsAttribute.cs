using System.ComponentModel.DataAnnotations;

namespace CustomArttribute.Utility
{
    public class FileExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;
        public FileExtensionsAttribute(string[] extensions)
        {
            _extensions = extensions;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!_extensions.Contains(extension.ToLower())) // nếu extension của file không hợp lệ
                {
                    return new ValidationResult($"Phần mở rộng ảnh này không được phép!");
                }
            }
            return ValidationResult.Success;
        }

    }
}
