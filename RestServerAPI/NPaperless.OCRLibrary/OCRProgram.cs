using Minio.DataModel;
using NPaperless.SearchLibrary;
using PaperlessRestAPI.BusinessLogic.Interfaces;
using PaperlessRestAPI.RabbitMQ;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.OCRWorker
{
    public class OCRProgram
    {
        private IFileStorage _fileStorage;
        private RabbitMQHandler _rabbitmq;
        private IOcrClient _ocrWorker;
        private readonly string _queue;
        private ISearchIndex _search;

        public OCRProgram(IFileStorage fileStorage, RabbitMQHandler rabbitmq, string queue, IOcrClient ocrWorker , ISearchIndex search) 
        { 
            _fileStorage = fileStorage;
            _rabbitmq = rabbitmq;
            _queue = queue;
            _ocrWorker = ocrWorker;
            _search = search;
        }

        public async void testocr()
        {
          
               string path = _rabbitmq.receive();

                if (path != string.Empty)
                {
                    var Filestream = await _fileStorage.GetFileAsync(path);

                    var ocrContentText = _ocrWorker.OcrPdf(Filestream);
                    Console.WriteLine(ocrContentText);
                    
                    Document doc = new Document
                    {
                        Id = Guid.NewGuid().ToString(),
                        Title = path,
                        Content= ocrContentText
                    };


                _search.AddDocumentAsync(doc);
                }
        }
    }
}
