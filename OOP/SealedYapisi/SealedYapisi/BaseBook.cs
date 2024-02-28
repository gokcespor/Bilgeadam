using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedYapisi
{
    public class BaseBook
    {
        public virtual void SatisYap()
        {
            Console.WriteLine("Satış yapıldı.");
        }
        public virtual void Kirala() 
        {
            Console.WriteLine("Kiralandı...");
        }
    }
}
