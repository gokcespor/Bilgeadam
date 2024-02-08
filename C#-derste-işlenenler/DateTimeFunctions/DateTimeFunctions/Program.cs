namespace DateTimeFunctions
{
    internal class Program
    {
        // DATETIME => Zamanla ilgili yapabileceğimiz tüm işlemleri ve tüm verileri size teslim eden nesnemizdir.
        static void Main(string[] args)
        {
            // Günün tarihini ve şu anki saati alma
            Console.WriteLine(DateTime.Now);

            // Şu anki tarihi alma
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            // Şu anki saati alma
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            // Tarih formatlama
            Console.WriteLine(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);

            // Artık Yıl (Leap Year)
            bool isLeapYear = DateTime.IsLeapYear(2024);
            Console.WriteLine(isLeapYear ? "This is leap year" : "This isn't leap year!");

            // Haftanın Günü
            string haftaninGunu = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(haftaninGunu);

            // Yılın kaçıncı günü
            string yilinKacinciGunu = DateTime.Now.DayOfYear.ToString();
            Console.WriteLine("Bugün yılın " + yilinKacinciGunu + ". günüdür.");

            // TimeSpan
            // İki zaman arasındaki farkı alıp size veren nesnedir
            DateTime yeniZaman = new DateTime(1991, 05, 22, 14, 30, 00);
            DateTime bugun = DateTime.Now;

            TimeSpan zamanFarki = bugun - yeniZaman;
            int toplamGun = Convert.ToInt32(zamanFarki.TotalDays);
            Console.WriteLine("siz toplam " + toplamGun + " gündür yaşıyorsunuz.");



        }
    }
}
