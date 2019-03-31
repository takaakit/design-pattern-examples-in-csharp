namespace BehavioralPatterns.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Supporter emily = new LazySupporter("Emily");
            Supporter william = new MoodySupporter("William");
            Supporter amelia = new SpecialSupporter("Amelia", 153);
            Supporter michael = new SpecialSupporter("Michael", 340);
            Supporter joseph = new LimitedSupporter("Joseph", 250);
            Supporter lily = new LimitedSupporter("Lily", 250);

            // Make a chain.
            emily.SetNext(william).SetNext(amelia).SetNext(michael).SetNext(joseph).SetNext(lily);

            // Various troubles occurred.
            for (var i = 0; i < 500; i += 17)
            {
                emily.Support(new Trouble(i));
            }
        }
    }
}
