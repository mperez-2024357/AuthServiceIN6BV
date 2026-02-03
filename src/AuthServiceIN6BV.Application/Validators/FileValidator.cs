using AuthServiceIN6BV.Application.Interfaces;
namespace AuthServiceIN6BV.Application.Validators;
public static class FileValidator
{
    private static readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
    private const int MaxFileSizeInBytes = 5 * 1024 * 1024; // 5 MB
    public static(bool IsValid, string? ErrorMessage) ValidateFile(IFileData file)
    {
       if (file == null|| file.Size == 0)
       {
        return (false, "File is Required.");
       }
       if (file.Size > MaxFileSizeInBytes)
       {
        return (false, $"File size cannot exceeds {MaxFileSizeInBytes/(1024*1024)} MB.");
       }
       var extension = Path.GetExtension(file.FileName).ToLowerInvariant();

        if (!AllowedImageExtension.Contains(extension))
        {
            return (false, $"Only the following file type are allowed: {string.Join(", ", AllowedImageExtension)}");
        }

        var allowdContentTypes = new[] { "image/jpeg", "image/png", "image/gif", "image/jpg" ,"image/webp" };
        if (!allowdContentTypes.Contains(file.ContentType.ToLowerInvariant()))
        {
            return(false ," Invalid file content type.");
        }
        return (true, null);
    }
    public static string GenerateSecureFileName(string originalFileName)
    {
        var extension = Path.GetExtension(originalFileName).ToLowerInvariant();
        var UniqueId = Guid.NewGuid().ToString("N")[..12];
        return $"profile-{UniqueId}{extension}";
    }
}