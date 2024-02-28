using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Samsung : AkilliTelefon
    {
        public Samsung(string marka, string model, double fiyat, double ekranBoyutu, double bataryaKapasitesi, double kameraCozunurlugu, string surum) : base(marka, model, fiyat, ekranBoyutu, bataryaKapasitesi, kameraCozunurlugu)
        {

            Surum = surum;

        }

        public string Surum { get; set; }
        public override string ZilSesiCal()
        {
            return "Samsung zil sesi çalınıyor...";
        }
    }
}
