/*
Create a simple homepage through a Facade (PageCreator). The Facade gets info from
the DataLibrary and uses the info to create an HTML file.
 */

namespace StructuralPatterns.Facade
{
    class Program
    {
        static void Main()
        {
            PageCreator.GetInstance().CreateSimpleHomepage("emily@example.com", "Homepage.html");
        }
    }
}
