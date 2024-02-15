namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba("Wolkswagen", "Gold TSI", 2.0);

            Araba araba2 = new Araba();
            araba2.Marka = "Audi";
            araba2.Model = "A3 Sedan";
            araba2.Motor = 1.5;
        }
    }
}
