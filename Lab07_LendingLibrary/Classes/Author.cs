using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_LendingLibrary.Classes
{
    public class Author
    {
        //public string Name { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Author constructor
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
