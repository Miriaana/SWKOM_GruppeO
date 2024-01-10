using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Minio;
using Minio.DataModel.Args;
using PaperlessRestAPI.BusinessLogic.Interfaces;

namespace PaperlessRestAPI.BusinessLogic
{
    public class MinioFileStorage : IFileStorage
    {
        private readonly IMinioClient _minioClient;
        private readonly string _bucketName;

        public MinioFileStorage(string endpoint, string accessKey, string secretKey, string bucketName)
        {
            // Initialize the MinIO client with the provided credentials and bucket.
            _minioClient = new MinioClient().WithEndpoint(endpoint).WithCredentials(accessKey, secretKey).Build();
            _bucketName = bucketName;
        }

        public MinioFileStorage(IMinioClient minioClient, string bucketName)
        {
            _minioClient = minioClient;
            _bucketName = bucketName;
        }

        public async Task UploadFileAsync(Stream fileStream, string filePath)
        {
            var putObjectArgs = new PutObjectArgs()
                .WithBucket(_bucketName)
                .WithStreamData(fileStream)
                .WithObject(filePath)
                .WithObjectSize(fileStream.Length);

            await _minioClient.PutObjectAsync(putObjectArgs);
        }

        public async Task<Stream> GetFileAsync(string filePath)
        {
            var memoryStream = new MemoryStream();
            var getObjectArgs = new GetObjectArgs().WithBucket(_bucketName).WithObject(filePath)
                .WithCallbackStream((stream) => stream.CopyTo(memoryStream));
            await _minioClient.GetObjectAsync(getObjectArgs);

            memoryStream.Position = 0;
            return memoryStream;
        }

        public async Task DeleteFileAsync(string filePath)
        {
            var removeObjectArgs = new RemoveObjectArgs().WithBucket(_bucketName).WithObject(filePath);
            await _minioClient.RemoveObjectAsync(removeObjectArgs);
        }

        //ToDo: Fix Method (Output -> Error Messages in Extra Header and returns true on failure)
        public async Task<bool> FileExistsAsync(string filePath)
        {
            var statObjectArgs = new StatObjectArgs().WithBucket(_bucketName).WithObject(filePath);
            var result = await _minioClient.StatObjectAsync(statObjectArgs);

            return result != null;
        }
    }
}
public class MinIOOptions
{
    public string Endpoint { get; set; }
    public string AccessKey { get; set; }
    public string SecretKey { get; set; }
    public string BucketName { get; set; }
}
