namespace ad_soyad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            Console.WriteLine("Lütfen adınızı giriniz:");
            ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz:");
            soyad = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + ad + " " + soyad);
        }
    }
}
