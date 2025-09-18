using Microsoft.AspNetCore.Http;

namespace NetTemplate.DAL.Data.Requests.Media
{
    public class UploadImageRequest
    {
        public IFormFile File { get; set; }
    }
}
