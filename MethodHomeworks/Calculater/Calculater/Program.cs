namespace Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            try
            {
                Console.Write("Sayı giriniz: ");
                double sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sayı giriniz: ");
                double sayi2 = Convert.ToInt32(Console.ReadLine());

                double toplam = Topla(sayi1, sayi2);
                double cikar = Cikar(sayi1, sayi2);
                double carp = Carp(sayi1, sayi2);
                double bol = Bol(sayi1, sayi2);
                Console.WriteLine(toplam);
                Console.WriteLine(cikar);
                Console.WriteLine(carp);
                Console.WriteLine(bol);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            double Topla(double number1, double number2)
            {
                double top = 0;
                top = number1 + number2;
                return top;
            }
            double Cikar(double number1, double number2)
            {
                double cikar = 0;
                cikar = number1 - number2;
                return cikar;
            }
            double Carp(double number1, double number2)
            {
                double carp = 1;
                carp = number1 * number2;
                return carp;
            }
            double Bol(double number1, double number2)
            {
                double bol = 1;
                bol = number1 / number2;
                return bol;
            }
            #endregion
        }
    }
}
