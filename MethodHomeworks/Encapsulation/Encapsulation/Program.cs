namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Urun urun = new Urun();
            //urun.Id = 1;
            //urun.Adi = "Portakal";
            //urun.Fiyat = 45.12;

            //Console.WriteLine($"Id: {urun.Id}\nAd :{urun.Adi}\nFiyat: {urun.Fiyat}");

            #region
            // Kişi adlı bir class üretin. (Id, Ad, Soyad, Yaş) bu classtan nesne üretilirken eğer ki yaş negatif girilirse yaş negatif olamaz uyarısı versin ve o field a değeri atamasın.

            Kisi kisi = new Kisi();    
            kisi.Id = 1;
            kisi.Name = "Gökçe";
            kisi.Surname = "Spor Alagöz";
            kisi.Yas = -10;

            Console.WriteLine($"Id: {kisi.Id}\nAd :{kisi.Name}\nFiyat: {kisi.Surname}\nYaş: {kisi.Yas}");
            #endregion
        }
    }
}
