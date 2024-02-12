using System.Transactions;

namespace MethodContinue
{
    internal class Program
    {
        /*
         * Method Overload
         * 
         * Bir methodun farklı method imzaları ile(aldığı parametre türü ve sayısı) farklı bir şekilde kullanılmasıdır.
         */
        static void Main(string[] args)
        {
            #region Örnek Çalışmalar
            // İki sayıyı toplayan methodu yazalım.

            //int a = 14;
            //int b = 29;

            //int result = Topla(a, b);
            //Console.WriteLine(result);
            //Console.WriteLine(Topla(a, b));

            //int Topla(int sayi1, int sayi2)
            //{
            //    int toplam = sayi1 + sayi2;
            //    return toplam;
            //}
            #endregion

            #region Soru 1
            // Kullanıcıdan aldığınız ad ve soyad bilgisi ile mail oluşturunuz. (Geriye değer döndüren bir method aracılığı ile çözünüz)

            //Console.Write("Adınızı giriniz: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soyadınızı giriniz: ");
            //string soyad = Console.ReadLine();

            //string result = Mail(ad, soyad);
            //Console.WriteLine(result);

            //string Mail(string name, string surname)
            //{
            //    string mail = name.ToLower() + "." + surname.ToLower() + "@bilgeadam.com";
            //    return mail;
            //}
            #endregion

            #region Soru 2

            // Kullanıcıdan doğum yılını alın ve kendisine yaşını söyleyin. (Geriye değer döndüren bir methodla yapınız.)
            //Console.Write("Doğum yılınızı giriniz: ");
            //int yil = Convert.ToInt32(Console.ReadLine());

            //int result = DogumYili(yil);
            //Console.WriteLine(result);

            //int DogumYili (int year)
            //{
            //    int yas = DateTime.Now.Year - yil;
            //    return yas;
            //}
            #endregion

            #region Soru 3
            // Şu anki zamandan gece mi gündüz mü olduğunu kullanıcıya söyleyin
            // Örnek çıktı şu an saat 13.17 ve gündüz.

            //Console.WriteLine("Şu an saat " + DateTime.Now.Hour + " ve " + (SuaGunduzMu() ? "gündüz" : "gece"));

            //bool SuaGunduzMu()
            //{

            //    int saat = DateTime.Now.Hour;
            //    if (saat >= 6 && saat <= 18)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            #endregion

            #region Soru 4
            // Kullanıcıdan bir sayı alınız. O sayı kadar kullanıcıya 0 ile 100 arası random sayı gösteriniz. (Parametre alan geriye değer döndüreen bir methodla çözünüz.)

            //Console.Write("Bir sayı yazınız: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            #region 1. yol
            //int[] sayilar = SayiUret(sayi);
            //foreach (var number in sayilar)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] SayiUret(int deger)
            //{
            //    Random rnd = new Random();

            //    int[] degerler = new int[deger];

            //    for (int i = 0; i < deger; i++)
            //    {
            //        int randomSayi = rnd.Next(0, 100);
            //        degerler[i] = randomSayi;
            //    }
            //    return degerler;
            //}

            #endregion

            #region 2. yol

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine(SayiUret());
            //}

            //int SayiUret()
            //{
            //    Random rnd = new Random(); 
            //    return rnd.Next(0, 100);
            //}
            #endregion

            #endregion


        }
    }
}
