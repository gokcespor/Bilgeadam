using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BasePhone
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }

        public virtual string ZilSesiCal ()
        {
            return "Default ses çalıyor...";
        }

        public virtual string Ekran ()
        {
            return "Küçük ekran";
        }
    }
}
