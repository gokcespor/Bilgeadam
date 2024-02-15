namespace Out_Params_Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Açıklayıcı örnek Out
            // Bir metot yazalım. İçerisine iki adet sayı verelim. Bunların toplamı, farkı, çarpımı ve bölme işlemi sonucunu değişkene aktaralım.

            //int sayi1, sayi2, toplam, fark, carpim, bolum;

            //sayi1 = sayi2 = 10;

            //Hesapla(sayi1, sayi2, out toplam, out fark, out carpim, out bolum);

            //Console.Write($"Toplama işlemi sonucu: {toplam}\nÇıkarma işlemi sonucu {fark}\nÇarpma işlemi sonucu:{carpim}\nBölme işlemi sonucu:{bolum}");   

            //void Hesapla(int number1, int number2, out int toplam, out int fark, out int carpim, out int bolum)
            //{
            //    toplam = number1 + number2;
            //    fark = number1 - number2;
            //    carpim = number1 * number2;
            //    bolum = number1 / number2;
            //}


            #endregion

            #region Açıklayıcı örnek PARAMS

            //double FiyatlariHesapla(params double[] fiyatlar)
            //{
            //    double toplamFiyat = 0;

            //    foreach (var fiyat in fiyatlar)
            //    {
            //        toplamFiyat += fiyat;
            //    }
            //    return toplamFiyat;
            //}

            //double odenecekTutar = FiyatlariHesapla(5, 4, 10, 22, 66, 78, 98.12, 75.45, 42.18);
            //// veya aşağıdaki şekilde deyazılabilir.
            //double[] fiyatlar = { 5, 4, 10, 22, 66, 78, 98.12, 75.45, 42.18 };
            //double odenecekTutar2 = FiyatlariHesapla(fiyatlar);

            //Console.WriteLine(odenecekTutar);
            //Console.WriteLine(odenecekTutar2);

            #endregion

            #region Açıklayıcı örnek REF

            string[] elemanlar = new string[0];
            Console.WriteLine("Mail Adresi: ");
            string mailAdresleri = Console.ReadLine();



            Console.WriteLine("Mail Listeleyicinden Önce => \nDizinin boyutu => " + elemanlar.Length + "\nDizini elemanları => \n");



            MailListeleyici(ref elemanlar, mailAdresleri);



            Console.WriteLine("Mail Listeleyicinden Sonra => \nDizinin boyutu => " + elemanlar.Length + "\nDizini elemanları => \n");
            foreach (var mail in elemanlar)
            {
                Console.WriteLine(mail);
            }



            void MailListeleyici(ref string[] hangiDiziyeEklensin, string verilerinGeldigiYer)
            {
                string[] gelenDegerler = verilerinGeldigiYer.Split(',');



                for (int i = 0; i < gelenDegerler.Length; i++)
                {
                    Array.Resize(ref hangiDiziyeEklensin, hangiDiziyeEklensin.Length + 1);
                    hangiDiziyeEklensin[i] = gelenDegerler[i];
                }
            }
            #endregion
        }
    }
}
