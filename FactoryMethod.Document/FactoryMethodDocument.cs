using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Document;

// product
public interface IDocument
{
    void Open();
    void Close();
}

// concrete product - pdf document
public class PdfDocument : IDocument
{
    public void Close()
    {
        Console.WriteLine("Saving PDF document.");
    }

    public void Open()
    {
        Console.WriteLine("Opening PDF document.");
    }
}

// concrete product - word document
public class WordDocument : IDocument
{
    public void Close()
    {
        Console.WriteLine("Saving Word document.");
    }

    public void Open()
    {
        Console.WriteLine("Opening Word document.");
    }
}

// creator interface
public interface IDocumentConverter
{
    IDocument CreateDocument();
}

// concrete creator for pdf documents

public class PdfDocumentConverter : IDocumentConverter
{
    public IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

// concrete creator for word documents 
public class WordDocumentConverter : IDocumentConverter
{
    public IDocument CreateDocument()
    {
        return new WordDocument();
    }
}
