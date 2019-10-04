using System.Collections.Generic;

namespace CLibrary.Models
{

  public class Library
  {
    public string Address { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public void Setup()
    {

    }

    public Library(string address, string name)
    {
      Address = address;
      Name = name;
      Books = new List<Book>();
    }

    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        System.Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }

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
