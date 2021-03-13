/*
A trouble is turned around among supporters, and the trouble will be handled by the supporter who can handle it.
There are four types of supporters below:
* LazySupporter doesn't handle any trouble
* MoodySupporter handles odd ID troubles
* SpecialSupporter handles a trouble of the target ID.
* LimitedSupporter handles troubles below the limit ID.
 */

namespace BehavioralPatterns.ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            Supporter emily = new LazySupporter("Emily");
            Supporter william = new MoodySupporter("William");
            Supporter amelia = new SpecialSupporter("Amelia", 6);
            Supporter joseph = new LimitedSupporter("Joseph", 5);

            // Make a chain.
            emily.SetNext(william).SetNext(amelia).SetNext(joseph);

            // Various troubles occurred.
            for (int i = 0; i < 10; i++)
            {
                emily.Support(new Trouble(i));
            }
        }
    }
}
