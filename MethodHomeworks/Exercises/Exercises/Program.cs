namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // random sayı al 50 tane 0-100 arası, en büyük bul, en küçüğünü bul, ortanca bul, bir tane string dizi aç, string ifadeyi char dizisine aktar.
            #region random
            //int[] randomSayi = new int[50];
            //int enBuyukSayi = 0;
            //int enKucukSayi = 100;
            //double ortancaSayi = 0;

            //Random random = new Random();
            //for (int i = 0; i < 50; i++)
            //{
            //    randomSayi[i] = random.Next(0, 100);
            //    if (randomSayi[i] > enBuyukSayi)
            //    {
            //        enBuyukSayi = randomSayi[i];
            //    }
            //    else if (randomSayi[i] <= enKucukSayi)
            //    {
            //        enKucukSayi = randomSayi[i];
            //    }
            //}
            //Array.Sort(randomSayi);

            //int ortaIndex1 = randomSayi.Length / 2 - 1;
            //int ortaIndex2 = randomSayi.Length / 2;
            //ortancaSayi = (randomSayi[ortaIndex1] + randomSayi[ortaIndex2]) / 2.0;
            //foreach (var item in randomSayi)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"En büyük sayı: {enBuyukSayi}\nEn küçük sayı: {enKucukSayi}\nOrtanca sayI: {ortancaSayi}");
            #endregion

            #region string

            string[] kelime = new string[1] ;

            Console.Write("Bir kelime giriniz: ");
            kelime[0] = Console.ReadLine();

            char[] harf = kelime[0].ToCharArray();
            

            foreach (var item in harf)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
