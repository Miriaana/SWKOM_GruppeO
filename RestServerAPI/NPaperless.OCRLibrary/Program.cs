// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;
using NPaperless.SearchLibrary;
using PaperlessRestAPI.BusinessLogic;
using PaperlessRestAPI.BusinessLogic.Interfaces;
using PaperlessRestAPI.logging;
using PaperlessRestAPI.OCRWorker;
using PaperlessRestAPI.RabbitMQ;
using System.Net.Sockets;

/*Console.WriteLine("OCR with Tesseract Demo!");

string filePath = "C:/Users/Kretz/Documents/GitHub/SWKOM_GruppeO/RestServerAPI/NPaperless.OCRLibrary/docs/TourPlanner_Specification.pdf";
string test = "";
IFileStorage _minio;
RabbitMQHandler _rabbitmq;
// string filePath = "./docs/HelloWorld.pdf";

try
{

    using Stream fileStream = _minio.GetFileAsync(test).Result;

    using FileStream fileStream = new FileStream(filePath, FileMode.Open);
    using StreamReader reader = new StreamReader(fileStream);
    OcrClient ocrClient = new OcrClient(new OcrOptions());

    var ocrContentText = ocrClient.OcrPdf(fileStream);
    Console.WriteLine( ocrContentText );
}
catch (IOException e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}*/

namespace PaperlessRestAPI.OCRWorker
{
    class Programm
    {
        static void Main()
        {
            string workingDirectory = Environment.CurrentDirectory;

            IConfiguration config = new ConfigurationBuilder()
           .SetBasePath(Directory.GetParent(workingDirectory).Parent.Parent.FullName)
           .AddJsonFile("OCRWorkerSettings.json")
           .Build();

            var queueOptions = config.GetSection("RabbitMQ").Get<RabbitMQOptions>();
            var fileStorageOptions = config.GetSection("MinIO").Get<MinIOOptions>();
      
            OCRProgram client = new OCRProgram(
               new MinioFileStorage(
                       fileStorageOptions.Endpoint,
                       fileStorageOptions.AccessKey,
                       fileStorageOptions.SecretKey,
                       fileStorageOptions.BucketName
                       ),
               new RabbitMQHandler(
                       queueOptions.Hostname,
                       queueOptions.Username,
                       queueOptions.Password,
                       queueOptions.Port,
                       queueOptions.queueName
                   ),
                queueOptions.queueName,
                   new OcrClient(new OcrOptions()),
                   new ElasticSearchIndex(null, LoggerFactory.GetLogger()),
                   LoggerFactory.GetLogger()
               );

            while (true)
            {
                client.testocr();
            }
                
        }
    }

}