using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 0-100 arasında 3 ile bölümünden kalan 2 ve 5 ile bölünüden kalan 0 olan sayılar

            //Bol();

            //void Bol()
            //{
            //    for (int i = 0; i <= 100; i++)
            //    {
            //        if (i % 3 == 2 && i % 5 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            #endregion

            #region 0 ile 100 arasındaki çift sayıların toplamı
            //Cift();

            //void Cift()
            //{
            //    for (int i = 0; i <= 100; i++)
            //    {
            //        int toplam = 0;
            //        if (i % 2 == 0)
            //        {
            //            int result = toplam + i;
            //            Console.WriteLine(result);
            //        }
            //    }
            //}
            #endregion

            #region 0 ile 100 arasındaki sayıların toplamı
            //Toplam();

            //void Toplam()
            //{
            //    int toplam = 0;
            //    for (int i = 0; i <= 100; i++)
            //    {
            //        toplam += i;
            //    }
            //    Console.WriteLine(toplam);
            //}
            #endregion

            #region 0 ile 2500 arasındaki 4 ile tam bölünebilen, 3 ile bölümünden kalan 2 olan sayıların toplamını bulunuz.

            //Topla();

            //void Topla()
            //{
            //    int toplam = 0;
            //    for (int i = 0; i <= 2500; i++)
            //    {
            //        if (i % 4 == 0 && i % 3 == 2)
            //        {
            //            toplam += i;
            //        }
            //    }
            //    Console.WriteLine(toplam);
            //}
            #endregion

            #region 0 ile 10000 arasındaki 10 ile bölümünden kalan 4, 4 ile bölümünden kalan 2 olan sayıları yazdırın

            //Bol();

            //void Bol() 
            //{
            //    for (int i = 0; i <= 1000; i++)
            //    {
            //        if (i % 10 == 4 && i % 4 == 2)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion

            #region 0 ile N arasındaki çift sayıları ekrana yazdırın

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Cift(sayi);

            //void Cift(int number)
            //{
            //    for (int i = 0; i <= number; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion

            #region 1 ile N arasındaki 3 ile tam bölünen 5 ile bölündüğünde 2 kalan sayıların toplamını bulunuz.
            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Toplam(sayi);

            //void Toplam(int number)
            //{
            //    int toplam = 0;
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (i % 3 == 0 && i % 5 == 2)
            //        {
            //            toplam += i;
            //        }
            //    }
            //    Console.WriteLine(toplam);
            //}

            #endregion

            #region 0 dan 10 a kadar tüm sayıları yazdır
            //SayilariYazdir();

            //void SayilariYazdir()
            //{
            //    for (int i = 0; i <= 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 15 ile 150 arasındaki 3 ile tam bölünebilen sayılar
            //Bol();

            //void Bol() 
            //{
            //    for (int i = 15; i <= 150; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion

            #region 150 ile 1000 arasındaki 7 ile bölümünden 4 kalan sayıları ekranda gösteriniz.
            //Bol();

            //void Bol() 
            //{ 
            //    for (int i = 150; i <= 1000; i++)
            //    {
            //        if (i % 7 == 4)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion

            #region 20 ile 30 arasındaki sayıların çarpımı kaçtır?
            //Carpim();

            //void Carpim() 
            //{
            //    int carpim = 1;
            //    for (int i = 20; i <= 30; i++)
            //    {
            //        carpim = carpim * i;
            //    }
            //    Console.WriteLine(carpim);
            //}
            #endregion

            #region 20 ile 48 arasındaki 3 ile tam bölünebilen sayıların çarpımı kaçtır,
            //Carpim();

            //void Carpim() 
            //{
            //    int carp = 1;
            //    for (int i = 20; i <= 48; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            carp = carp * i;
            //        }
            //    }
            //    Console.WriteLine(carp);
            //}
            #endregion

            #region 20 ile 45 arasındaki tek sayıları ekranda yazdırınız.
            //Tek();

            //void Tek() 
            //{
            //    for (int i = 20; i <= 45; i++) 
            //    { 
            //        if (i % 2 == 1)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion

            #region A ile B arasında C'ye tam bölünebilen sayıların toplanını bulunuz
            //Console.Write("Başlangıç değeri giriniz: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Bitiş değeri giriniz: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Bölen değeri giriniz: ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //int result = Bol(a, b, c);
            //Console.WriteLine(result);

            //int Bol(int sayi1, int sayi2, int sayi3)
            //{
            //    int toplam = 0;
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        if (i % sayi3 == 0)
            //        {
            //            toplam += i;
            //        }
            //    }
            //    return toplam;
            //}

            #endregion

            #region A ile B arasındaki çift sayıların toplamını bulunuz.
            //Console.Write("Lütfen başlangıç değeri giriniz: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen bitiş değeri giriniz: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int result = Cift(a, b);
            //Console.WriteLine(result);

            //int Cift(int sayi1, int sayi2)
            //{
            //    int toplam = 0;
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            toplam += i;
            //        }
            //    }
            //    return toplam;
            //}
            #endregion

            #region Ad soyad yazdırma
            //Console.Write("Lütfen adınızı giriniz: ");
            //string ad = Console.ReadLine();
            //Console.Write("Lütfen soyadınızı giriniz: ");
            //string soyad = Console.ReadLine();

            //string message = Write(ad, soyad);
            //Console.WriteLine(message);

            //string Write(string name, string surname)
            //{
            //    string show = "Hoşgeldiniz " + name + " " + surname;
            //    return show;
            //}
            #endregion

            #region Kullanıcıdan 2 kenar alalım. Kullanıcıya alan için 1'e, çevre için 2'ye basın diyelim. Daha sonra 1'e bastıysa alanı gösterelim, 2'ye bastıysa çevreyi gösterelim.

            //Console.Write("Birinci kenarı giriniz: ");
            //int kenar1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci kenarı giriniz: ");
            //int kenar2 = Convert.ToInt32(Console.ReadLine());

            //Olcum(kenar1, kenar2);

            //void Olcum(int leght1, int leght2)
            //{

            //    bool hata = true;
            //    while (hata)
            //    {
            //        int secim;
            //        int alan = 0;
            //        int cevre = 0;
            //        Console.WriteLine("Alan için 1'e, Çevre için 2'ye basınız.");
            //        secim = Convert.ToInt32(Console.ReadLine());
            //        if (secim == 1)
            //        {
            //            alan = leght1 * leght2;
            //            Console.WriteLine($"Alan: {alan}");
            //            hata = false;
            //        }
            //        else if (secim == 2)
            //        {
            //            cevre = 2 * (leght1 + leght2);
            //            Console.WriteLine($"Çevre: {cevre}");
            //            hata = false;
            //        }
            //        else
            //            Console.WriteLine("Hatalı giriş yaptınız");
            //    }

            //}

            #endregion

            #region Kullanıcıdan yaşını isteyin. Eğer ki 20 yaşında veya daha büyükse askere gidebilir, değilse askere gidemez uyarısını versin.
            //Console.Write("Lütfen yaşınızı giriniz: ");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //int result = Yas(yas);


            //int Yas(int age)
            //{
            //    if (age >= 20)
            //    {
            //        Console.WriteLine("Askere gidebilir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Askere gidemez.");
            //    }
            //    return age;

            #endregion

            #region 1'den 100'e kadar olan çift sayıları ekranda yazdırınız.
            //Cift();

            //void Cift()
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion

            #region Dairenin alanı

            //Console.Write("Dairenin yarıçapını giriniz: ");
            //double r = Convert.ToDouble(Console.ReadLine());

            //Alan();

            //void Alan()
            //{
            //    double area = (Math.PI) * (Math.Pow(r,2));
            //    Console.WriteLine(area);
            //}

            #endregion

            #region  dikdörtgenin çevresi

            //Console.Write("Birinci kenarı giriniz: ");
            //int kenar1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci kenarı giriniz: ");
            //int kenar2 = Convert.ToInt32(Console.ReadLine());

            //int result = Cevre(kenar1, kenar2);
            //Console.WriteLine(result);

            //int Cevre(int sayi1, int sayi2)
            //{
            //    int cevre = 2 * (sayi1 + sayi2);
            //    return cevre;
            //}
            #endregion

            #region Kullanıcı gireceği 5 adet sayının karelerinin ortalamasını hesaplayarak kullancıya göster
            //Ortalama();

            //void Ortalama() 
            //{
            //    int ort = 0;
            //    int adet = 0;
            //    int toplam = 0;
            //    for (int i = 0; i <= 4; i++)
            //    {
            //        Console.Write("Sayı giriniz: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        int kare = sayi * sayi;
            //        toplam += kare;
            //        adet += 1;
            //    }
            //    ort = toplam / adet;
            //    Console.WriteLine(ort);
            //}
            #endregion

            #region Karenin Alanı
            //Alan();

            //void Alan() 
            //{
            //    Console.Write("Bir kenar uzunluğu giriniz: ");
            //    double kenar = Convert.ToDouble(Console.ReadLine());

            //    double alan = Math.Pow(kenar,2);
            //    Console.WriteLine(alan);

            //}
            #endregion

            #region Kullanıcı adı ve şifre
            //Console.Write("Kullanıcı adı giriniz: ");
            //string ad = Console.ReadLine();

            //Console.Write("Şifrenizi giriniz: ");
            //string sifre = Console.ReadLine();

            //bool result = Giris(ad, sifre);

            //bool Giris(string username, string password)
            //{
            //    if (username == "bilgeadam" && password == "1234")
            //    {
            //        Console.WriteLine("Hoşgeldin admin.");
            //        return true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı adı veya şifre hatalı");
            //        return false;
            //    }
            //}
            #endregion

            #region Kullanıcı "HESAPLA" yazana kadar girdiği sayıların ortalamasını hesaplayıp kullanıcıya gösterelim.


            //Ort();

            //void Ort()
            //{
            //    string secim = "";
            //    int ort = 0;
            //    int toplam = 0;
            //    int adet = 0;

            //    while (secim != "e") 
            //    {
            //        Console.Write("Lütfen sayı giriniz: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());

            //        toplam += sayi;
            //        adet += 1;

            //        Console.WriteLine("Sonuç hesaplansın mı? Hesaplansın istiyorsanız e yazın, yoksa h yazın.");
            //        secim = Console.ReadLine();
            //    }
            //    ort = toplam / adet;
            //    Console.WriteLine(ort);

            #endregion

            #region Kullanıcıdan aldığın N sayısına kadar olan sayıları ekranda yazdırınız.,
            //Show();

            //void Show() 
            //{
            //    Console.Write("Lütfen sayı giriniz: ");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region venüs-mars 1
            // Kişinin kilosunu alıyosunuz. Daha sonra kendisine mars kilosu mu yoksa venüs kilosunu mu istiyosunuz diye soruyoruz. Burada ki seçimine göre kilosunu ekranda gösteriyosunuz.(Mars: 0.39, Venüs 0.78)


            //Console.Write("Lütfen kilonuzu giriniz: ");
            //double kilo = Convert.ToDouble(Console.ReadLine());
            //Kilo(kilo);

            //void Kilo(double weight)
            //{
            //    bool hata = true;
            //    while (hata)
            //    {

            //        double sonuc = 0;
            //        int secim;

            //        Console.WriteLine("Mars kilonuz için 1'e, Venüs kilonuz için 2'ye basınız");
            //        secim = Convert.ToInt32(Console.ReadLine());
            //        if (secim == 1)
            //        {
            //            sonuc = weight * 0.39;
            //            Console.WriteLine(sonuc);
            //            hata = false;
            //        }
            //        else if (secim == 2)
            //        {
            //            sonuc = weight * 0.78;
            //            Console.WriteLine(sonuc);
            //            hata = false;
            //        }
            //        else
            //        {

            //            Console.WriteLine("Yanlış seçim yaptınız.");
            //        }

            //    }
            //}
            #endregion

            #region Kullanıcı sıfıra basana kadar girdiği sayılardan çift olanların adetini tutup kullanıcıya gösterelim.
            //Adet();

            //void Adet() 
            //{
            //    int i, adet;
            //    i = 1;
            //    adet = 0;

            //    while (i != 0)
            //    {
            //        Console.WriteLine("Sayıları girebilirsiniz. Eğer ki 0'a basarsanız işlem bitecektir");
            //        i = Convert.ToInt32(Console.ReadLine()); 
            //        if (i % 2 == 0 && i != 0)
            //        {
            //            adet += 1;
            //        }
            //    }
            //    Console.WriteLine($"{adet} adet çift sayı vardır.");
            //}

            #endregion

            #region Tek - Çift
            // Girilen sayının çift mi, tek mi ya da 0 mı olduğunu anlayıp kullanıcıya "Girilen Sayı Tektir" ya da "Girilen Sayı Çifttir" ya da "Girilen sayı sıfırdır" uyarısını veren programı yazınız

            Sayi();

            void Sayi() 
            {
                Console.Write("Lütfen sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2== 0 && sayi != 0)
                {
                    Console.WriteLine("Sayı çifttir");
                }
                else if (sayi % 2 == 0 && sayi == 0)
                {
                    Console.WriteLine("Sayı sıfırdır");
                }
                else
                {
                    Console.WriteLine("Sayı tektir.");
                }

            }
            #endregion
        }
    }
}
