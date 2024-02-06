namespace ExceptionHanding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exception (İstisna) Türleri
             * 
             * 1) Runtime Exception (Çalışma Zamanı Hataları) => Çoğunlukla karşı taraf kaynaklı hatalardır.
             * Verilen sözlerin tutulmaması(sayi gireceğim diyip, harf girilmesi) ya da eksek ya da boş girilmesi örnek gösterilebilir. Burada yazılıöcı olabilecek tüm ihtimallere kontrollü eğer ki yapmazsa programın hata vermesi çok muhtemeldir.
             * 2) Syntax Exception (Söz Dizimi Hatası) => Tamamen yazılımcı kaynaklı hatadır. Yazılım hataları meydana geldiğinde devreye girer. En kolay çözülen hata tipidir. VS sizi uyarır. (Aşağıdaki Error List penceresinde) İlgili hataya çift tıklayıp detaya gidebilir ve hatayı anında düzeltebilirsiniz.
             * 3) Logical Error (Mantıksal Hatalar) => Tamamen programcı kaynaklı hatalardır. Uygulamanın algaritmasında meydana gelir. Örneğin bölme işlemi yapılacak bir yerde işlemin unutulması, değerin yanlış değerle değiştirilmesi... Çözülmesi en zor hatalardır. BU yüzden anlık olarak her şeyi takip etmeli ve gelen değerleri gözlemlemelisiniz. Eğer ki uygun olmayam bir şeyle karşılaşırsanız sorunu o an çözmelisiniz. Bu konuda VS nun size sağladığı tool larla bu işlemi halledebilirsiniz. (Immediate Window, Watch, Breakpoint)
             */

            /*
             * BREAKPOINT => Derleme aşamasına adım dahil olmak için kullanacağımız yardımcı tool udur. Yapmanız gereken şey, hangi satırdan derleme alanına dahil olmak istiyorsanız, ilgili satırın en sol kısmına gelip (gri alan) mouse un sol tuşuyla bir kırmızı top yerleştirilecektir. Artık derleyici bu satıra geldiği zaman sizin olaya dahil edecektir.
             * 
             * F11 adım adım ilerleyebilirsiniz. Değişkenlerin, nesnelerin üzerine gelip o anki değerlerini öğrenebilirsiniz, İşlemin bittiğine inanıyorsanız F5 e basıp breakpoint den çıkabilir ve işlemin kendisinin devam etmesini sağlayabilirsiniz.
             * 
             * Sol blogkta çıkan sarı ok, derlenen satırlarının işaretçisidir. Mouse yardımıyla ileri ya da geri oynetabilir yani adımları ya da tekrarlatabilirsiniz.
             * 
             * WATCH => Yalnızca run-time da (çalışma zamanı) kullanacbileceğiniz bir tool dur. Dolayısıyla pencereyi yalnızca çalışma zamanında görürsünüz.
             * İlk ayarlarınız WATCH penceresi kapalı olabilir. Uygulnamanızı çalıştırıp "CTRL" + "ALT" + "W" ardından 1 e basarak Watch penceresi getirirsiniz.
             * Run-Time da elinizde olan değerleri (kontrol değerleri, değişken değerleri) değiştirmenize, izlemenize olanak sağlayan yardımı tool dur. Açılan penceredeki "NAame" alanına ilgili değişkenin adını yazın "Enter" a basarsanız, "Value" alanındaki o anki değerlerini gözlemleyebilirsiniz. Ancak "CTRL + SPACE" kombinasyonu ile intellisence i aktif hale getirirsek otomatik bir şakilde veriyi getirebilirsiniz.
             * 
             */


            #region Try - Catch 1
            //try
            //{
            //    // Bu alana hata vermesi muhtemel kodlar yazılır.
            //    Console.WriteLine("Yaşınızı giriniz");
            //    int yas = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Tebrikler. Yaşınızı girmeyi becerebildiniz.");
            //}
            //catch
            //{
            //    // Hata verdikten sonra çalışacak kodlar yazılır.
            //    Console.WriteLine("Yaşıını yazmayı bile beceremedin!!");
            //    throw;
            //}
            #endregion


            #region Try - Catch 2

            //try
            //{
            //    Console.WriteLine("Yaşınızı giriniz");
            //    int yas = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Tebrikler. Yaşınızı girmeyi becerebildiniz.");
            //}
            //catch (Exception hata)
            //{
            //    // Uygulamanızın kararlılığını bozan istisnai durum ile ilgili size detayları teslim eden nesnedir.
            //    Console.WriteLine(hata.Message);
            //}

            #endregion

            #region Try - Catch 3
            //try
            //{
            //    Console.WriteLine("Yaşınızı giriniz");
            //    int yas = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Tebrikler. Yaşınızı girmeyi becerebildiniz.");
            //}
            //catch (Exception hata)
            //{
            //    // Uygulamanızın kararlılığını bozan istisnai durum ile ilgili size detayları teslim eden nesnedir.
            //    Console.WriteLine("Hata ile karşılaştığım için CATCH bloğunu çalıştırdım.");
            //    Console.WriteLine(hata.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Hata var mı yok mu bilmiyorum ama çalıştım. Ben FINALLY!!");
            //}
            #endregion

            #region Try - Catch 4
            //try
            //{
            //    Console.WriteLine("Birinci sayıyı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("İkinci sayıyı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int bolum = sayi1 / sayi2;

            //    Console.WriteLine(bolum);
            //}
            //catch (FormatException ex) // FormatException Hata Tipi
            //{
            //    Console.WriteLine("Yanlış formatta giriş yaptınız. Hata mesajı => " + ex.Message);
            //}
            //catch (DivideByZeroException ex) // Sıfıra Bölünme Hatası
            //{
            //    Console.WriteLine("Sıfıra bölmeye çalıştınız. Hata mesajı => " + ex.Message);
            //}
            //catch (OverflowException ex) // Veri Tipinin Boyutunun Aşılma Hatası
            //{
            //    Console.WriteLine("Veri tipinin boyutunu aşan bir giriş yaptınız. Hata mesajı => " + ex.Message);
            //}
            //catch (Exception ex) // Geriye Kalan Tüm Hatalar
            //{
            //    Console.WriteLine("Bir hatayla karşılaştım. Hata mesajı => " + ex.Message);
            //}

            #endregion

            #region Breakpoint

            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int ort = (sayi1 + sayi2) / 2;

            //Console.WriteLine(ort);
            #endregion

            #region Watch
            int sayi = 10;
            sayi++;
            sayi++;
            sayi++;
            sayi -= 15;
            sayi++;
            sayi *= 5;
            #endregion
        }
    }
}
