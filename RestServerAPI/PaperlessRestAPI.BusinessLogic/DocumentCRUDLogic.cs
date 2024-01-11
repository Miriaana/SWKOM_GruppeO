using PaperlessRestAPI.BusinessLogic.Entities;
using PaperlessRestAPI.BusinessLogic.Interfaces;
using PaperlessRestAPI.BusinessLogic.Interfaces.Components;
using PaperlessRestAPI.DataAccess.Interfaces;
using PaperlessRestAPI.RabbitMQ;

namespace PaperlessRestAPI.BusinessLogic
{
    public class DocumentCRUDLogic : IDocumentCRUDLogic
    {
        IFileStorage _minio;
        private readonly IDocumentRepository _documentrepository;
        RabbitMQHandler _rabbitmq;


        public DocumentCRUDLogic(RabbitMQHandler rabbitmq, IFileStorage minio, IDocumentRepository documentRepository) {

            this._rabbitmq = rabbitmq;
            this._minio = minio;
            this._documentrepository = documentRepository;
        }

        public async void CreateDocument(Document documentRepo)
        {
        
            if(!_minio.FileExistsAsync(documentRepo.Original_File_Name).Result)
            {

               await _minio.UploadFileAsync(new MemoryStream(documentRepo.Data), documentRepo.Original_File_Name);

                _rabbitmq.send(documentRepo.Original_File_Name, documentRepo.Id);

                _documentrepository.CreateDocument(documentRepo);
            }
           
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