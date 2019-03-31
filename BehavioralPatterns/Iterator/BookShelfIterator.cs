// ˅
using System;
using System.Collections.Generic;
using System.Text;

// ˄

namespace BehavioralPatterns.Iterator
{
    public class BookShelfIterator : IIterator
    {
        // ˅
        
        // ˄

        private int index;

        private readonly BookShelf bookShelf;

        public BookShelfIterator(BookShelf bookShelf)
            // ˅
            
            // ˄
        {
            // ˅
            this.index = 0;
            this.bookShelf = bookShelf;
            
            // ˄
        }

        public bool HasNext()
        {
            // ˅
            return index < bookShelf.NumberOfBooks;
            // ˄
        }

        public object Next()
        {
            // ˅
            var book = bookShelf.GetAt(index);
            index++;
            return book;
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
