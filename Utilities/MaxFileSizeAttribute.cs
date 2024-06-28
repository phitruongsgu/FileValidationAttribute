using System.ComponentModel.DataAnnotations;

namespace CustomArttribute.Utility
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {

                if (file.Length > (1000000 * _maxFileSize)) // 1 Megabyte bằng 1.000.000 byte
                {
                    return new ValidationResult($"Kích thước tệp tối đa được phép là {_maxFileSize} MB.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
