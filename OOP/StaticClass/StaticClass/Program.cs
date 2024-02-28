namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı Sorusu
            //Console.WriteLine("Hello, World!");

            //Console.WriteLine(FizikKutuphanesi.KaldirmaKuvveti);
            //Console.WriteLine(FizikKutuphanesi.IndermeKuvveti);
            //Console.WriteLine(FizikKutuphanesi.YerCekimiKuvveti);
            //FizikKutuphanesi.Kaldir();
            #endregion

            #region Çalışma
            // Kendi adınızla bir static class oluşturun ve kişisel bilgilerinizi oraya ekleyin. (Property ve değişken olarak)
            // Yaşı göster adlı bir method ekleyin ve çalıştırılınca yaşınızı yazsın.
            Console.WriteLine($"Ad: {Gokce.Ad}\nSoyad: {Gokce.Soyad}\nSoyad: {Gokce.Soyad}\nDoğum Tarihi: {Gokce.DogumTarihi}");
            Console.WriteLine(Gokce.YasSoyle());
            #endregion

            #region Extension Method Örneği
            int sayi = 15;
            Console.WriteLine(sayi.Arttir());

            int yeniSayi = 450;
            Console.WriteLine(yeniSayi.Arttir());
            #endregion

            #region Çalışma
            // String verileri BuyukHarfeCevir extension methodunu yazalım.
            string name = "gOkCe";
            Console.WriteLine(name.BuyukHarfeCevir());
            #endregion

            #region Extension Method Class Kullanımı
            Kisi kisi = new Kisi();
            kisi.Ad = "Gökçe";
            kisi.Soyad = "Spor Alagöz";
            kisi.DogumTarihi = new DateTime(1991, 05, 22);

            Console.WriteLine(kisi.KisiBilgileriniGoster());
            #endregion
        }
    }
}
