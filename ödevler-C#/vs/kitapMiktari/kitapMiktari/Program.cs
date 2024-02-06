namespace kitapMiktari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kitabinFiyati = 5;
            double odenecek = 0;
            Console.WriteLine("Sipariş edilecek kitap sayısını giriniz: ");
            int kitapSayisi = Convert.ToInt32(Console.ReadLine());
            if (kitapSayisi < 20)
            {
                odenecek = (kitapSayisi * kitabinFiyati) - (kitapSayisi * kitabinFiyati) * 0.05;
                Console.WriteLine("Ödeyeceğiniz ücret: " + odenecek);
            }
            else if (kitapSayisi >= 20 && kitapSayisi < 50)
            {
                odenecek = (kitapSayisi * kitabinFiyati) - (kitapSayisi * kitabinFiyati) * 0.1;
                Console.WriteLine("Ödeyeceğiniz ücret: " + odenecek);
            }
            else if (kitapSayisi >= 50 && kitapSayisi < 100)
            {
                odenecek = (kitapSayisi * kitabinFiyati) - (kitapSayisi * kitabinFiyati) * 0.15;
                Console.WriteLine("Ödeyeceğiniz ücret: " + odenecek);
            }
            else
            {
                odenecek = (kitapSayisi * kitabinFiyati) - (kitapSayisi * kitabinFiyati) * 0.25;
                Console.WriteLine("Ödeyeceğiniz ücret: " + odenecek);
            }
        }
    }
}
