using Minio.DataModel;
using NPaperless.SearchLibrary;
using PaperlessRestAPI.BusinessLogic.Interfaces;
using PaperlessRestAPI.logging;
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
        private ILoggerWrapper _logger;

        public OCRProgram(IFileStorage fileStorage, RabbitMQHandler rabbitmq, string queue, IOcrClient ocrWorker , ISearchIndex search, ILoggerWrapper logger) 
        { 
            _fileStorage = fileStorage;
            _rabbitmq = rabbitmq;
            _queue = queue;
            _ocrWorker = ocrWorker;
            _search = search;
            _logger = logger;
        }

        public async void testocr()
        {
          
               string path = _rabbitmq.receive();

                if (path != string.Empty)
                {
                    _logger.Info("OCR recieved path from queue");
                    var Filestream = await _fileStorage.GetFileAsync(path);
                    _logger.Info("OCR got file from file storage");
                    var ocrContentText = _ocrWorker.OcrPdf(Filestream);
                    Console.WriteLine(ocrContentText);
                    _logger.Info("OCR created text from pdf");

                Document doc = new Document
                    {
                        Id = Guid.NewGuid().ToString(),
                        Title = path,
                        Content= ocrContentText
                    };


                _search.AddDocumentAsync(doc);
                _logger.Info("OCR added text for search");
            }
        }
    }
}
