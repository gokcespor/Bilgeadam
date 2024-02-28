using OCP.BadExample;
using OCP.GoodExample.Concrete;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BadExample
            var coffee = CoffeeType.Latte;
            var quantity = 3;

            Console.WriteLine(BadCoffee.GetTotalPrice(quantity, coffee));
            #endregion

            #region Good Example
            var latte = new Latte();
            Console.WriteLine(latte.GetTotalPrice(3));

            var americano = new Latte();
            Console.WriteLine(americano.GetTotalPrice(3));
            
            #endregion
        }
    }
}
