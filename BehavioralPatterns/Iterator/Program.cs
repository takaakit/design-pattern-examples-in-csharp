using System;

// Add books in the bookshelf and display the names of the books in turn.

namespace BehavioralPatterns.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelf = new BookShelf(5);
            bookShelf.Add(new Book("Design Patterns: Elements of Reusable Object-Oriented Software"));
            bookShelf.Add(new Book("The Object Primer: Agile Model-Driven Development with UML 2.0"));
            bookShelf.Add(new Book("Software Systems Architecture: Working With Stakeholders Using Viewpoints and Perspectives"));
            bookShelf.Add(new Book("A Practical Guide to SysML: The Systems Modeling Language"));
            bookShelf.Add(new Book("A Pattern Language: Towns, Buildings, Construction"));

            var it = bookShelf.Iterator();
            while (it.HasNext())
            {
                var book = it.Next() as Book;
                Console.WriteLine(book.Title);
            }
        }
    }
}
