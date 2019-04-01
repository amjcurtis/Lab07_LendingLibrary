using System;
using Lab07_LendingLibrary.Classes;
using Xunit;

namespace XUnitTest_LendingLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddBookToExistingLibrary()
        {
            // Arrange
            Library<Book> library = new Library<Book>();
            Book bookToAdd = new Book { Title = "C# 7.0 in a Nutshell", Author = new Author("Joseph", "Albahari"), Genre = Book.Genres.Programming };

            // Act
            library.Add(bookToAdd);

            // Assert
            Assert.NotEmpty(library);
        }

        [Fact]
        public void CanRemoveBookFromExistingLibrary()
        {
            // Arrange
            Library<Book> library = new Library<Book>();

            Book bookToRemove = new Book
            {
                Title = "C# 7.0 in a Nutshell",
                Author = new Author("Joseph", "Albahari"),
                Genre = Book.Genres.Programming
            };
            library.Add(bookToRemove);
            
            // Act
            library.Remove(bookToRemove);

            // Assert
            Assert.Empty(library);
        }

        //[Fact]
        public void CanGetTitle()
        {
            // Arrange
            Book book = new Book();

            // Assert
            Assert.Equal("Code", book.Title);
        }

        [Fact]
        public void CanSetTitle()
        {
            // Arrange
            Book book = new Book();

            // Act
            book.Title = "Code";

            // Assert
            Assert.Equal("Code", book.Title);
        }

        //[Fact]
        public void CanGetAuthor()
        {
            // Arrange
            Book book = new Book();

            // Assert
            Assert.Equal("Charles", book.Author.FirstName);
        }

        [Fact]
        public void CanAccuratelyCountBooksInLibrary()
        {
            // Arrange
            Library<Book> library = new Library<Book>();
            Book bookToAdd = new Book { Title = "C# 7.0 in a Nutshell", Author = new Author("Joseph", "Albahari"), Genre = Book.Genres.Programming };

            // Act
            library.Add(bookToAdd);

            // Assert
            Assert.Equal(1, library.Count());
        }

        [Fact]
        public void DoesNotRemoveBookFromExistingLibraryIfNoBooksInLibrary()
        {
            // Arrange
            Library<Book> library = new Library<Book>();

            Book bookToRemove1 = new Book { Title = "C# 7.0 in a Nutshell", Author = new Author("Joseph", "Albahari"), Genre = Book.Genres.Programming };

            library.Remove(bookToRemove1);

            Book bookToRemove2 = new Book { Title = "Think Python", Author = new Author("Allen", "Downey"), Genre = Book.Genres.Programming };
            
            // Act
            library.Remove(bookToRemove2);

            // Assert
            Assert.Equal(0, library.Count());
        }
    }
}
