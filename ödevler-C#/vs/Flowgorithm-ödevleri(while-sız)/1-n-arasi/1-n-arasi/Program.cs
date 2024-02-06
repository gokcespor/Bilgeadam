namespace _1_n_arasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, n;
            Console.WriteLine("Lütfen bir sayı giriniz:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 2)
                {
                    toplam += i;
                }
            }
            Console.WriteLine(toplam);
        }
    }
}
