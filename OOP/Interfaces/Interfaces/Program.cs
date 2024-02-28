using Interfaces.Models.Concrete;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Defans defans = new Defans();
            defans.AdiSoyadi = "Fabio Luciano";
            defans.SutGucu = 60;
            defans.Refleks = 75;
            defans.Agresiflik = 95;
            defans.FormaNumarasi = 3;
            defans.Hiz = 65;

            Console.WriteLine($"Futbolcu: {defans.AdiSoyadi}\nŞut Gücü: {defans.SutGucu}\nRefleks: {defans.Refleks}\nAgresiflik: {defans.Agresiflik}\nForma Numarası: {defans.FormaNumarasi}\nHız: {defans.Hiz}");
            Console.WriteLine(defans.ToString());
            Console.WriteLine("====================");

            OrtaSaha ortasaha = new OrtaSaha();
            ortasaha.AdiSoyadi = "Gökçe Spor Alagöz";
            ortasaha.SutGucu = 59;
            ortasaha.Refleks = 65;
            ortasaha.Agresiflik = 90;
            ortasaha.FormaNumarasi = 10;
            ortasaha.Hiz = 100;

            Console.WriteLine(ortasaha.ToString());
            ortasaha.SutCek();
            ortasaha.TopKurtar();
            Console.WriteLine("====================");

            Forvet forvet = new Forvet();
            forvet.AdiSoyadi = "Melis Su Baysal";
            forvet.SutGucu = 100;
            forvet.Refleks = 50;
            forvet.Agresiflik = 200;
            forvet.FormaNumarasi = 20;
            forvet.Hiz = 200;

            Console.WriteLine(forvet.ToString());
            forvet.SutCek();
            forvet.TopKurtar();
            Console.WriteLine("====================");

            Kaleci kaleci = new Kaleci();
            kaleci.AdiSoyadi = "Rüştü Reçber";
            kaleci.SutGucu = 90;
            kaleci.Refleks = 50;
            kaleci.Agresiflik = 200;
            kaleci.FormaNumarasi = 20;
            kaleci.Hiz = 200;

            Console.WriteLine(kaleci.ToString());
            kaleci.SutCek();
            kaleci.TopKurtar();
        }
    }
}
