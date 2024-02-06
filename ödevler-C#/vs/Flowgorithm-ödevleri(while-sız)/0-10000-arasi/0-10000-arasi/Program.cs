namespace _0_10000_arasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            for (int i = 0; i <= 10000; i++)
            {
                if (i % 10 == 4 && i % 4 == 2)
                {
                    sonuc = i;
                    Console.WriteLine(sonuc);
                }
            }
        }
    }
}
