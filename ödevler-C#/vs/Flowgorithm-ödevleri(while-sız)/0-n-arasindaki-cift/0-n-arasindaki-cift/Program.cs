namespace _0_n_arasindaki_cift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
