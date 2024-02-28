using Abstraction.Models.Concrete;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gitar gitar = new Gitar();  
            gitar.Id = 1;
            gitar.Marka = "Yamaha";
            gitar.Aciklama = "Pahalıdır";
            gitar.Fiyat = 100000;

            //Console.WriteLine($"Id: {gitar.Id}\nMarka: {gitar.Marka}\nAçıklama: {gitar.Aciklama}\nFiyat: {gitar.Fiyat}\nÇal: {gitar.Cal()}");

            //Console.WriteLine("==========================");
            YanFlut yanFlut = new YanFlut() {Id = 2, Marka = "Dominguez", Aciklama = "La Karar", Fiyat = 120000};
            //Console.WriteLine($"Id: {yanFlut.Id}\nMarka: {yanFlut.Marka}\nAçıklama: {yanFlut.Aciklama}\nFiyat: {yanFlut.Fiyat}\nÇal: {yanFlut.Cal()}");

            //Console.WriteLine("==========================");

            Bateri bateri = new Bateri() { Id = 3, Marka = "Yamaha", Aciklama = "Az pahalı", Fiyat = 1200000 };
            //Console.WriteLine($"Id: {bateri.Id}\nMarka: {bateri.Marka}\nAçıklama: {bateri.Aciklama}\nFiyat: {bateri.Fiyat}\nÇal: {bateri.Cal()}");


            // Müzisyenler
            Muzisyen gitarist = new Muzisyen() { Ad= "Hamza", Soyad = "Gitarsoy", CaldigiEnstruman = gitar};
            Muzisyen baterist = new Muzisyen() { Ad = "Hamza", Soyad = "Baterisoy", CaldigiEnstruman = bateri };
            Muzisyen flutcu = new Muzisyen() { Ad = "Hamza", Soyad = "Flütsoy", CaldigiEnstruman = yanFlut };

            List<Muzisyen> muzisyenler = new List<Muzisyen>() { gitarist, baterist, flutcu };

            foreach (Muzisyen muzisyen in muzisyenler)
            {
                Console.WriteLine($"Ad: {muzisyen.Ad}\nSoyad:{muzisyen.Soyad}\nÇaldığı Enstruman Bilgiler: \nId: {muzisyen.CaldigiEnstruman.Id}\nMarka: {muzisyen.CaldigiEnstruman.Marka}\nAçıklama: {muzisyen.CaldigiEnstruman.Aciklama}\nFiyatı: {muzisyen.CaldigiEnstruman.Fiyat}\nSes: {muzisyen.CaldigiEnstruman.Cal()}\n===========================");
            }

        }
    }
}
