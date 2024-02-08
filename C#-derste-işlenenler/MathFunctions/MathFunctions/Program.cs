namespace MathFunctions
{
    internal class Program
    {
        /*
         * Math Class
         * Hazır olarak onlarca matematiksel fonksiyonu bize sunan temel sınıftir. Yuvarlama işlemleri, PI bilgisi, Karekökü, kuvvet vs.
         */
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.PI);

            //int mutlakDeger = Math.Abs(-45); // Mutlak değer
            //Console.WriteLine(mutlakDeger);

            //double floor = Math.Floor(12.98); // verilen ondalıklı değeri bir üst değere yuvarlar
            //double floor2 = Math.Floor(-12.98);
            //Console.WriteLine(floor);
            //Console.WriteLine(floor2);

            //double ceiling = Math.Ceiling(12.98); // Verilen ondalıklı değeri bir üst değere tamamlar.
            //Console.WriteLine(ceiling);

            //// Round Sayının yarısından fazlasını bir üste, yarısından azını ise bir alta tamamlar.
            //// Not : . dan önceki sayı çift ise bir alt değere, tek ise bir üst değer tamamlar.

            //double round1 = Math.Round(12.13);
            //Console.WriteLine(round1);

            //double round2 = Math.Round(12.73);
            //Console.WriteLine(round2);

            //double round3 = Math.Round(12.50);
            //Console.WriteLine(round3);

            //double round4 = Math.Round(13.50);
            //Console.WriteLine(round4);

            //// TRUNCATE sayını ondalıklı kısmına bakmaz sadece tam kısmını size teslim eder.
            //double truncate = Math.Truncate(12.98);
            //Console.WriteLine(truncate);

            //// Min-Max
            //Console.WriteLine(Math.Max(12, 45));
            //Console.WriteLine(Math.Min(12, 45));

            #region Soru 1
            // Kullanıcıdan aldığımız 3 adet sayının hangisinin en büyük, hangisinin en küçük olduğunu sadece Math class ındaki fonksiyonlar ile bulunuz.
            //Console.WriteLine("Sayıları giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //double max = Math.Max(Math.Max(sayi1, sayi2), sayi3);
            //double min = Math.Min(Math.Min(sayi1, sayi2), sayi3);

            //Console.WriteLine($"En büyük sayı {max}, en küçük sayı {min}");
            #endregion

            #region Soru 2
            // Kullanıcıdan aldığınız üç adet sayının ortancasını bulunuz.

            //Console.WriteLine("Sayıları giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //double ortanca = 0;

            //double max = Math.Max(Math.Max(sayi1, sayi2), sayi3);
            //double min = Math.Min(Math.Min(sayi1, sayi2), sayi3);
            //ortanca = (sayi1 + sayi2 + sayi3) - (max + min);

            //Console.WriteLine(ortanca);

            //int[] sayilar = { sayi1, sayi2, sayi3 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] != max && sayilar[i] != min)
            //    {
            //        ortanca = sayilar[i];
            //    }
            //}

            //Console.WriteLine(ortanca);
            #endregion

            double pow = Math.Pow(3, 4); // Kuvvet işlemi için kullanılır
            Console.WriteLine(pow);

            double sqrt = Math.Sqrt(16); // Sayının karekökü bullunur.
            Console.WriteLine(sqrt);

            double sign = Math.Sign(-10); // sayı neatifse -1, pozitifse +1, 0 ise 0 döner.
            Console.WriteLine(sign);

        }
    }
}
