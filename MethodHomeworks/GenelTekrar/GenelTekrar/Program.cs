using System.Threading.Channels;

namespace GenelTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Bir sayı giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());


                Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
                int islem = Convert.ToInt32(Console.ReadLine());


                switch (islem)
                {
                    case 1:
                        Console.Write($"İşlemin sonucu: {Topla(sayi1, sayi2)}");
                        break;
                    case 2:
                        Console.Write($"İşlemin sonucu: {Cikar(sayi1, sayi2)}");
                        break;
                    case 3:
                        Console.Write($"İşlemin sonucu: {Carp(sayi1, sayi2)}");
                        break;
                    case 4:
                        Console.Write($"İşlemin sonucu: {Bol(sayi1, sayi2)}");
                        break;
                    case 5:
                        Console.Write($"İşlemin sonucu: {Mod(sayi1, sayi2)}");
                        break;
                    default:
                        Console.WriteLine("Hatalı işlem yaptınız!!");
                        break;
                }


                double Topla(double number1, double number2)
                {
                    double sonuc = number1 + number2;
                    return sonuc;
                }
                double Cikar(double number1, double number2)
                {
                    double sonuc = number1 - number2;
                    return sonuc;
                }
                double Carp(double number1, double number2)
                {
                    double sonuc = number1 * number2;
                    return sonuc;
                }
                double Bol(double number1, double number2)
                {
                    double sonuc = number1 / number2;
                    return sonuc;
                }
                double Mod(double number1, double number2)
                {
                    double sonuc = number1 % number2;
                    return sonuc;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        
        }
    }
}
