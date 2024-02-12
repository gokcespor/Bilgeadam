namespace DaireninAlani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yarıçap uzunluğu giriniz: ");
            double yariCap = Convert.ToDouble(Console.ReadLine());
            double alan = Math.PI * Math.Pow(yariCap, 2);
            Console.WriteLine($"Dairenin alanı: {alan}");
        }
    }
}
