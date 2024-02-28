using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class AhizeliTelefon : BasePhone
    {
        public AhizeliTelefon(string marka, string model, double fiyat) : base(marka, model, fiyat)
        {
                
        }
        public double KabloUzunlugu { get; set; }
        public override string ZilSesiCal()
        {
            return "Ahizeli Telefon sesi çalınıyor...";
        }
    }
}
