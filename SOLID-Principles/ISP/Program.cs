using ISP.BadExample.Concrete;
using ISP.GoodExample.GoodConcrete;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bad Example
            var chicken = new Chicken();
            chicken.Walk();

            // Tavuğun aşağıdaki yetenekleri almaması gerekiyordu.
            chicken.Swim();
            chicken.Fly();

            var hawk = new Hawk();
            hawk.Walk();
            hawk.Fly();

            // Atmaca yüzmemesi gerekiyordu
            hawk.Swim();
            #endregion

            #region Good Example
            var chickenGood = new GoodChicken();
            chickenGood.Walk();

            var hawkGood = new GoodHawk();
            hawkGood.Walk();
            hawkGood.Fly();

            var duckGood = new GoodDuck();
            duckGood.Walk();
            duckGood.Fly();
            duckGood.Swim();
            #endregion
        }
    }
}
