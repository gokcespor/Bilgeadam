using OCP.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Example.Concrete
{
    public class Klima : AcKapa
    {
        public override string AcKapat(string openclose)
        {
            if (openclose == "Aç")
            {
                //Console.WriteLine("Klima açıldı.");
                return "Klima açıldı.";
            }
            else if(openclose == "Kapat")
            {
                return "Klima kapandı.";
            }
            else
            {
                return "Anlayamadım.";
            }
        }
    }
}
