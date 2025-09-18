using Microsoft.AspNetCore.Http;

namespace NetTemplate.DAL.Data.Requests.Media
{
    public class UploadFileRequest
    {
        public IFormFile File { get; set; }
    }
}
