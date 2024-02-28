namespace ExtensionHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kişilerin doğum günü mesajı ileten bir extension method yazınız. Yeni bir proje oluşturunuz ve Kişi classını ekleyiniz. O class a özgü extension method yazınız.

            Kisi kisi1 = new Kisi();
            kisi1.Ad = "Gökçe";
            kisi1.Soyad = "Spor Alagöz";

            Console.WriteLine(kisi1.DogumGunuMesaji());

            Kisi kisi2 = new Kisi();
            kisi2.Ad = "Cihan";
            kisi2.Soyad = "Alagöz";

            Console.WriteLine(kisi2.DogumGunuMesaji());
        }
    }
}
