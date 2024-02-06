namespace dikdortgen_cevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar1, kenar2, cevre = 0;
            Console.WriteLine("Uzun ve kısa kenarı giriniz:");
            kenar1 = Convert.ToInt32(Console.ReadLine());
            kenar2 = Convert.ToInt32(Console.ReadLine());
            cevre = 2 * (kenar1 + kenar2);
            Console.WriteLine(cevre);
        }
    }
}
