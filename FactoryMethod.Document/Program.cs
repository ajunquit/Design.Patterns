
using FactoryMethod.Document;
// Using PdfDocumentConverter to create and manipulate PDF document
IDocumentConverter pdfConverter = new PdfDocumentConverter();
IDocument pdfDocument = pdfConverter.CreateDocument();
pdfDocument.Open();
pdfDocument.Close();

// Using WordDocumentConverter to create and manipulate Word document
IDocumentConverter wordConverter = new WordDocumentConverter();
IDocument wordDocument = wordConverter.CreateDocument();
wordDocument.Open();
wordDocument.Close();
    