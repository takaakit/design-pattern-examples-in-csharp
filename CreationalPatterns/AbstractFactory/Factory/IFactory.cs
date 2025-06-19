// ˅

// ˄

namespace CreationalPatterns.AbstractFactory.Factory
{
    public interface IFactory
    {

        Page CreatePage(string title, string author);

        Link CreateLink(string name, string url);

        Data CreateData(string name);

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
