using System.Text;

namespace System_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Directory (Klasör) İşlemleri
            // Klasör ekleme
            //Directory.CreateDirectory(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje");
            //Directory.CreateDirectory(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme-1");
            //Directory.CreateDirectory(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme-2");
            //Directory.CreateDirectory(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme-3");




            //string[] klasorler = Directory.GetDirectories(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje");

            //foreach(var klasor in klasorler)
            //{
            //    Console.WriteLine(klasor);
            //}

            //// Var olan dosysyı siler. Verilen dosya yoluna ekler.

            //if(!Directory.Exists(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme-2\Deneme-1"))// Deneme-2 içinde Deneme-1 yoksa oluştursun, varsa oluşturmasın
            //{
            //    // İlk verilen kısımdaki klasörü siler, ikinci verdiğiniz kısmma ekler
            //    Directory.Move(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme-1", @"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme-2\Deneme-1");
            //}

            //// Deneme-3 klasörü varsa siler
            //if(Directory.Exists(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme-3"))
            //{
            //    Directory.Delete(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme-3");
            //}
            #endregion

        #region Sürücü İşlemleri
            // DriveInfo: Sürücü bilgilerine erişim
            //DriveInfo[] tumSuruculer = DriveInfo.GetDrives();

            //foreach (var surucu in tumSuruculer)
            //{
            //    Console.WriteLine(surucu.Name);
            //    Console.WriteLine(surucu.TotalFreeSpace);
            //    Console.WriteLine(surucu.TotalSize);
            //    Console.WriteLine(surucu.VolumeLabel);
        //}
        #endregion

        #region File(Dosya) İşlemleri
        // File => Static bir dosya kontrol sınıfıdır. Directory ile aynı methodlara sahip olmasına rağmen File dosyalarda kullanılır, Directory klasörlerde

        // Dosya Oluşturma => Bu işlem dosya yazmaya yarayan FileStream class ı ile yapılır.

        FileStream fi = File.Create(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme.txt");

        // Dışarıdan oluşturduğumuz yazıyı GetBytes() ile ASCII kodları haline dönüştürüyoruz ve bir byte dizisine atıyoruz. Burada kullnadığımız UTF8Encoding(true) ile Türkçe karakterler destek veriyoruz.
        Byte[] info = new UTF8Encoding(true).GetBytes("Merhaba arkadaşlar nasılsınız??");

        fi.Write(info, 0, info.Length); // byte şeklinde olan yazımız (aslında ASCII kodları) write metodu ile dosyamıza yazılır.
        fi.Close();  // yapılan yazma işlemi ya da oluşturma işlemi kapatılmalıdır. Yoksa yazılma işlemi yapılmaz

        File.Delete(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Deneme.txt"); // Dosya silme işlemi yapar

            //List<string> kisiler = new List<string> { "Melis", "Pınar", "Gökçe", "Ayşenur", "Hülya", "Zeynep"};

            //File.AppendAllLines(@"C:\Users\gokce\OneDrive\Masaüstü\YeniProje\Kişiler.txt", kisiler, UTF8Encoding.UTF8);
            //// Satırları bir dosyaya ekler ve sonra dosyayı kapatır. Belirtilen dosya mevcut değilse yeni bir dosya ekler ve bilgileri içerisine yazar sonra dosyayı kapatır.


            //// Haftanın günlerini Günler.txt adlı dosyaya gönderin

            //Directory.CreateDirectory(@"C:\Users\gokce\OneDrive\Masaüstü\Gunler");
            //List<string> gunler = new List<string> { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            //File.AppendAllLines(@"C:\Users\gokce\OneDrive\Masaüstü\Gunler\Günler.txt", gunler, UTF8Encoding.UTF8);


            //IEnumerable<string> haftasonu = from line in File.ReadLines(@"C:\Users\gokce\OneDrive\Masaüstü\Gunler\Günler.txt") where ((line == ("Cumartesi")) || line == ("Pazar")) select line;

            //File.WriteAllLines(@"C:\Users\gokce\OneDrive\Masaüstü\Gunler\Haftasonu.txt", haftasonu);

            string yazi = File.ReadAllText(@"C:\Users\gokce\OneDrive\Masaüstü\Gunler\Bilgilendirme.txt");
            Console.WriteLine("Pınar Hanımın msajı => " + yazi);
            #endregion
        }
    }
}
