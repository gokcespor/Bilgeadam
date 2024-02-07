using System.Net.NetworkInformation;

namespace ArrayExamples
{
    internal class Program
    {
    {
        static void Main(string[] args)
        {
            #region Soru 1
            // Kullanıcıdan sınıf mevcudu isteyip, o kadar adet de isim isteyip, bunu diziye aktarıp ekranda gösteriniz.
            //int sinifMevcudu = 0;

            //Console.WriteLine("Sınıf mevcudu griniz:");
            //sinifMevcudu = Convert.ToInt32(Console.ReadLine());

            //string[] adlar = new string[sinifMevcudu];

            //for (int i = 0; i < sinifMevcudu; i++)
            //{
            //    Console.WriteLine("Lütfen isim giriniz:");
            //    adlar[i] = Console.ReadLine();                       
            //}
            //Console.WriteLine("\nGirilen Öğrenci İsimleri:");
            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            #endregion

            #region Soru 2
            //Kullanıcıdan bir sayı alınız. Bu sayı aşağıdaki dizinin içinde var mı yok mu kullanıcıya söyleyiniz.
            // int[] sayilar = { 4, 78, 92, 33, 64, 756, 9865 };

            //Console.WriteLine("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //bool sayiVarMi = false;

            //foreach (var deger in sayilar)
            //{
            //    if (sayi == deger)
            //    {
            //        sayiVarMi = true;
            //    }
            //}

            //if (sayiVarMi == true)
            //{
            //    Console.WriteLine("Girdiğiniz sayı dizide bulunmaktadır.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı bulunmamaktadır.");
            //}

            #endregion

            #region Soru 3
            // Aşağıdaki dizideki tek sayıları ve adetini ekranda yazdır.

            //int[] sayilar = { 3, 71, 92, 33, 64, 751, 9863 };
            //int adet = 0;
            //foreach (int sayi in sayilar)
            //{
            //    if(sayi % 2 == 1)
            //    {
            //        adet++;
            //        Console.WriteLine(sayi);
            //    }
            //}
            //Console.WriteLine($"{adet} tane tek sayı vardır.");
            #endregion

            #region Soru 4
            // (Level-1)Haftanın günlerini bir diziye yazın, ardından kullanıcıdan 1 ile 7 arasında bir seçim yapmasını isteyin. Seçtiği rakama göre karşılık günü kullanıcıya gösterin.
            // (Level-2)Eğer ki yanlış bir seçim yaparsa hatalı bir seçim yaptınız deyip tekrar seçim yapmasını isteyin.

            // NOT: Haftanın günleri 1 den dizinin indexleri sıfırdan başlar.

            //string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar"};
            //Console.Write("1 den 7 ye kadar bir rakam seçiniz: ");
            //while (true) 
            //{ 
            //    int secim = Convert.ToInt32(Console.ReadLine());
            //    if(secim-1 >= 1 && secim - 1 <= 7)
            //    {
            //        Console.Write(gunler[secim-1]);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yanlış seçim yaptınız.");
            //    }
            //}


            #endregion

            #region Soru 5
            // Kullanıcıdan bir sayı alın. Aldığınız bu sayı kadar 0-100 aralığında rastgele bir sayı üretiyorsunuz. Boyutu yine aldığınız bu sayı kadar olan bir dizi üretip o dizi ekranda index numaraları ile birlikte gösteriniz.

            //Console.WriteLine("Bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int[] sayilar = new int[sayi];
            //for (int i = 0; i < sayi; i++)
            //{
            //    Random rnd = new Random();
            //    int randomSayi = rnd.Next(0, 100);
            //    sayilar[i] = randomSayi;
            //}
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine("Dizinin " + i + ". Elemanı => " + sayilar[i]);
            //}

            #endregion

            #region Soru 6
            // Şemsi Paşa Pasajında dili büzüşesiceler
            // Kullanıcıdan bir harf alınız. Bu harf yukarıdaki cümleden kaç kere geçtiyse onu kullanıcıya gösteriniz.
            // NOT: Her string bir char dizisidir.

            //string cumle = "Şemsi Paşa Pasajında dili büzüşesiceler";
            //Console.Write("Bir harf girin: ");
            //char harf = Convert.ToChar(Console.ReadLine());
            //int adet = 0;
            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    if (harf == cumle[i])
            //    {
            //        adet++;
            //    }
            //}
            
            //Console.WriteLine($"Gidiğiniz harf cümlede {adet} adet vardır.");
            #endregion
        }
    }
}
