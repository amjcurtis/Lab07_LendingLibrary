using System;
using Lab07_LendingLibrary.Classes;

namespace Lab07_LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // Instantiate custom generic collection
        Library<string> library = new Library<string>
        {
            "C# 7.0 in a Nutshell",
        }
    }
}
