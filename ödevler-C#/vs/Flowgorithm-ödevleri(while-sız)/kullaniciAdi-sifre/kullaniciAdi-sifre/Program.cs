namespace kullaniciAdi_sifre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi, sifre;
            Console.WriteLine("Kullanıcı adı giriniz:");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz:");
            sifre = Console.ReadLine();
            if (kullaniciAdi == "bilgeadam" && sifre == "1234")
            {
                Console.WriteLine("Hoşgeldin Admin!");
            }
            else
                Console.WriteLine("Kullanıcı adı veya şifre yanlış!");
        }
    }
}
