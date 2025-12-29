using Microsoft.AspNetCore.Http;

public class UploadImageDto
{
    public IFormFile File { get; set; } = null!;
}
