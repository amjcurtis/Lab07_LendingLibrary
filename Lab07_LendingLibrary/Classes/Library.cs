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
        T[] books = new T[10];
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
        }

        /// <summary>
        /// Removes a Book object from Library collection
        /// </summary>
        /// <param name="book">Book object</param>
        public void Remove(T book)
        {
            //TODO Add if stmt so count decrements only if the book to remove actually exists in the library


            T[] temp = new T[books.Length];

            // Determine size of temp array and if it need resizing
            if (count < (books.Length - books.Length / 2))
            {
                Array.Resize(ref books, books.Length - (books.Length / 2));
            }

            // Load temp array with items that don't need to be removed
            for (int i = 0; i < books.Length; i++)
            {
                if ( !(books[i] == null) )
                {
                    if ( !books[i].Equals(book) )
                    {
                        // Add to temp array
                        temp[i] = books[i];
                    }
                }
            }
            count--;
            books = temp;
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
