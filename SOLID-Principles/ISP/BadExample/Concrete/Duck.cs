using ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.BadExample.Concrete
{
    internal class Duck : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Ördek uçuyor...");
        }

        public void Swim()
        {
            Console.WriteLine("Ördek yüzer...");
        }

        public void Walk()
        {
            Console.WriteLine("Ördek yürür...");
        }
    }
}
