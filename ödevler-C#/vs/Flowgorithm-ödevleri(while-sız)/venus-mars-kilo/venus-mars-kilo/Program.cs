namespace venus_mars_kilo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;
            double kilo, sonuc;
            Console.WriteLine("Lütfen kilonuzu giriniz:");
            kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mars kilonuz için 1 e, venüs kilonuz için 2 ye basınız.");
            secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                sonuc = kilo * 0.39;
                Console.WriteLine(sonuc);
            }
            else
            {
                sonuc = kilo * 0.78;
                Console.WriteLine(sonuc);
            }
        }
    }
}
