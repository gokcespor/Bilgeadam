namespace _0_100_arasındaki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 2 && i % 5 == 0)
                {
                    sonuc = i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
