using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_LendingLibrary.Classes
{
    // Create custom generic collection
    class Library<T> : IEnumerable
    {
        T[] books = new T[10];
        int count = 0;

        public void Add(T book)
        {
            if (count == books.Length)
            {
                Array.Resize(ref books, books.Length + (books.Length / 2));
            }

            // Updates books collection at next index
            books[count++] = book;
        }

        public void Remove(T book)
        {
            T[] temp = null;

            //TODO Determine size of temp and if it need resizing
            if (count < (books.Length - books.Length / 2))
            {
                Array.Resize(ref books, books.Length - (books.Length / 2));
            }

            //TODO Load temp array with items that don't need removed
            foreach (T item in books)
            {
                //if (item title != book title)
                //{
                    // Add to temp array
                //}

            } 

            books = temp;
        }

        public int Count()
        {
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
