namespace _7_ile_bolumundan_kalan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 150; i <= 1000; i++)
            {
                if (i % 7 == 4)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
