using Adapter.Book.Targets;

namespace Adapter.Book.Clients;

public class BookClient
{
    public void DisplayBookInfo(IBookInfo bookInfo)
    {
        Console.WriteLine($"Title: {bookInfo.GetTitle()}");
        Console.WriteLine($"Author: {bookInfo.GetAuthor()}");
        Console.WriteLine($"Published Year: {bookInfo.GetPublishedYear()}");
        Console.WriteLine();
    }
}
