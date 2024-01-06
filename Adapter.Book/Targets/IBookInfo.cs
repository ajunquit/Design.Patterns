namespace Adapter.Book.Targets;

public interface IBookInfo
{
    string GetTitle();
    string GetAuthor();
    int GetPublishedYear();
}
