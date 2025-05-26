using System;
using System.Collections.Generic;
using System.Linq;

namespace Slovari
{
    public class Book
    {
        public string name { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return $"ID - {id} ~ name - {name} ~ autor - {author} ~ year - {year}"; // meta
        }
    }

    public class Library
    {
        private Dictionary<int, Book> books = new Dictionary<int, Book>();
        private int nextId = 1;

        // add book
        public void addBook(string name, string author, int year)
        {
            var book = new Book
            {
                id = nextId++,
                name = name,
                author = author,
                year = year
            };
            books.Add(book.id, book);
            Console.WriteLine($"The book has been added");
        }

        // delete book
        public bool deletBook(int id)
        {
            if (books.Remove(id))
            {
                Console.WriteLine("the book was deleted");
                return true;
            }
            return false;
        }

        // search book
        public Book searchBook(int id)
        {
            if (books.TryGetValue(id, out Book book))
            {
                return book;
            }
            return null;
        }

        // output oll book
        public void outputBook()
        {
            Console.WriteLine("list of all books - ");
            foreach (var book in books.Values)
            {
                Console.WriteLine(book);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // add
            library.addBook("War and Peace", "Leo Tolstoy", 1869);
            library.addBook("Crime and punishment", "Fyodor Dostoevsky", 1866);
            library.addBook("The Master and Margarita", "Mikhail Bulgakov", 1967);

            // output
            library.outputBook();

            // search
            Book foundBook = library.searchBook(2);
            if (foundBook != null)
                Console.WriteLine($"Михаил Булгаков - {foundBook}");
            // delete
            library.deletBook(1);
            // conclusion
            library.outputBook();
        }
    }
}