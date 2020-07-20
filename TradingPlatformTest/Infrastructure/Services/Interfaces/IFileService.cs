using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.ViewModels;
using Microsoft.AspNetCore.Http;

namespace TradingPlatformTest.Infrastructure
{
    public interface IFileService
    {
        public string GenerateItemFileName(string fileName);

        public Task<string> UploadImageAsync(IFormFile item);
    }
}
