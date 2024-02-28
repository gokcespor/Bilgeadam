using ISP.GoodExample.GoodInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.GoodExample.GoodConcrete
{
    public class GoodDuck : IWalk, IFly, ISwim

    {
        public void Fly()
        {
            Console.WriteLine("Ördek uçuyor...");
        }

        public void Swim()
        {
            Console.WriteLine("Ördek yüzüyor...");
        }

        public void Walk()
        {
            Console.WriteLine("Ördek yürüyor...");
        }
    }
}
