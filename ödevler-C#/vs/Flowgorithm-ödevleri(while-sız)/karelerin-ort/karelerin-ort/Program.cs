namespace karelerin_ort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, kare, toplam = 0, adet = 0, ort;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                kare = sayi * sayi;
                toplam += kare;
                adet += 1;
            }
            ort = toplam / adet;
            Console.WriteLine(ort);
        }
    }
}
