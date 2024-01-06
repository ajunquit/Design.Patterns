using Adapter.Book.Targets;

namespace Adapter.Book.Adapters;

public class BookAdapter(Adapter.Book.Adaptees.Book book) : IBookInfo
{
    
    private readonly Adapter.Book.Adaptees.Book book = book;

    public string GetTitle()
    {
        return book.Title;
    }

    public string GetAuthor()
    {
        return book.Author;
    }

    public int GetPublishedYear()
    {
        return book.PublishedYear;
    }
}
