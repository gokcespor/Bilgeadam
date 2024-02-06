namespace n_sayisina_kadar_olan_sayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Lütfen bir sayı giriniz:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
