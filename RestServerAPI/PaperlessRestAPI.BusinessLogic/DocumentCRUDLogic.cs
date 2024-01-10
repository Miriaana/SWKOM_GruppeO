using PaperlessRestAPI.BusinessLogic.Entities;
using PaperlessRestAPI.BusinessLogic.Interfaces;
using PaperlessRestAPI.BusinessLogic.Interfaces.Components;
using PaperlessRestAPI.RabbitMQ;

namespace PaperlessRestAPI.BusinessLogic
{
    public class DocumentCRUDLogic : IDocumentCRUDLogic
    {
        IFileStorage _minio;
        RabbitMQHandler _rabbitmq;


        public DocumentCRUDLogic(RabbitMQHandler rabbitmq, IFileStorage minio) {

            this._rabbitmq = rabbitmq;
            this._minio = minio;
        }

        public void CreateDocument(DocumentRepo documentRepo)
        {
            //throw new NotImplementedException();

            //Console.WriteLine(documentRepo);

            _minio.UploadFileAsync(new MemoryStream(documentRepo.Data), documentRepo.Original_File_Name);

            _rabbitmq.send(documentRepo.Original_File_Name, documentRepo.Id);

        }

        public void DeleteDocument()
        {
            throw new NotImplementedException();
        }

        public void UpdateDocument()
        {
            throw new NotImplementedException();
        }
    }
}