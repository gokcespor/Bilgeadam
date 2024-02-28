namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AhizeliTelefon telefon = new AhizeliTelefon();

            telefon.Marka = "Samsung";
            telefon.Model = "ZX43";
            telefon.Fiyat = 2000;

            telefon.KabloUzunlugu = 2.45;
            

            Console.WriteLine($"Marka: {telefon.Marka}\nModel: {telefon.Model}\nKablo Uzunluğu: {telefon.KabloUzunlugu}\nFiyat: {telefon.Fiyat}\nTelefon Sesi: {telefon.ZilSesiCal}\nEkran: {telefon.Ekran}");

            Console.WriteLine(telefon.ZilSesiCal());
            Console.WriteLine(telefon.Ekran());

            AkilliTelefon telefon2 = new AkilliTelefon();

            telefon2.Marka = "Apple";
            telefon2.Model = "8 plus";
            telefon2.Fiyat = 10000;

            Console.WriteLine(telefon2.Ekran());

            Console.WriteLine($"Marka: {telefon2.Marka}\nModel: {telefon2.Model}\nFiyat: {telefon2.Fiyat}\nTelefon Sesi: {telefon2.ZilSesiCal}\nEkran: {telefon2.Ekran}");
            
        }
    }
}
