// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Iterator
{
    public class BookShelf : IAggregate
    {
        // ˅
        
        // ˄

        public int NumberOfBooks
        {
            // ˅
            get; private set;
            // ˄
        } = 0;

        private readonly Book[] books;

        public BookShelf(int maxsize)
            // ˅
            
            // ˄
        {
            // ˅
            books = new Book[maxsize];
            // ˄
        }

        public IIterator Iterator()
        {
            // ˅
            return new BookShelfIterator(this);
            // ˄
        }

        public Book GetAt(int index)
        {
            // ˅
            return books[index];
            // ˄
        }

        public void Add(Book book)
        {
            // ˅
            books[NumberOfBooks] = book;
            NumberOfBooks++;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
