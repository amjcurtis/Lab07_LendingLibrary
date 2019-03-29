using System;
using Lab07_LendingLibrary.Classes;

namespace Lab07_LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate custom generic collection
            Library<Book> library = new Library<Book>
            {
                new Book { Title = "C# 7.0 in a Nutshell", Author = new Author("Joseph", "Albahari"), Genre = Book.Genres.Programming },
                new Book { Title = "Think Python", Author = new Author("Allen", "Downey"), Genre = Book.Genres.Programming },
                new Book { Title = "The Lord of the Rings", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction },
                new Book { Title = "Farmer Giles of Ham", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction },
                new Book { Title = "Roverandom", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction },
                new Book { Title = "Leaf by Niggle", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction },
                new Book { Title = "Moby Dick", Author = new Author("Daniel", "Defoe"), Genre = Book.Genres.Fiction },
                new Book { Title = "The Hobbit", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction },
                new Book { Title = "Tales from the Perilous Realm", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction },
                new Book { Title = "The Adventures of Tom Bombadil", Author = new Author("J.R.R", "Tolkien"), Genre = Book.Genres.Fiction },
            };

            foreach (Book book in library)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author.FirstName} {book.Author.LastName}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine("");
            }
        }





    }
}
