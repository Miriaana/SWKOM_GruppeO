namespace PaperlessRestAPI.OCRWorker;

public interface IOcrClient
{
    string OcrPdf(Stream pdfStream);
}
