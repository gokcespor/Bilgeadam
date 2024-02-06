namespace kare_alani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar, alan;
            Console.WriteLine("Kenar uzunluğu giriniz:");
            kenar = Convert.ToInt32(Console.ReadLine());
            alan = kenar * kenar;
            Console.WriteLine(alan);
        }
    }
}
