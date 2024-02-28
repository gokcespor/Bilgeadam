using DIP.BadExample;
using DIP.GoodExample.Concrete;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BadRestoran badRestoran = new BadRestoran();

            Console.WriteLine(badRestoran.GetMenu());


            GoodRestoran goodRestoran1 = new GoodRestoran(new GoodChicken());
            GoodRestoran goodRestoran2 = new GoodRestoran(new GoodChicken());

            Console.WriteLine(goodRestoran1.GetProductInfo());
            Console.WriteLine(goodRestoran2.GetProductInfo());
        }
    }
}
