namespace KareninAlani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kenar uzunluğu giriniz: ");
            int kenar = Convert.ToInt32(Console.ReadLine());
            double alan = Math.Pow(kenar, 2);
            Console.WriteLine($"Karenin alanı: {alan}");
        }
    }
}
