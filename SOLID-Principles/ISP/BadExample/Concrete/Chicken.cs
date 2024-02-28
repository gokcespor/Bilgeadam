using ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.BadExample.Concrete
{
    public class Chicken : IBird
    {
        public void Fly()
        {
            
        }

        public void Swim()
        {
        }

        public void Walk()
        {
            Console.WriteLine("Tavuk yürüyor..."); 
        }
    }
}
