/*
Display a character string as follows
  -- Nice to meet you --
or display it as follows.
  [[ Nice to meet you ]]
*/

namespace StructuralPatterns.Adapter
{
    class Program
    {
        static void Main()
        {
            IPrint p = new PrintMessageDisplay("Nice to meet you");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}
