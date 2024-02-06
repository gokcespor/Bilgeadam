namespace kullaniciDegeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı değeri giriniz: ");
            string kullanici = Console.ReadLine().ToLower();
            if (kullanici == "admin" || kullanici == "moderator" || kullanici == "yonetici" || kullanici == "ceo" || kullanici == "baskan")
            {
                Console.WriteLine("Yönetim Paneline Yönlendiriliyorsunuz...");
            }
            else if (kullanici == "uye")
            {
                Console.WriteLine("Ana Sayfaya Yonlendiriliyorsunuz...");
            }
            else
                Console.WriteLine("Bu Sayfayı Görme Yetkiniz Yok!");
        }
    }
}
