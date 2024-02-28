using LSP.BadExample.Concrete;
using LSP.GoodExample.ConcreteGood;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bad Example
            var ferrari = new Ferrari();
            Console.WriteLine(ferrari.Run());
            Console.WriteLine(ferrari.OpenAirConditioning());

            var murat131 = new Murat131();
            Console.WriteLine(murat131.Run());
            Console.WriteLine(murat131.OpenAirConditioning());
            #endregion

            #region Good Example

            var ferrariGood = new FerrariGood();
            Console.WriteLine(ferrariGood.Run());
            Console.WriteLine(ferrariGood.OpenAirConditioning());

            var murat131Good = new Murat131Good();
            Console.WriteLine(murat131Good.Run());
            //Console.WriteLine(murat131Good.OpenAirConditioning());
            #endregion
        }
    }
}
