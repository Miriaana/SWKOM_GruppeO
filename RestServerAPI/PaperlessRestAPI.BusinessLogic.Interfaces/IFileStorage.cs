using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.BusinessLogic.Interfaces
{
    public interface IFileStorage
    {
        Task UploadFileAsync(Stream fileStream, string filePath);

        Task<Stream> GetFileAsync(string filePath);

        Task DeleteFileAsync(string filePath);

        Task<bool> FileExistsAsync(string filePath);
    }
}
