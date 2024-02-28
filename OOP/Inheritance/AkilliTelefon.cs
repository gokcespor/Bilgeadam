using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class AkilliTelefon : BasePhone
    {
        public AkilliTelefon(string model, string marka, double fiyat, double ekranBoyutu, double bataryaKapasitesi, double kameraCozunurlugu) : base(marka, model, fiyat)
        {
            EkranBoyutu = ekranBoyutu;  
            KameraCozunurlugu = kameraCozunurlugu;
            BataryaKapasitesi = bataryaKapasitesi;
        }
        public double EkranBoyutu { get; set; }
        public double BataryaKapasitesi { get; set; }
        public double KameraCozunurlugu { get; set; }

        public override string ZilSesiCal()
        {
            return "Akıllı telefon sesi çalınıyor...";
        }
    }
}
