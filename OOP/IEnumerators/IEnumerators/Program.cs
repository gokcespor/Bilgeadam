using IEnumerators.Models;

namespace IEnumerators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci() { Ad = "Yunus Emre", Soyad = "Ertuğrul", Yas = 24, Bolum = Bolum.Yazilim };
            Ogrenci ogrenci2 = new Ogrenci() { Ad = "Ayşenur", Soyad = "Cihangir", Yas = 27, Bolum = Bolum.Bilisim };
            Ogrenci ogrenci3 = new Ogrenci() { Ad = "Gökçe", Soyad = "Spor Alagöz", Yas = 32, Bolum = Bolum.Muhendislik };
            Ogrenci ogrenci4 = new Ogrenci() { Ad = "Melis Su", Soyad = "Baysal", Yas = 23, Bolum = Bolum.Mimarlik };

            Sinif sinif = new Sinif(ogrenci1, ogrenci2, ogrenci3, ogrenci4);
            foreach (var ogrenci in sinif)
            {
                Console.WriteLine(ogrenci.ToString());
            }
            Console.WriteLine($"Öğrencilerin yaşları toplamı = {sinif.YaslarinToplami()}");
        }
    }
}
