namespace NPaperless.SearchLibrary;

public interface ISearchIndex
{
    void AddDocumentAsync(Document doc);
    IEnumerable<Document> SearchDocumentAsync(string searchTerm);
}


