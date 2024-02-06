namespace _20_30_arasindaki_sayi_carpim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carpim = 1;
            for (int i = 20; i <= 30; i++)
            {
                carpim *= i;
            }
            Console.WriteLine(carpim);
        }
    }
}
