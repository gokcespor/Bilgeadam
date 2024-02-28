using Polymorphizm.Models;

namespace Polymorphizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BasePhone Zil Sesi Çalma Denemesi
            //BasePhone phone = new BasePhone();
            //phone.ZilSesiCal();

            // Samsung için zil sesi çalma denemesi


            //Samsung samsung = new Samsung();
            //samsung.Id = 1;
            //samsung.Marka = "Samsung";
            //samsung.Model = "S23 Ultra";
            //samsung.Fiyat = 50000;


            Samsung samsung = new Samsung() { Id = 1, Marka = "Samsung", Model = "S23 Ultra", Fiyat = 50000};


            //Console.WriteLine($"Id: {samsung.Id}\nMarka: {samsung.Marka}\nModel: {samsung.Model}\nFiyat: {samsung.Fiyat}\n====================");
            //samsung.ZilSesiCal();

            AttackOnTitan attack = new AttackOnTitan();
            attack.Id = 2;
            attack.Marka = "Attack On Titan";
            attack.Model = "Anime";
            attack.Fiyat = 50000;

            //Console.WriteLine($"Id: {attack.Id}\nMarka: {attack.Marka}\nModel: {attack.Model}\nFiyat: {attack.Fiyat}\n====================");
            //attack.ZilSesiCal();

            IPhone iphone = new IPhone() { Id = 3, Marka = "IPhone", Model = "14 Pro Max", Fiyat = 60000 };
            //Console.WriteLine($"Id: {iphone.Id}\nMarka: {iphone.Marka}\nModel: {iphone.Model}\nFiyat: {iphone.Fiyat}\n====================");
            //iphone.ZilSesiCal();

            Nokia nokia = new Nokia() { Id = 4, Marka = "Nokia", Model = "N95", Fiyat = 5000 };
            //Console.WriteLine($"Id: {nokia.Id}\nMarka: {nokia.Marka}\nModel: {nokia.Model}\nFiyat: {nokia.Fiyat}\n====================");
            //nokia.ZilSesiCal();

            List<BasePhone> telefonlar = new List<BasePhone>() { samsung, iphone, nokia};

            foreach (BasePhone telefon in telefonlar)
            {
                Console.WriteLine($"Id: {telefon.Id}\nMarka: {telefon.Marka}\nModel: {telefon.Model}\nFiyat: {telefon.Fiyat}\n====================");
                telefon.ZilSesiCal();
            }

        }
    }
}
