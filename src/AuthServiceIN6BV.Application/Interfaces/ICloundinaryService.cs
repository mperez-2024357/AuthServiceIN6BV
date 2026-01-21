namespace AuthServiceIN6BV.Application.Interface;
public interface ICloundinaryService
{
    Task<string> uploadImageAsync(IFileData imagenFile,string fileName);
    Task<bool> DeleteImageAsync (string publicId);
    string GetDefaultAvatarUrl();
    string GetFullImageUrl(string imagePath);
}