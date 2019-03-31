// Create a simple homepage.

namespace StructuralPatterns.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            PageCreator.GetInstance().CreateSimpleHomepage("emily@example.com", "Homepage.html");
        }
    }
}
