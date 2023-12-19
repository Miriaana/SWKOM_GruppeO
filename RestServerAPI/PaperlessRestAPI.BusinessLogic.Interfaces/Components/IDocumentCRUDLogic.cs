using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.BusinessLogic.Interfaces.Components
{
    public interface IDocumentCRUDLogic
    {
        public void CreateDocument();
        public void DeleteDocument();
        public void UpdateDocument();
    }
}
