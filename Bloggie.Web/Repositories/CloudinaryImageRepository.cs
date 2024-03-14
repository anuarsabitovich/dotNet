
using CloudinaryDotNet;

namespace Bloggie.Web.Repositories
{
    public class CloudinaryImageRepository : IImageRepository
    {
        private readonly IConfiguration configuration;
        private readonly Account account;

        public CloudinaryImageRepository(IConfiguration configuration )
        {
            this.configuration = configuration;
        }

        Task<string> IImageRepository.UploadAsync(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
