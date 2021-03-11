using CreationalPatterns.FactoryMethod.Framework;
using CreationalPatterns.FactoryMethod.IdCard;

/*
The subject is a factory to make credit cards. The Factory defines how to create an credit card,
but the actual credit card is created by the CreditCardFactory.
The "createProduct()" is called a Factory Method, and it is responsible for manufacturing an object.
 */

namespace CreationalPatterns.FactoryMethod
{
    class Program
    {
        static void Main()
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
