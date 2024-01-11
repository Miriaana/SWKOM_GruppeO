using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elastic.Clients.Elasticsearch.Ingest;
using NPaperless.SearchLibrary;
using PaperlessRestAPI.BusinessLogic.Interfaces.Components;
using Document = NPaperless.SearchLibrary.Document;

namespace PaperlessRestAPI.BusinessLogic
{
    public class SearchDocumentLogic : ISearchDocumentLogic
    {
        private ISearchIndex _search = new ElasticSearchIndex(null, null);

        public List<string> searchDocuments(string Searchterm)
        {
            List<string> results = new();

           IEnumerable<Document> resultsdocs =  _search.SearchDocumentAsync(Searchterm);

            if(resultsdocs.Count() == 0)
            {
                return results;
            }

            foreach (Document document in resultsdocs)
            {
                results.Add(document.Title);
            }

            return results;
        }
    }
}
