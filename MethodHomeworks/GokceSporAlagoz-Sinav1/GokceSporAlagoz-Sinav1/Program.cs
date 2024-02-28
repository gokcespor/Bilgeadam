namespace GokceSporAlagoz_Sinav1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru-1
            //try
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    double sayi1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Bir sayı giriniz: ");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());

            //    Topla(sayi1, sayi2);
            //    Cikar(sayi1, sayi2);
            //    Carp(sayi1, sayi2);
            //    Bol(sayi1, sayi2);


            //    double Topla(double number1, double number2)
            //    {
            //        double topla = number1 + number2;
            //        Console.WriteLine(topla);
            //        return topla;
            //    }

            //    double Cikar(double number1, double number2)
            //    {
            //        double cikar = number1 - number2;
            //        Console.WriteLine(cikar);
            //        return cikar;
            //    }

            //    double Carp(double number1, double number2)
            //    {
            //        double carp = number1 * number2;
            //        Console.WriteLine(carp);
            //        return carp;
            //    }

            //    double Bol(double number1, double number2)
            //    {
            //        double bol = number1 / number2;
            //        Console.WriteLine(bol);
            //        return bol;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Soru-2
            //try
            //{
            //    Console.Write("Kullanıcı adınızı giriniz: ");
            //    string userName = Console.ReadLine();

            //    Console.Write("Şifrenizi giriniz: ");
            //    string password = Console.ReadLine();

            //    if (userName == "admin" && password == "1234")
            //    {
            //        Console.Write("Hoşgeldin admin");
            //    }
            //    else
            //    {
            //        Console.Write("Kullanıcı adı veya şifreyi yanlışgirdiniz!!");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Soru-3
            //try
            //{
            //    Console.Write("Uzun kenarın uzunluğunu giriniz: ");
            //    double kenar1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Uzun kenarın uzunluğunu giriniz: ");
            //    double kenar2 = Convert.ToDouble(Console.ReadLine());

            //    double result = Alan(kenar1, kenar2);
            //    Console.Write($"Sonuç: {result}");

            //    double Alan(double leght1, double leght2)
            //    {
            //        double alan = leght1 * leght2;
            //        return alan;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Soru-4
            //try
            //{
            //    Console.Write("Birinci açıyı giriniz: ");
            //    int aci1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("İkinci açıyı giriniz: ");
            //    int aci2 = Convert.ToInt32(Console.ReadLine());

            //    int result = 0;
            //    result = 180 - (aci1 + aci2);
            //    Console.WriteLine(result);
            //}
            //catch (Exception ex)
            //{
            //    Console.Write(ex.Message);
            //}
            #endregion

            #region Soru-5
            //try
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    double sayi = Convert.ToDouble(Console.ReadLine());

            //    double karesi = 1;
            //    karesi = Math.Pow(sayi, 2);
            //    Console.WriteLine(karesi);
            //    Console.WriteLine("===============================");

            //    if (sayi >= 0)
            //    {
            //        double koku = 1;
            //        koku = Math.Sqrt(sayi);
            //        Console.WriteLine(koku);
            //        Console.WriteLine("===============================");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Negatif sayıların çift kökü yoktur.");
            //        Console.WriteLine("===============================");
            //    }


            //    double mutlak = 1;
            //    mutlak = Math.Abs(sayi);
            //    Console.WriteLine(mutlak);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Soru-6
            //Console.Write("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Random rnd = new Random();
            //for (int i = 0; i < sayi; i++)
            //{
            //    int randomSayi = rnd.Next(0, 100);
            //    Console.Write(randomSayi + " , ");
            //}
            #endregion

            #region Soru-7
            //Console.Write("Sayıyı giriniz: ");
            //string[] sayilar = Console.ReadLine().Split(',');
            //double[] sayilarinDizisi = new double[sayilar.Length];
            //double toplam = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilarinDizisi[i] = Convert.ToInt32(sayilar[i].ToString());

            //}
            //foreach (var adet in sayilarinDizisi)
            //{
            //    toplam += adet;

            //}
            //double ort = toplam / sayilarinDizisi.Length;
            //Console.Write($"Sayıların ortalaması: {ort}");
            #endregion

            #region Soru-8
            //try
            //{
            //    Console.Write("Doğum tarihinizi giriniz: ");
            //    int dogumTarihi = Convert.ToInt32(Console.ReadLine());

            //    int yas = 0;
            //    yas = DateTime.Today.Year - dogumTarihi;
            //    Console.WriteLine($"Yaşınız: {yas}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Soru-9
            /*
             * sum.Ogrenciler kodu ile toplam öğrenci sayısı bulunur.
             */
            #endregion

            #region Soru-10
            /*
             * DESC ile büyükten küçüğe sıralanır.
             */
            #endregion

            #region Soru-11
            // cevap = 7
            #endregion

            #region Soru-12
            /*
             *  Örneğin bir a sayısı olsun. Bu a sayısı a = 5 için:
             *  1) a-- ;
             *  önce a sayısını bir arttırır sayıyı 6 yapar sonra tekrar azaltır ve 5 sayısını ekrana yazdırır.
             *  2) --a ;
             *  a sayısını bir azaltır ve ekrana 4 yazar.
             */
            #endregion

            #region Soru-13
            /*
             * int: Tam sayıları belirtmek için kullanılır
             * uint: Pozitif tam sayıları belirtmek için kullanılır.
             */
            #endregion




        }
    }
}




