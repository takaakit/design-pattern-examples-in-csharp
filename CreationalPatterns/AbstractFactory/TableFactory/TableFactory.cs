// ˅
using CreationalPatterns.AbstractFactory.Factory;

// ˄

namespace CreationalPatterns.AbstractFactory.TableFactory
{
    public class TableFactory : IFactory
    {
        // ˅
        
        // ˄

        public Page CreatePage(string title, string author)
        {
            // ˅
            return new TablePage(title, author);
            // ˄
        }

        public Link CreateLink(string name, string url)
        {
            // ˅
            return new TableLink(name, url);
            // ˄
        }

        public Data CreateData(string name)
        {
            // ˅
            return new TableData(name);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
