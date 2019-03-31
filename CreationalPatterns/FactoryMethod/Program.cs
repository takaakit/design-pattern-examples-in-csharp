using CreationalPatterns.FactoryMethod.Framework;
using CreationalPatterns.FactoryMethod.IdCard;

// Factory to make ID cards.

namespace CreationalPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new CreditCardFactory();

            IProduct jacksonCard = factory.Create("Jackson");
            jacksonCard.Use();

            IProduct sophiaCard = factory.Create("Sophia");
            sophiaCard.Use();

            IProduct oliviaCard = factory.Create("Olivia");
            oliviaCard.Use();
        }
    }
}
