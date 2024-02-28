using ISP.GoodExample.GoodInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.GoodExample.GoodConcrete
{
    public class GoodHawk : IFly, IWalk
    {
        public void Fly()
        {
            Console.WriteLine("Atmaca uçuyor...");
        }

        public void Walk()
        {
            Console.WriteLine("Atmaca yürüyor...");
        }
    }
}
