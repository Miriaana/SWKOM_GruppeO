using PaperlessRestAPI.BusinessLogic.Entities;
using PaperlessRestAPI.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document = PaperlessRestAPI.BusinessLogic.Entities.Document;

namespace PaperlessRestAPI.DataAccess.Interfaces
{
    public interface IDocumentRepository
    {
        public Document GetDocument(int id);

        public IEnumerable<Document> GetAllDocuments();

        public bool DeleteDocument(int id);

        public bool CreateDocument(Document document);

        public bool UpdateDocument(Document document);

    }
}
