using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Assignment
{
    public class Library
    {
        private List<Book> books;

        // Constructor
        public Library()
        {
            books = new List<Book>();
        }

        // Method to add a new book record to the list
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully!");
        }

        // Method to view all book records in the list
        public void ViewAllBooks()
        {
            Console.WriteLine("All Books in the Library:");

            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }

        // Method to search for a book record by ID and display details
        public void SearchBookById(int bookId)
        {
            Book foundBook = books.Find(book => book.BookId == bookId);

            if (foundBook != null)
            {
                DisplayBookDetails(foundBook);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        // Method to search for a book record by title and display details
        public void SearchBookByTitle(string title)
        {
            Book foundBook = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (foundBook != null)
            {
                DisplayBookDetails(foundBook);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        // Helper method to display book details
        private void DisplayBookDetails(Book book)
        {
            Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
        }
    }
}
