namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Urun urun = new Urun();
            //urun.Id = 1;
            //urun.Ad = "Portakal";
            //urun.Fiyat = -45.12;

            //Console.WriteLine($"Id: {urun.Id}\nAd: {urun.Ad}\nFiyat: {urun.Fiyat}");

            #region Çalışma
            //Kişi adlı bir class üretin.(Id, Ad, Soyad, Yaş) Bu classtan nesne üretilirken eğer ki yaş negatif girilirse yaş negatif olamaz uyarısı versin ve o field'a değeri atamasın.
            Kisi kisi = new Kisi();
            kisi.Id = 1;
            kisi.Ad = "Sina Emre";
            kisi.Soyad = "Bekar";
            kisi.Yas = 30;

            Console.WriteLine($"Id: {kisi.Id}\nAd: {kisi.Ad}\nSoyad: {kisi.Soyad}\nYaş: {kisi.Yas}");

            //Dolarlı Yazım Şekli
            string ad = $"{kisi.Ad} {kisi.Soyad}"; 
            string ad2 = kisi.Ad + " " + kisi.Soyad;
            #endregion
        }
    }
}
