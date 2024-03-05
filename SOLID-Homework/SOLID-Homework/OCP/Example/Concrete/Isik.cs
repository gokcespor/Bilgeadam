using OCP.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Example.Concrete
{
    public class Isik : AcKapa
    {
        public override string AcKapat(string openclose)
        {
            if (openclose == "Aç")
            {
                //Console.WriteLine("Klima açıldı.");
                return "Işık açıldı.";
            }
            else if (openclose == "Kapat")
            {
                return "Işık kapandı.";
            }
            else
            {
                return "Anlayamadım.";
            }
        }
    }
}
