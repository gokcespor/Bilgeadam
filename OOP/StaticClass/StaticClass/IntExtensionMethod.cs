using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class IntExtensionMethod
    {
        //ORN .ToString();
        public static int Arttir (this int deger)
        {
            return deger += 1;
        }

        public static string BuyukHarfeCevir (this string cevir)
        {
            return cevir.ToUpper();
        }
        public static string KisiBilgileriniGoster(this Kisi kisi)
        {
            return $"Ad: {kisi.Ad}\nSoyad: {kisi.Soyad}\nYaş: {DateTime.Now.Year - kisi.DogumTarihi.Year}";
        }
    }
}
