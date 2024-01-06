// Client code

// Existing book information
using Adapter.Book.Adaptees;
using Adapter.Book.Adapters;
using Adapter.Book.Clients;
using Adapter.Book.Targets;

Book book = new Adapter.Book.Adaptees.Book("The Catcher in the Rye", "J.D. Salinger", 1951);

// Adapter to use Book as IBookInfo
IBookInfo adapter = new BookAdapter(book);

// Client code can now work with book information in IBookInfo format
BookClient bookClient = new BookClient();
bookClient.DisplayBookInfo(adapter);