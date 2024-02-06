namespace a_b_arasi_cift_top
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,toplam = 0;
            Console.WriteLine("Başlangıç değeri giriniz:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş değeri giriniz:");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine(toplam);
        }
    }
}
