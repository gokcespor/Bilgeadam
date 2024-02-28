using Enums.Models;
using Enums.Enums;
using System.Threading.Channels;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.Ad = "Sina Emre";
            personel.Soyad = "Bekar";
            personel.Departman = Enums.Departmanlar.Yazilim;

            #region Enum.Parse
            // Verdiğiniz string değer arar bulamazsa hata fırlatır.
            try
            {
            int seciliEnumIndexi = (int)Enum.Parse(typeof(Departmanlar), "Yazilim");
            Console.WriteLine("Yazılım departmanının index numarası: " + seciliEnumIndexi);
            }
            catch 
            {
                Console.WriteLine("Böyle bir bölüm yok."); ;
            }
            #endregion

            #region Enum.TryParse
            Departmanlar cikacak;
            bool sonuc = Enum.TryParse<Departmanlar>("Yazilim", out cikacak);

            if (sonuc)
            {
                Console.WriteLine("Persolenin Departmanı => " + cikacak);
            }
            else
            {
                Console.WriteLine("Yanlış departmanı seçtiniz!");
            }
            #endregion

            #region Enum - Switch - Case Kullanımı
            switch (personel.Departman)
            {
                case Departmanlar.Yazilim:
                    Console.WriteLine("Hoşgeldin Admin!");
                    break;
                case Departmanlar.SistemAgUzmanligi:
                    Console.WriteLine("Hoşgeldin Örümcek Adam");
                    break;
                case Departmanlar.GrafikTasarim:
                    Console.WriteLine("Hoşgeldin Grafitici");
                    break;
                case Departmanlar.Ingilizce:
                    Console.WriteLine("Good Morning Student!!");
                    break;
                case Departmanlar.Muhasebe:
                    Console.WriteLine("Hoşgeldin Kolay gelsin!!");
                    break;
                default:
                    break;
            }
            #endregion

            #region Enum daki Değerleri Listeleme (Enum.GetNames)
            Console.WriteLine();
            Console.WriteLine("Departman Listesi");
            Console.WriteLine();

            var departmanlar = Enum.GetNames(typeof(Departmanlar));
            foreach (var departman in departmanlar)
            {
                Console.WriteLine(departman + " - " + Convert.ToInt32(Enum.Parse(typeof(Departmanlar), departman)));
            }
            #endregion

            #region Enum.GetName (Numarası verilen Enum ı Getirme)
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>" + Enum.GetName(typeof(Departmanlar),2));
            #endregion
        }
    }
}
