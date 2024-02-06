namespace cift_tek_sifir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Lütfen sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                if (sayi == 0) 
                {
                    Console.WriteLine("Sayı sıfırdır.");
                }
                else
                {
                    Console.WriteLine("Sayı çifttir.");
                }
            }
            else
            {
                    Console.WriteLine("Sayı tektir.");
            }
        }
    }
}
