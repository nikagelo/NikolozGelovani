using LibrarySystem;

public class Program
{
   public static void Main(string[] args)
    {
        Library library = new Library();

        library.AddBook(new Book("Sherlock Holmes", "Sir Arthur Ignatius Conan Doyle", 1887));
        library.AddBook(new Book("1984", "George Orwell", 1949));
        library.AddBook(new Book("The Catcher in the Rye", "Jerome David Salinger", 1951));

      
        Console.WriteLine("Books in the library:");
        library.PrintBooks();

        Console.WriteLine("Number of books in the library:" +library.Count);

        string searchTitle = "1984";
        var foundBooks = library.FindBook(searchTitle);
        Console.WriteLine("Books with the title "+searchTitle);
        foreach (var book in foundBooks)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }

        library.RemoveBook(foundBooks[0]);

        Console.WriteLine("Books in the library after removal:");
        library.PrintBooks();
    }
}
