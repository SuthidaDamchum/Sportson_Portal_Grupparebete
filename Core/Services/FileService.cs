using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace SportsonView.API.Core.Services
{
    public class FileService
    {
        private readonly string _connectionString;
        private readonly string _containerName = "news-images";

        public FileService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("AzureStorage");
        }

        public async Task<string> UploadFileAsync(IFormFile file)
        {
            var blobServiceClient = new BlobServiceClient(_connectionString);
            var containerClient = blobServiceClient.GetBlobContainerClient(_containerName);

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var blobClient = containerClient.GetBlobClient(fileName);

            using var stream = file.OpenReadStream();
            var blobHttpHeader = new BlobHttpHeaders { ContentType = file.ContentType };

            await blobClient.UploadAsync(stream, new BlobUploadOptions { HttpHeaders = blobHttpHeader });
            return blobClient.Uri.ToString();
        }
    }
}

