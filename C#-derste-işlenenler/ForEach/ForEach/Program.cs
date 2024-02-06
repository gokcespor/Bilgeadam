namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * FOREACH
             * 1) Kesinlikle index mantığı yokyur.
             * 2) Tip bağımlı döngülerdir.
             * 3) Çoğu zaman elimizdeki bir koleksiyonun her bir elemanını tek tek ele almak için kullanılır.
             */
            //string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Bursa", "Eskişehir", "Trabzon", "Sivas", "Malatya" };

           

            // Yukarıdaki dizinin elemanlarını for ile konsola yazdırınız.

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            //Console.WriteLine("============================================");
            // Yukarıdaki dizinin elemanlarını foreach ile konsola yazdırınız.
            // İlgili dizi içerisinde her bir elemana geçici olarak "sehir" takma adını verdik ve döngünün her bir adımında size dizinin her bir elemanını teslim eder.

            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            #region Çalışma
            //byte[] sayilar = { 1, 5, 7, 9, 15 };

            //long[] buyukSayilar = { 564564456, 9238743597, 9732935, 928348234 };

            //char[] harfler = { 'a', 'b', 'c', 'd' };

            //string[] kelimeler = {"sina", "emre", "bekar"};

            //int[] ortaSayilar = { 2348761, 324878239, 3472, 2342};

            //double[] ondalikliSayilar = { 12.45, 88.12, 42.45, 33.006 };

            //bool[] mantiklar = { true, false, true, false };

            //foreach (byte sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //foreach (long buyukSayi in buyukSayilar)
            //{
            //    Console.WriteLine(buyukSayi);
            //}

            //foreach (char harf in harfler)
            //{
            //    Console.WriteLine(harf);
            //}

            //foreach (string kelime in kelimeler)
            //{
            //    Console.WriteLine(kelime);
            //}

            //foreach (int ortaSayi in ortaSayilar)
            //{
            //    Console.WriteLine(ortaSayi);
            //}

            //foreach (double ondalikliSayi in ondalikliSayilar)
            //{
            //    Console.WriteLine(ondalikliSayi);
            //}

            //foreach (bool mantik in mantiklar)
            //{
            //    Console.WriteLine(mantik);
            //}

            // 2) Aşağıdaki elemanların toplamlarını, ortalamasını, en büyük değerini, en küçük değerini, çiftlerin toplamını, teklerin toplamını bulunuz. (FOREACH ile)

            int[] sayilarDizi = { 12, 154, 5456, -55, 465, -78, 66, 8798787, -12456, 45 };
            double ort = 0;

            int toplam = 0, enBuyuk = 0, enKucuk = 0, ciftTop = 0, tekTop = 0;
            foreach (int sayi in sayilarDizi)
            {
                
                toplam += sayi;
               
                if(enBuyuk < sayi)
                {  
                    enBuyuk = sayi;
                }
                if(enKucuk > sayi)
                {
                    enKucuk = sayi;
                }
                if(sayi % 2 == 0)
                {
                    ciftTop += sayi;
                }
                if (sayi % 2 == 1)
                {
                    tekTop += sayi;
                }

            }
            ort = Convert.ToDouble(toplam) / Convert.ToDouble(sayilarDizi.Length);
            Console.WriteLine(toplam);
            Console.WriteLine(ort);
            Console.WriteLine(enBuyuk);
            Console.WriteLine(enKucuk);
            Console.WriteLine(ciftTop);
            Console.WriteLine(tekTop);
            #endregion
        }
    }
}
