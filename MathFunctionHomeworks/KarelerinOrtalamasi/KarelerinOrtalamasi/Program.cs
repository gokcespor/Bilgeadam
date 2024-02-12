namespace KarelerinOrtalamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adet = 0;
            double kare;
            double sayi = 0;
            double ort = 0;
            double toplam = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                kare = Math.Pow(sayi, 2);
                toplam += kare;
                adet++;
            }
            ort = toplam / adet;
            Console.WriteLine($"Girilen sayıların kareleri ortalaması: {ort}");
        }
    }
}
