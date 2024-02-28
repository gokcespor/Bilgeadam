using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Apple : AkilliTelefon
    {
        public Apple(string marka, string model, double fiyat, double ekranBoyutu, double bataryaKapasitesi, double kameraCozunurlugu, bool siriVarMi, string isletim) : base(marka, model, fiyat, ekranBoyutu, bataryaKapasitesi, kameraCozunurlugu)
        {
            SiriVarMi = siriVarMi;
            Isletim = isletim;

        }
        public string Isletim { get; set; }

        public bool SiriVarMi { get; set; }

        public override string ZilSesiCal()
        {
            return "IPhone zil sesi çalınıyor...";
        }
    }
}
