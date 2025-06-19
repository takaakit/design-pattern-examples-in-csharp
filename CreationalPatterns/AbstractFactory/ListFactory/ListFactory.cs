// ˅
using CreationalPatterns.AbstractFactory.Factory;

// ˄

namespace CreationalPatterns.AbstractFactory.ListFactory
{
    public class ListFactory : IFactory
    {
        // ˅
        
        // ˄

        public Page CreatePage(string title, string author)
        {
            // ˅
            return new ListPage(title, author);
            // ˄
        }

        public Link CreateLink(string name, string url)
        {
            // ˅
            return new ListLink(name, url);
            // ˄
        }

        public Data CreateData(string name)
        {
            // ˅
            return new ListData(name);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
