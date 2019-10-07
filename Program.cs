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

      Enum activeMenu = Menus.CheckoutBook;
      bool inLibrary = true;
      while (inLibrary)
      {
        switch (activeMenu)
        {
          case Menus.CheckoutBook:
            myLibrary.PrintBooks();
            break;
          case Menus.ReturnBook:
            myLibrary.PrintCheckedOut();
            break;
        }
        string selection = Console.ReadLine();
        switch (selection.ToLower())
        {
          case "q":
            inLibrary = false;
            break;
          case "r":
            activeMenu = Menus.ReturnBook;
            Console.Clear();
            break;
          case "a":
            activeMenu = Menus.CheckoutBook;
            Console.Clear();
            break;
          default:
            if (activeMenu.Equals(Menus.CheckoutBook))
            {
              myLibrary.Checkout(selection);
            }
            else
            {
              myLibrary.Return(selection);
            }
            break;
        }

      }
      System.Console.WriteLine("Good-Bye");
    }
    public enum Menus
    {
      CheckoutBook,
      ReturnBook
    }
  }
}
