using PaperlessRestAPI.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.BusinessLogic.Interfaces.Components
{
    public interface IDocumentCRUDLogic
    {
        public void CreateDocument(DocumentRepo documentRepo);
        public void DeleteDocument();
        public void UpdateDocument();
    }
}
