namespace API_Kirish.BL.Services;

public interface IFileService
{
    string UploadImage(IFormFile file);
    void DeleteImage(string fileName);
}
