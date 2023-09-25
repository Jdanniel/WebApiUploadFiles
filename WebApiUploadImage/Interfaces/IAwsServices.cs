using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using WebApiUpload.Wrappers;

namespace WebApiUpload.Interfaces
{
    public interface IAwsServices
    {
        Task<Wrapper> Delete(string FileName);
        Task<Wrapper> Upload(IFormFile formFile, string FileName);
    }
}
