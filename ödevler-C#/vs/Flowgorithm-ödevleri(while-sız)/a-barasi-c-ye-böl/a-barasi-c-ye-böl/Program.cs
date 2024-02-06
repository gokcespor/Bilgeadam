namespace a_barasi_c_ye_böl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, toplam = 0;
            Console.WriteLine("Başlangıç değeri giriniz:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş değeri giriniz:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bölen giriniz:");
            c = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % c == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine(toplam);
        }
    }
}
