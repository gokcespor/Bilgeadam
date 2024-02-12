using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MethodOverload
{
    internal class Program
    {
        /*
         * Method Overload
         * 
         * Bir methodun farklı method imzaları ile(aldığı parametre türü ve sayısı) farklı bir şekilde kullanılmasıdır.
         */



        //static string MailOlustur(string ad, string soyad)
        //{
        //    return ad + "." + soyad + "@bilgeadam.com";
        //}

        //static string MailOlustur(string ad)
        //{
        //    return ad + "@bilgeadam.com";
        //}

        static int Toplam(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Toplam(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        static void Main(string[] args)
        {
            #region Örnek
            // Kullanıcıdan isim ve soyisim(opsiyonel) alınız. Eğer ki soyisim girmezse sadece isim ile mail oluşturunuz.


            //Console.WriteLine("İsim giriniz: ");
            //string isim = Console.ReadLine();
            //Console.WriteLine("İsim giriniz: ");
            //string soyad = Console.ReadLine();
            //string mail = "";
            //if(soyad == "")
            //{
            //    mail = MailOlustur(isim);
            //}
            //else
            //{
            //    mail = MailOlustur(isim, soyad);
            //}
            //Console.WriteLine(mail);
            #endregion

            #region Soru 1
            // İki sayıyı veya 3 sayıyı toplayabilen methodu yazınız.
            int number1 = 12;
            int number2 = 13;
            int number3 = 14;
 
            int result1 = Toplam(number1, number2);
            int result2 = Toplam(number1, number2, number3);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            #endregion
        }
    }
}
