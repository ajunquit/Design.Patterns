namespace Adapter.Book.Adaptees;

public class Book(string title, string author, int publishedYear)
{
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
    public int PublishedYear { get; set; } = publishedYear;
}
