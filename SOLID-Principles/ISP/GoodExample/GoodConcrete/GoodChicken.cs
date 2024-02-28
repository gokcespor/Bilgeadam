using ISP.GoodExample.GoodInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.GoodExample.GoodConcrete
{
    public class GoodChicken : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("Tavuk yürüyor...");
        }
    }
}
