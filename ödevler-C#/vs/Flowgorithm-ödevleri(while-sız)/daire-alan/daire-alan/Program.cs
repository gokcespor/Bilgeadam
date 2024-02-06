namespace daire_alan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 3, alan, r;
            Console.WriteLine("Yarıçapı giriniz:");
            r = Convert.ToInt32(Console.ReadLine());
            alan = p * r * r;
            Console.WriteLine(alan);
        }
    }
}
