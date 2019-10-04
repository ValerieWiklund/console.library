using System;
using CLibrary.Models;

namespace CLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      Book cd = new Book("Changes", "Jim Butcher");
      Book th = new Book("The Hobbit", "J.R.R. Tolkien");
      Book mp = new Book("The Unexpected Mrs. Pollifax", "Dorothy Gillman");
      Book sb = new Book("Silver Borne", "Patricia Briggs");
      Book ew = new Book("Eye of the World", "Robert Jordan");

      Library myLibrary = new Library("Boise", "Public Library");
      myLibrary.AddBook(new Book[] { cd, th, mp, sb, ew });

      Console.Clear();
      Console.WriteLine("Welcome to The Library!");
      Console.WriteLine("");
      myLibrary.PrintBooks();
      Console.WriteLine("");
      Console.WriteLine("Select a book number to checkout (Q)uit, or (R)eturn a book");
      string choice = Console.ReadLine().ToLower();




    }
  }
}
