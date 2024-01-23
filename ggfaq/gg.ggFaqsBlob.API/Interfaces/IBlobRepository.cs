using Azure.Storage.Blobs.Models;
using gg.ggFaqsBlob.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace gg.ggFaqsBlob.API.Interfaces
{
    public interface IBlobRepository
    {
        Task<BlobObject> GetBlobFile(string url);
        Task<string> UploadBlobFile(string filePath, string filename);
        void DeleteBlob(string path);
        Task<List<string>> ListBlobs();

    }
}
