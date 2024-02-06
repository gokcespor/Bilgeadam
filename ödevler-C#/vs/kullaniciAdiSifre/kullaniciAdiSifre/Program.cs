namespace kullaniciAdiSifre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "bilgeadam";
            string sifre = "1234";
            Console.WriteLine("Kullanıcı adınızı giriniz:");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz:");
            sifre = Console.ReadLine();
            switch (kullaniciAdi)
            {
                case ("bilgeadam"):
                    
                    switch (sifre) 
                    {
                        case "1234":
                            Console.WriteLine("Tebrikler, hem kullanıcı adı hemde şifreniz doğru.");
                            break;
                        default:
                            Console.WriteLine("Kullanıcı adınız doğru ancak şifreniz yanlış!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!");
                    break;
            }
        }
    }
}
