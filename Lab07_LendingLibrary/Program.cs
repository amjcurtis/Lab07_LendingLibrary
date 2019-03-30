using System;
using System.Collections.Generic;
using Lab07_LendingLibrary.Classes;

namespace Lab07_LendingLibrary
{
    public class Program
    {
        /// <summary>
        /// Prints welcome message and calls Borrow method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO PHIL'S LENDING LIBRARY!\n");

            Borrow();
        }

        /// <summary>
        /// Outputs to the console all books in library and distributes books to other standard generic lists
        /// </summary>
        public static void Borrow()
        {
            // Instantiate custom generic collection
            Library<Book> library = new Library<Book>();

            // Print count of books currently in library
            Console.WriteLine($"Count of books in library: {library.Count()}\n");


            //////////////////////////////////////////////////
            // Add new book to library
            //////////////////////////////////////////////////

            // Instantiate new books and store in variables
            Book bookToAdd1 = new Book { Title = "C# 7.0 in a Nutshell", Author = new Author("Joseph", "Albahari"), Genre = Book.Genres.Programming };
            Book bookToAdd2 = new Book { Title = "Think Python", Author = new Author("Allen", "Downey"), Genre = Book.Genres.Programming };
            Book bookToAdd3 = new Book { Title = "Farmer Giles of Ham", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction };
            Book bookToAdd4 = new Book { Title = "The Lord of the Rings", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction };
            Book bookToAdd5 = new Book { Title = "Roverandom", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction };
            Book bookToAdd6 = new Book { Title = "Leaf by Niggle", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction };
            Book bookToAdd7 = new Book { Title = "Moby Dick", Author = new Author("Daniel", "Defoe"), Genre = Book.Genres.Fiction };
            Book bookToAdd8 = new Book { Title = "The Hobbit", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction };
            Book bookToAdd9 = new Book { Title = "The Book of Lost Tales", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.History };
            Book bookToAdd10 = new Book { Title = "The Adventures of Tom Bombadil", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction };
            Book bookToAdd11 = new Book { Title = "Design Patters", Author = new Author("Erich", "Gamma"), Genre = Book.Genres.Programming };
            Book bookToAdd12 = new Book { Title = "Cracking the Coding Interview", Author = new Author("Gayle", "Laakmann McDowell"), Genre = Book.Genres.Programming };
            Book bookToAdd13 = new Book { Title = "Team of Teams", Author = new Author("Stanley", "McCrystal"), Genre = Book.Genres.History };
            Book bookToAdd14 = new Book { Title = "The Imposter's Handbook", Author = new Author("Rob", "Conery"), Genre = Book.Genres.Programming };
            Book bookToAdd15 = new Book { Title = "The Imposter's Handbook: Season 2", Author = new Author("Rob", "Conery"), Genre = Book.Genres.Programming };
            Book bookToAdd16 = new Book { Title = "Code", Author = new Author("Charles", "Petzold"), Genre = Book.Genres.Programming };

            // Add a book to library collection
            library.Add(bookToAdd1);

            Console.WriteLine("This book has been returned to the library:\n");
            Console.WriteLine($"Title: {bookToAdd1.Title}");
            Console.WriteLine($"Author: {bookToAdd1.Author.FirstName} {bookToAdd1.Author.LastName}");
            Console.WriteLine($"Genre: {bookToAdd1.Genre}\n");

            // Add more books to library
            library.Add(bookToAdd2);
            library.Add(bookToAdd3);
            library.Add(bookToAdd4);
            library.Add(bookToAdd5);
            library.Add(bookToAdd6);
            library.Add(bookToAdd7);
            library.Add(bookToAdd8);
            library.Add(bookToAdd9);
            library.Add(bookToAdd10);
            library.Add(bookToAdd11);
            library.Add(bookToAdd12);
            library.Add(bookToAdd13);
            library.Add(bookToAdd14);
            library.Add(bookToAdd15);
            library.Add(bookToAdd16);
            

            //////////////////////////////////////////////////
            // Remove book from library
            //////////////////////////////////////////////////

            // Remove a book from library
            library.Remove(bookToAdd1);

            Console.WriteLine("This book has been checked out from the library:");
            Console.WriteLine(bookToAdd1.Title);
            Console.WriteLine($"Author: {bookToAdd1.Author.FirstName} {bookToAdd1.Author.LastName}");
            Console.WriteLine($"Genre: {bookToAdd1.Genre}\n"); 
            
            // Remove more books from library
            library.Remove(bookToAdd11);
            library.Remove(bookToAdd12);
            library.Remove(bookToAdd13);
            

            //////////////////////////////////////////////////
            // Print all books in library
            //////////////////////////////////////////////////

            Console.WriteLine("/////////////////////////////////////\n");
            Console.WriteLine("Here are ALL the books in the library!\n");

            foreach (Book book in library)
            {
                if (book != null)
                {
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Author: {book.Author.FirstName} {book.Author.LastName}");
                    Console.WriteLine($"Genre: {book.Genre}\n");
                }
            }


            //////////////////////////////////////////////////
            // Distribute books to two different generic lists
            //////////////////////////////////////////////////

            // Initialize new lists
            List<Book> fictionBooks = new List<Book>();
            List<Book> nonFictionBooks = new List<Book>();

            // Sort books into fiction and non-fiction lists
            foreach (Book book in library)
            {
                if (book != null)
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
            }

            // Print list of fiction books to console
            Console.WriteLine("");
            Console.WriteLine("/////////////////////////////////////\n");
            Console.WriteLine($"Here are the books in the Fiction Section\n");

            foreach (Book book in fictionBooks)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author.FirstName} {book.Author.LastName}");
                Console.WriteLine($"Genre: {book.Genre}\n");
            }

            // Print list of non-fiction books to console
            Console.WriteLine("");
            Console.WriteLine("/////////////////////////////////////\n");
            Console.WriteLine($"Here are the books in the Non-Fiction Section\n");

            foreach (Book book in nonFictionBooks)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author.FirstName} {book.Author.LastName}");
                Console.WriteLine($"Genre: {book.Genre}\n");
            }
        }
    }
}
