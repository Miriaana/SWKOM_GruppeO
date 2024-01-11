using PaperlessRestAPI.DataAccess.Entities;
using PaperlessRestAPI.DataAccess.Interfaces;
using Document = PaperlessRestAPI.BusinessLogic.Entities.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PaperlessRestAPI.DataAccess.Sql
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly PaperlessDbContextFactory dbContextFactory;
        public DocumentRepository(PaperlessDbContextFactory dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;

            
        }

        public bool CreateDocument(Document document)
        {
           using PaperlessDbContext dbContext = dbContextFactory.Create();

            dbContext.Database.EnsureCreated();

            dbContext.Documents.Add(document);

            int delta = dbContext.SaveChanges();

            if (delta > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteDocument(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> GetAllDocuments()
        {
            throw new NotImplementedException();
        }

        public Document GetDocument(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDocument(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
