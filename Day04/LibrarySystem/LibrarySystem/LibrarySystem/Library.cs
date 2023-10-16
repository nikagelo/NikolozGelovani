namespace LibrarySystem;
public class Library
{
    private List<Book> books = new List<Book>();

    public void PrintBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }
    }

    public int Count => books.Count;

    public void AddBook(Book book)
    {
        books.Add(book);

    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public List<Book> FindBook(string title)
    {
        return books.Where(book => book.Title == title).ToList();
    }
}
