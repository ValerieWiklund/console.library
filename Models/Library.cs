using System;
using System.Collections.Generic;
using System.Linq;

namespace CLibrary.Models
{

  public class Library
  {

    public string Address { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public List<Book> CheckedOut { get; set; }




    public Library(string address, string name)
    {
      Address = address;
      Name = name;
      Books = new List<Book>();
      CheckedOut = new List<Book>();
    }

    private Book ValidateBook(string selection, List<Book> booklist)
    {
      int bookIndex;
      if (Int32.TryParse(selection, out bookIndex) && bookIndex > 0 && bookIndex <= booklist.Count)
      {
        return booklist[bookIndex - 1];
      }
      return null;
    }

    public void Checkout(string selection)
    {
      Book selectedBook = ValidateBook(selection, Books);

      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine("Invalid Selection");
        return;
      }
      else
      {
        selectedBook.Available = false;
        CheckedOut.Add(selectedBook);
        Books.Remove(selectedBook);
        Console.Clear();
        Console.WriteLine("Enjoy your book");
      }
    }


    public void Return(string selection)
    {
      Book selectedBook = ValidateBook(selection, CheckedOut);

      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine("Invalid Return Selection");
        return;
      }
      else
      {
        selectedBook.Available = true;
        Books.Add(selectedBook);
        CheckedOut.Remove(selectedBook);
        Console.Clear();
        Console.WriteLine("Thank you");
      }
    }

    public void PrintBooks()
    {
      System.Console.WriteLine("Books Available for Checkout");
      for (int i = 0; i < Books.Count; i++)
      {
        Book currentBook = Books[i];
        System.Console.WriteLine($"{i + 1} {currentBook.Title} - {currentBook.Author}");
      }
      Console.WriteLine("");
      Console.WriteLine("Select a book number to checkout (Q)uit, or (R)eturn a book");

    }
    public void PrintCheckedOut()
    {
      System.Console.WriteLine("Books Ready to be Returned");
      for (int i = 0; i < CheckedOut.Count; i++)
      {
        Book currentBook = CheckedOut[i];
        System.Console.WriteLine($"{i + 1} {currentBook.Title} - {currentBook.Author}");
      }
      Console.WriteLine("");
      Console.WriteLine("Select a book number to Return, (Q)uit, or (A)vailable books");

    }

    public void AddBook(Book book)
    {
      Books.Add(book);
    }
    public void AddBook(Book[] books)
    {
      Books.AddRange(books);
    }


  }
}
