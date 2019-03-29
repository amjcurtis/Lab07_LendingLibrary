﻿using System;
using System.Collections.Generic;
using Lab07_LendingLibrary.Classes;

namespace Lab07_LendingLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO PHIL'S LENDING LIBRARY!");
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

            // Print count of books currently in library
            Console.WriteLine($"Count of books in library: {library.Count()}\n");


            //////////////////////////////////////////////////
            // Add new book to library
            //////////////////////////////////////////////////

            Book bookToAdd = new Book { Title = "Cracking the Coding Interview", Author = new Author("Gayle", "Laakmann McDowell"), Genre = Book.Genres.Programming };
            library.Add(bookToAdd);
            Console.WriteLine("Phil returned a book to the library:\n");
            Console.WriteLine($"Title: {bookToAdd.Title}");
            Console.WriteLine($"Author: {bookToAdd.Author.FirstName} {bookToAdd.Author.LastName}");
            Console.WriteLine($"Genre: {bookToAdd.Genre}\n");

            Console.WriteLine($"Count of books in library: {library.Count()}\n");


            //////////////////////////////////////////////////
            // Remove book from library
            //////////////////////////////////////////////////

            //library.Remove(bookToAdd);
            Console.WriteLine("");
            Console.WriteLine("Phil checked out this book from the library:");
            Console.WriteLine($"Title: {bookToAdd.Title}\n");

            Console.WriteLine($"Count of books in library: {library.Count()}\n");
            Console.WriteLine("");


            //////////////////////////////////////////////////
            // Print all books in library
            //////////////////////////////////////////////////

            Console.WriteLine("/////////////////////////////////////\n");
            Console.WriteLine("Here are ALL the books in the library!\n");

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

            Console.WriteLine("");
            Console.WriteLine("/////////////////////////////////////\n");
            Console.WriteLine($"Here are the books in the Fiction Section");
            Console.WriteLine("");

            foreach (Book book in fictionBooks)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author.FirstName} {book.Author.LastName}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("/////////////////////////////////////\n");
            Console.WriteLine($"Here are the books in the Non-Fiction Section");
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
