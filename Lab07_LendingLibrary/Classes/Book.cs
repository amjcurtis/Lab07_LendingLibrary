using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_LendingLibrary.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genres Genre { get; set; }

        public enum Genres
        {
            Fiction,
            History,
            Programming
        }
    }
}
