using System;
using System.Collections.Generic;
using Lab07_LendingLibrary.Classes;

namespace Lab07_LendingLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Phil's Lending Library!");
            Console.WriteLine("");

            Borrow();
            Console.WriteLine("");
        }

        /// <summary>
        /// Outputs to the console all books in library and distributes books to other standard generic lists
        /// </summary>
        public static void Borrow()
        {
            // Instantiate custom generic collection
            Library<Book> library = new Library<Book>
            {
                new Book {
                    Title = "C# 7.0 in a Nutshell",
                    Author = new Author("Joseph", "Albahari"),
                    Genre = Book.Genres.Programming
                },
                new Book {
                    Title = "Think Python",
                    Author = new Author("Allen", "Downey"),
                    Genre = Book.Genres.Programming
                },
                new Book {
                    Title = "The Lord of the Rings",
                    Author = new Author("J.R.R", "Tolkien"),
                    Genre = Book.Genres.Fiction
                },
                new Book {
                    Title = "Farmer Giles of Ham",
                    Author = new Author("J.R.R", "Tolkien"),
                    Genre = Book.Genres.Fiction
                },
                new Book {
                    Title = "Roverandom",
                    Author = new Author("J.R.R", "Tolkien"),
                    Genre = Book.Genres.Fiction
                },
                new Book {
                    Title = "Leaf by Niggle",
                    Author = new Author("J.R.R", "Tolkien"),
                    Genre = Book.Genres.Fiction
                },
                new Book {
                    Title = "Moby Dick",
                    Author = new Author("Daniel", "Defoe"),
                    Genre = Book.Genres.Fiction
                },
                new Book {
                    Title = "The Hobbit",
                    Author = new Author("J.R.R", "Tolkien"),
                    Genre = Book.Genres.Fiction
                },
                new Book {
                    Title = "The Book of Lost Tales",
                    Author = new Author("J.R.R", "Tolkien"),
                    Genre = Book.Genres.History
                },
                new Book {
                    Title = "The Adventures of Tom Bombadil",
                    Author = new Author("J.R.R", "Tolkien"),
                    Genre = Book.Genres.Fiction
                },
            };

            Console.WriteLine($"Count of books in library: {library.Count()}\n");

            Book bookToAdd = new Book { Title = "My New Book", Author = new Author("Anony", "Mous"), Genre = Book.Genres.History };
            library.Add(bookToAdd);

            Console.WriteLine($"Count of books in library: {library.Count()}\n");

            //library.Remove(bookToAdd);

            foreach (Book book in library)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author.FirstName} {book.Author.LastName}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine("");
            }


            //////////////////////////////////////////////////
            // Distribute books to two different generic lists
            //////////////////////////////////////////////////
            List<Book> fictionBooks = new List<Book>();
            List<Book> nonFictionBooks = new List<Book>();

            foreach (Book book in library)
            {
                if (book.Genre == Book.Genres.Fiction)
                {
                    fictionBooks.Add(book);
                }
                else
                {
                    nonFictionBooks.Add(book);
                }
            }

            Console.WriteLine("/////////////////////////////////////\n");
            Console.WriteLine($"Here are the books in fictionBooks");
            Console.WriteLine("");

            foreach (Book book in fictionBooks)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author.FirstName} {book.Author.LastName}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine("");
            }

            Console.WriteLine("/////////////////////////////////////\n");
            Console.WriteLine($"Here are the books in nonFictionBooks");
            Console.WriteLine("");

            foreach (Book book in nonFictionBooks)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author.FirstName} {book.Author.LastName}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine("");
            }


        }
    }
}
