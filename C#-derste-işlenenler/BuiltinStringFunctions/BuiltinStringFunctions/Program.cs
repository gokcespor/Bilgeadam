using System.Net.Mail;

namespace BuiltinStringFunctions
{
    internal class Program
    {
        /*
         * String Methodlar
         * 
         * Sahip olduğumuz metinsel değerlerin özelliklerini değiştirmek için kullanılan methodtur. Örneğin kelimeyi parçalamak, eklemek, harflerin yerlerini değiştirmek, boşluk temizlemek vs.
         */
        static void Main(string[] args)
        {
            //Console.Write("Bir metin giriniz: ");
            //string ornekMetin = Console.ReadLine();

            #region CompareTo
            // Bu method kullandığınız string değerler methoda verdiğimiz parametredeki string değeri sözlük mantığı ile karşılaştırır. Eğer sözlükteke aynı lokasyondalarsa 0, parametredeki değer ana değerlerimizden sözlükte önceyse -1, sonraysa +1 döner.



            //int sonuc = ornekMetin.CompareTo("bilgeadam");

            //string mesaj = "";
            //switch (sonuc) 
            //{
            //    case -1:
            //        mesaj = "Kelime sözlüğe göre geridedir.";
            //        break;
            //    case 0:
            //        mesaj = "Kelimeler aynı konumdadır.";
            //        break;
            //    case 1:
            //        mesaj = "Kelime sözlüğe göre öndedir.";
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(mesaj);   

            #endregion

            #region Contains
            // Verdiğiniz değer var mı diye kontrol eder.
            //bool varMi = ornekMetin.Contains("adam");
            //Console.WriteLine("Aradığınız değer " + (varMi ? "bulunmaktadır" : "Bulunmamaktadır."));

            #endregion

            #region StartsWith
            // Metininzin verdiiniz ifadeyle başlayıp başlamadığını boolean olarak döndürür.

            //bool sonuc = ornekMetin.StartsWith("bil");

            //Console.WriteLine(sonuc ? "Kelime \"bil\" ile başlamaktadır." : "Kelime \"bil\" ile başlamamaktadır.");
            #endregion

            #region EndsWith
            // Metininzin verdiiniz ifadeyle başlayıp başlamadığını boolean olarak döndürür.

            //bool sonuc = ornekMetin.EndsWith("bil");

            //Console.WriteLine(sonuc ? "Kelime \"dam\" ile bitmektedir." : "Kelime \"bil\" ile bitmemektedir.");
            #endregion

            #region IndexOf
            // Dizilerde gördüğümüz methodun aaynı prensipleriyle çalışır. Eğer harf varsa index ini, yoksa -1 değerini, birden çok varsa ilkini döndürür.

            //int index = ornekMetin.IndexOf('g');
            //Console.WriteLine((index >= 0 ? "'g' karakterinin index i => " + index : "'g' karakteri yoktur!"));   
            #endregion

            #region LastIndexOf
            // Dizilerde gördüğümüz methodun aaynı prensipleriyle çalışır. Eğer harf varsa index ini, yoksa -1 değerini, birden çok varsa ilkini döndürür.

            //int index = ornekMetin.LastIndexOf('g');
            //Console.WriteLine((index >= 0 ? "'g' karakterinin index i => " + index : "'g' karakteri yoktur!"));
            #endregion

            #region Remove
            // Matnin içerisinden istediğiniz bir bölümü çıkartır ve geriye kalan kısmı size teslim eder
            //string sonuc = ornekMetin.Remove(3); // Vrğinini parametreden sonrasını keser ve kalan kısmı size teslim eder.
            //Console.WriteLine(sonuc);

            //string sonuc2 = ornekMetin.Remove(3, 2); // Birinci parameteden başlar, ikinci parametrede verdiğiğniz adet kadar keser ve geriye kalan kısmı birleştirip size teslim eder.
            //Console.WriteLine(sonuc2);
            #endregion

            #region Replace
            // Replace => Metniniz içerisindeki bir karakteri ya da bir bölümü yeni bir karakter-bölüm ile değiştirmenize olanak sağlar.
            //string sonuc = ornekMetin.Replace("adam", "kadın");
            //Console.WriteLine(sonuc);
            #endregion

            #region Split
            // Metninizin özel bir karakterden birden fazla parçaya ayırmanıza olanak sağlayan methodtur. Aynı anda birden fazla özel karakterde verebilirsiniz.

            //string[] isimler = ornekMetin.Split(',', ';', ' ');
            //foreach (string isim in isimler)
            //{
            //    Console.WriteLine(Array.IndexOf(isimler, isim) + ")" + isim);
            //}
            #endregion

            #region Insert
            // Bir metinsel değerin herhangi bir pozisyonuna yeni bir değeri iliştrmek istiyorsanız bu methodu kullanabilirsiniz.

            //string sonuc = ornekMetin.Insert(5, "cik");
            //Console.Write(sonuc);
            #endregion

            #region ToLower, ToUpper
            // Büyük - Küçük küçük harf
            //Console.WriteLine("Büyük veersiyon => " + ornekMetin.ToUpper());
            //Console.WriteLine("Küçük veersiyon => " + ornekMetin.ToLower());
            #endregion

            #region ToCharArray
            // String inizi char larına ayırarak size teslim eder
            //char[] karakterler = ornekMetin.ToCharArray();

            // Girilen metinin ASCII değerlerinin toplamı
            //int toplam = 0;
            //for (int i = 0; i < karakterler.Length; i++)
            //{
            //    toplam += Convert.ToInt32(karakterler[i]);
            //    toplam += karakterler[i];
            //}
            //Console.WriteLine("ASCII değerleri toplamı => " + toplam);
            #endregion

            #region Trim
            // Metninizin sağında ve solunda boşlukları temizler
            //string yeniDeger = ornekMetin.Trim();
            //Console.WriteLine("Boşluklarla hesaplanana karakter sayısı: " + ornekMetin.Length + "\nBoşluksuz hesaplanan karakter sayısı: " + yeniDeger.Length);
            #endregion

            #region Soru - 1
            // Kullanıcıdan 5 tane mail adresi alınız. 5 mail adresini ekranda gösteriniz. Aralaırnda ',', ';' ya da '-' kullanarak girsin sizde alın. Daha sonra bunları index numaraları ile birlikte kullanıcıya gösterin.

       
            //Console.Write("Mail adresini giriniz: ");
            //string mailAdresleri = Console.ReadLine();
            //string[] mailAdres = mailAdresleri.Split(',', ';', ' ');
            

            //foreach (string mail in mailAdres)
            //{
            //    Console.WriteLine(Array.IndexOf(mailAdres, mail) + ")" + mail);
            //}


            #endregion
        }
    }
}
