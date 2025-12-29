namespace BusinessLogic.Interfaces
{
    public interface IImageService
    {
        Task<string?> UploadAsync(
            Stream stream,
            string fileName
        );
    }
}
