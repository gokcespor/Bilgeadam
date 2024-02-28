using Zoo.Models.Concrete;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek = new Kopek();
            kopek.YemekYe = "Mama ile beslenir.";
            kopek.Otur = "Köpekler ıslak zeminde oturmaz.";
            kopek.Yuru = 20;
            kopek.Kos = 120;

            Console.WriteLine(kopek.ToString());
            kopek.Oturma();
            kopek.Kosma();

            Console.WriteLine("=============================");

            Kedi kedi = new Kedi();
            kedi.YemekYe = "Islak mama ile beslenir.";
            kedi.Otur = "Kediler çılgınlar gibi miskindir. Oturmayı severler.";
            kedi.Yuru = 30;
            kedi.Kos = 50;

            Console.WriteLine(kedi.ToString());
            kedi.Oturma();
            kedi.Kosma();

            Console.WriteLine("=============================");

            Kus kus = new Kus();
            kus.YemekYe = "Kuşlar doğadan beslenir. Böcek yerler.";
            kus.Otur = "Oturamazlar.";
            kus.Yuru = 10;
            kus.Kos = 220;

            Console.WriteLine(kus.ToString());
            kus.Oturma();
            kus.Kosma();

            Console.WriteLine("=============================");

            Yengec yengec = new Yengec();
            yengec.YemekYe = "Yengeçler deniz canlılarıyla beslenir.";
            yengec.Otur = "Oturamazlar.";
            yengec.Yuru = 5;
            yengec.Kos = 10;

            Console.WriteLine(yengec.ToString());
            yengec.Oturma();
            yengec.Kosma();

            Console.WriteLine("=============================");

            Tavsan tavsan = new Tavsan();
            tavsan.YemekYe = "Marul yemeyi çok severler";
            tavsan.Otur = "Miskinlik yapmak için otururlar.";
            tavsan.Yuru = 25;
            tavsan.Kos = 50;

            Console.WriteLine(tavsan.ToString());
            tavsan.Oturma();
            tavsan.Kosma();
        }
    }
}
