using LibrarySystem;

public class Program
{
    public static void Main()
    {
        // Create a Library instance
        Library library = new Library();

        // Add some books
        library.AddBook(new Book("Sherlock Holmes", "Sir Arthur Ignatius Conan Doyle", 1887));
        library.AddBook(new Book("1984", "George Orwell", 1949));
        library.AddBook(new Book("The Catcher in the Rye", "Jerome David Salinger", 1951)); // Same title as Book1

        // Print the books in the library
        Console.WriteLine("Books in the library:");
        library.PrintBooks();

        // Count the number of books in the library
        Console.WriteLine($"Number of books in the library: {library.Count}");

        // Find books by title
        string searchTitle = "1984";
        var foundBooks = library.FindBook(searchTitle);
        Console.WriteLine($"Books with the title '{searchTitle}':");
        foreach (var book in foundBooks)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }

        // Remove a book
        library.RemoveBook(foundBooks[0]);

        // Print the updated list of books
        Console.WriteLine("Books in the library after removal:");
        library.PrintBooks();
    }
}
