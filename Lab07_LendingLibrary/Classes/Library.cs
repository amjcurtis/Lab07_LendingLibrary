using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_LendingLibrary.Classes
{

    /// <summary>
    /// Custom generic collection
    /// </summary>
    /// <typeparam name="T">Book type</typeparam>
    public class Library<T> : IEnumerable
    {
        // Create array and set initial length
        T[] books = new T[10];

        // Global variable for tracking count of books in library
        int count = 0;

        /// <summary>
        /// Adds a Book object to Library collection
        /// </summary>
        /// <param name="book">Book object</param>
        public void Add(T book)
        {
            if (count == books.Length)
            {
                Array.Resize(ref books, books.Length + (books.Length / 2));
            }

            // Updates books collection at next index
            books[count++] = book;

            Console.WriteLine($"New book added to library. Number of books in library is now {count}.");
            Console.WriteLine($"Length of books array is now {books.Length}.\n");
        }

        /// <summary>
        /// Removes a Book object from Library collection
        /// </summary>
        /// <param name="bookToRemove">Book object</param>
        public void Remove(T bookToRemove)
        {
            if (count > 0)
            {
                // Initialize temp array with same length as books array
                T[] temp = new T[books.Length];

                // Set threshold for reducing length of temp array
                if (count < books.Length / 2)
                {
                    Array.Resize(ref books, books.Length / 2);
                }
                
                // Used below for setting index in temp array
                int loopCounter = 0;

                // Load temp array with items that don't need to be removed
                for (int i = 0; i < books.Length; i++)
                {
                    if (!(books[i] == null))
                    {
                        if (!books[i].Equals(bookToRemove))
                        {
                            // Add book to temp array
                            temp[loopCounter] = books[i];

                            // Loop counter increments *only* when books[i] doesn't equal book to remove
                            loopCounter++;
                        }
                    }
                }
                count--;
                books = temp;
                
                Console.WriteLine($"Book removed from library. Number of books in library is now {count}.");
                Console.WriteLine($"Length of books array is now {books.Length}.\n");
            }
            else
            {
                Console.WriteLine("Oops, there were no books to remove!\nYou can only remove a book if there are one or more books in the library!\n");
            }
        }

        /// <summary>
        /// Counts number of Books currently in Library
        /// </summary>
        /// <returns>Book count</returns>
        public int Count()
        {
            return count;
        }

        /// <summary>
        /// Implements IEnumerable
        /// </summary>
        /// <returns>Book object at each index of array</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
        }

        /// <summary>
        /// Implements IEnumerable
        /// </summary>
        /// <returns>GetEumerator()</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
