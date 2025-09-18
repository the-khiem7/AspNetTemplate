﻿using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace NetTemplate.BLL.Services.Interfaces
{
    public interface ICloudinaryService
    {
        Task<string> UploadImageAsync(IFormFile file, ClaimsPrincipal user);
        Task<string> UploadFileAsync(IFormFile file, ClaimsPrincipal user);
    }
}
