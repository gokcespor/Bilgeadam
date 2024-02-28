namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Anlatıcı Örnek 
            //AhizeliTelefon ahizeliTelefon = new AhizeliTelefon();

            ////Ata class'tan gelenler
            //ahizeliTelefon.Marka = "Samsung";
            //ahizeliTelefon.Model = "ZX43";
            //ahizeliTelefon.Fiyat = 2000;

            ////Kendine özgü olanlar
            //ahizeliTelefon.KabloUzunlugu = 2.45;

            //Console.WriteLine($"Marka: {ahizeliTelefon.Marka}\nModel: {ahizeliTelefon.Model}\nKablo Uzunluğu: {ahizeliTelefon.KabloUzunlugu}\nFiyat: {ahizeliTelefon.Fiyat}\nTelefon Sesi: ");
            ////Ata classtan gelen özellik
            //Console.WriteLine(ahizeliTelefon.ZilSesiCal());

            #endregion

            #region Çalışma - 1
            //Akıllı telefon class'ı üretin ve BasePhone class'ından miras alsın. Artı olarak Akıllı telefonlar özgü olan özellikleri de yine bu class'ın içine ekleyelim ve Program.cs'te bir adet nesnesini üretelim.

            //AkilliTelefon akilliTelefon = new AkilliTelefon();
            //akilliTelefon.Marka = "Apple";
            //akilliTelefon.Model = "IPhone 14 Pro Max";
            //akilliTelefon.Fiyat = 60000;
            //akilliTelefon.BataryaKapasitesi = 5000;
            //akilliTelefon.EkranBoyutu = 8.2;
            //akilliTelefon.KameraCozunurlugu = 48;

            //Console.WriteLine(akilliTelefon.ZilSesiCal());
            #endregion

            #region Çalışma - 2
            //Akıllı telefondan miras alan 2 adet telefon class'ı oluşturup Zil sesi oarakta markaların kendi zil seslerini ekleyiniz.

            ////Samsung nesnesi
            //Samsung samsung = new Samsung();

            ////BasePhone classından gelen özellikler
            //samsung.Marka = "Samsung";
            //samsung.Model = "S23";
            //samsung.Fiyat = 40000;

            ////Akilli Telefon classsından gelen özellikler
            //samsung.EkranBoyutu = 4.7;
            //samsung.KameraCozunurlugu = 128;
            //samsung.BataryaKapasitesi = 5000;

            //Console.WriteLine($"Marka: {samsung.Marka}\nModel: {samsung.Model}\nFiyat: {samsung.Fiyat}\nEkran Boyutu: {samsung.EkranBoyutu}\nKamera Çözünürlüğü: {samsung.KameraCozunurlugu}\nBatarya Kapasitesi: {samsung.BataryaKapasitesi}");
            //Console.WriteLine(samsung.ZilSesiCal());

            //Console.WriteLine();
            //Console.WriteLine("==========================");
            //Console.WriteLine();

            //Apple Nesnesi
            //Apple apple1 = new Apple();
            //apple1.Marka = "Apple";
            //apple1.Model = "IPhone 15";
            //apple1.Fiyat = 50000;
            //apple1.EkranBoyutu = 6;
            //apple1.KameraCozunurlugu = 48;
            //apple1.BataryaKapasitesi = 4500;
            //apple1.SiriVarMi = true;

            //string mesaj = apple1.SiriVarMi ? "Var" : "Yok";

            //Console.WriteLine($"Marka: {apple1.Marka}\nModel: {apple1.Model}\nFiyat: {apple1.Fiyat}\nEkran Boyutu: {apple1.EkranBoyutu}\nKamera Çözünürlüğü: {apple1.KameraCozunurlugu}\nBatarya Kapasitesi: {apple1.BataryaKapasitesi}\nSiri Var Mı? {mesaj}");


            //Console.WriteLine(apple1.ZilSesiCal());
            #endregion

            #region Ortak Listeye Alma
            //List<AkilliTelefon> phones = new List<AkilliTelefon>() { samsung, apple1 };
            ////phones.Add(samsung);
            ////phones.Add(apple1);

            //foreach (var phone in phones)
            //{
            //    Console.WriteLine($"Marka: {phone.Marka}\nModel: {phone.Model}\nFiyat: {phone.Fiyat}\nEkran Boyutu: {phone.EkranBoyutu}\nKamera Çözünürlüğü: {phone.KameraCozunurlugu}\nBatarya Kapasitesi: {phone.BataryaKapasitesi}");
            //    Console.WriteLine(phone.ZilSesiCal());
            //    Console.WriteLine("===========================");
            //}
            #endregion


            #region Constructor Bağlantıları
            // Ata Class
            BasePhone phone = new BasePhone("Motorola", "S12", 12000);
            //BasePhone phone2 = new BasePhone();

            // Alt Class
            AkilliTelefon akilliTelefon = new AkilliTelefon("S23", "Samsung", 55000, 5, 5000,128);

            // En Alt Class
            Samsung samsung = new Samsung("S23", "Samsung", 55000, 5, 5000, 67, "Android");
            Apple apple = new Apple("IPhone 14 Pro MAx", "Apple", 55000, 4.7, 4800,48,true, "IOS");
            #endregion

        }
    }
}
