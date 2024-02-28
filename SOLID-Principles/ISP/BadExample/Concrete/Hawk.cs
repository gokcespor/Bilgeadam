using ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.BadExample.Concrete
{
    public class Hawk : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Atmaca uçuyor...");
        }

        public void Swim()
        {
            Console.WriteLine("Atmaca yürüyor...");
        }

        public void Walk()
        {
       
        }
    }
}
