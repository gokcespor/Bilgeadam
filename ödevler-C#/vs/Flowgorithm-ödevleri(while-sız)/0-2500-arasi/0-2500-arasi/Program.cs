namespace _0_2500_arasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 0; i <= 2500; i++)
            {
                if (i % 4 == 0 && i % 3 == 2)
                {
                    toplam += i;
                }   
            }
            Console.WriteLine(toplam);
        }
    }
}
