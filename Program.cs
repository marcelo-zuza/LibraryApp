using LibraryApp.Controllers;
using LibraryApp.Models;

class Program
{
    static void Main(string[] args)
    {
        BookController bookController = new BookController();

        var newBook = new Book
        {
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            Category = "Novel",
            PublishingDate = new DateTime(2024, 2, 28),
            Avaliable = true
        };

        var books = bookController.GetAllBooks();
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Category: {book.Category}, Publishing Date: {book.PublishingDate}, Avaliable: {book.Avaliable}");
        }
    }
}