namespace _20_48_arasindaki_3_ile_tam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carpim = 1;
            for (int i = 20; i <= 48; i++)
            {
                if (i % 3 == 0)
                {
                    carpim *= i;
                }
            }
            Console.WriteLine(carpim);
        }
    }
}
