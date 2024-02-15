using System.ComponentModel.DataAnnotations;

namespace MethodEnterance
{
    internal class Program
    {
        /*
         * 1)Geriye Değer Döndürmeyen Methodlar(Void Methodlar)
         * 
         * Genel olarak method bitince elinizde bir değer ya da yapı kalmaz. Sadece iş yaparlar ve yaptıkları iş sonucunda bir değer üretmezler. Temel olarak ikiye ayrılırlar. Parametre alan ve parametre almayan.
         * 
         * Method isimler kesinlikle ama kesinlikle büyük harfle başlar. 
           Method = Parantez Aç - Kapat => ()
           Method = Sarı Renk
         * 
         */
        static void Main(string[] args)
        {
            #region Örnek çalışmalar
            //Yazdir();
            //Console.WriteLine("==============================");
            //SayilariYazdir();
            //Console.WriteLine("==============================");
            //SayilariYazdirParametreli(10);
            //Console.WriteLine("==============================");
            //SayilariYazdirParametreli(100);

            // Method = Parantrez Aç - Kapat => ()
            // Method = Sarı renk


            //void Yazdir()
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Hello World.");
            //    }
            //}

            // Çalışma
            // 1 den 10 kadar olan sayıları ekrana yazdıran programı method ile birlikte yazınız.

            //void SayilariYazdir() 
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //void SayilariYazdirParametreli(int sayi)
            //{
            //    for (int i = 0; i < sayi; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Soru 1

            // Kullanıcıdan iki adet sayı alınız. BUnları toplayan ve ekrana yazdıran methodu önce tanımlayıp sonra kullanınız.


            //Console.WriteLine("İki sayı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İki sayı giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Toplam(sayi1, sayi2);

            //void Toplam(int sayi1, int sayi2)
            //{
            //    int toplam = sayi1 + sayi2;
            //    Console.WriteLine(toplam);
            //}

            #endregion

            #region Soru 2
            // Kullanıcıdan isim ve soyisimi ayrı ayrı alınız. Kullanıcıya isim.soyisim@bilgeadam.com şeklinde mail adresi gösteriniz. (Parametre alan bir method ile yapınız)

            //Console.Write("Adınızı giriniz: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soyadınızı giriniz: ");
            //string soyad = Console.ReadLine();
            //Email(ad, soyad);

            //void Email(string name, string surname)
            //{

            //    Console.WriteLine($"{ad}.{soyad}@bilgeadam.com");
            //}

            #endregion

            #region Soru 3
            // Kullanıcıdan aldığınız üç sayının çarpımını kullanıcıya göteriniz.(Parametre alan bir method aracılığıyla yazınız.)

            //Console.WriteLine("Üç tane sayı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Toplam(sayi1, sayi2, sayi3);

            //void Toplam(int number1, int number2, int number3)
            //{
            //    int carpim;
            //    carpim = number1 * number2 * number3;
            //    Console.WriteLine(carpim);
            //}

            #endregion

        }
    }
}
