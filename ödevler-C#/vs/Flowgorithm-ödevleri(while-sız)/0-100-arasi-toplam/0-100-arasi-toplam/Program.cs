namespace _0_100_arasi_toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 0; i <= 100; i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);  
        }
    }
}
