namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * WHILE LOOP
             * 1) For un parçalanmış halidir
             * 2) For ile yapabildiğimiz her şeyi rahatlıkla yapabiliriz.
             */
            #region For While kıyaslaması

            //for (int i = 0; i <= 100; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //while (i <= 100) 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion

            #region while - sonsuz döngü
            //int i = 0;
            //while (true)
            //{
            //    Console.WriteLine(i);
            //    i++;

            //    if (i == 25)
            //    {
            //        break; // break => döngüden çık
            //    }
            //}
            #endregion

            #region
            // 0 ile 100 arasındaki çift sayılar ile tek sayıların toplamının aralarındaki farkların karesi
            //int sonuc, fark;
            //int topCift = 0;
            //int topTek= 0;
            //int i = 0;
            //while (i <= 100)
            //{
            //    i++;
            //    if (i % 2 == 0)
            //    {
            //        topCift += i;
            //    }
            //    else
            //    {
            //        topTek += i;
            //    }
            //}
            //fark = topCift - topTek;
            //    sonuc = fark * fark;
            //Console.WriteLine(sonuc);
            #endregion

            #region 
            // A ile B arasındaki 3 ile tam bölünebilen sayıların ortalamasını bulunuz.

            //int a, b, ort, adet = 0;
            //Console.WriteLine("İki sayı giriniz:");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //int i = a;
            //while (i <= b) 
            //{
            //    if (i % 3 == 0 && i != 0)
            //    {
            //        adet++;
            //        toplam += i;
            //    }
            //    i++;
            //}
            //ort = toplam / adet;
            //Console.WriteLine(ort);
            #endregion

            #region

            // ilk soruyu sonsuz döngüyle çözünüz.(0 ile 100 arasındaki çift sayılar ile tek sayıların toplamının aralarındaki farkların karesi)

            //int sonuc, fark;
            //int topCift = 0;
            //int topTek = 0;
            //int i = 0;
            //while (true)
            //{
            //    if (i % 2 == 0)
            //    {
            //        topCift += i;
            //    }
            //    else
            //    {
            //        topTek += i;
            //    }
            //    i++; 
            //    if(i == 100)
            //    {
            //        break;
            //    }  
            //}
            //fark = topCift - topTek;
            //sonuc = fark * fark;
            //Console.WriteLine(sonuc); 
            #endregion

           
        }
    }
}
