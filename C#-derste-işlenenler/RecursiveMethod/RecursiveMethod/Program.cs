namespace RecursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnekli Anlatım
            // Verdiğiniz sayının faktoriyelini yapan methodu yazınız.
            //Console.WriteLine(Faktoriyel(5));
            //Console.WriteLine(FaktoriyelRecursive(5));

            //int Faktoriyel(int sayi)
            //{
            //    int carpim = 1;
            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        carpim = carpim * i;
            //    }
            //    return carpim;

            //}


            //int FaktoriyelRecursive(int sayi) // Her turda sayının bir eksiğini tekrar methodun kendisine gönderdik ve bitiş noktası olarak da 1 i belirledik. sayi değişkeni 1 e ulaştığında return 1 diyerek döngünün sonlanmasını sağladık.
            //{
            //    if (sayi == 1)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //    return sayi * FaktoriyelRecursive(sayi - 1);
            //    }
            //}
            #endregion

            #region Soru
            // Fibonacci dizisinin istenilen basamağını önce normal method ile daha sonra da recursive method ile gösteriniz.


            // Benim yaptığım
            //Fibonacci();
            //void Fibonacci()
            //{
            //    int sayi1 = 0;
            //    int sayi2 = 1;

            //    Console.WriteLine("Sayı giriniz: ");
            //    int basamak = Convert.ToInt32(Console.ReadLine());

            //    int toplam = 0;
            //    for (int i = 0; i < basamak; i++)
            //    {
            //        toplam = sayi1 + sayi2;
            //        sayi2 = sayi1;
            //        sayi1 = toplam;
            //    }
            //    Console.WriteLine(toplam);
            //}


            // Hocanın yaptığı

            Console.WriteLine(Fibonacchi(5));
            //Örnek çıktı: 5

            long Fibonacchi(int sayi)
            {
                if (sayi < 2)
                {
                    return 1;
                }
                long[] f = new long[sayi + 1];
                f[0] = 0;
                f[1] = 1;



                for (int i = 2; i <= sayi; i++)
                {
                    f[i] = f[i - 2] + f[i - 1];
                }



                return f[sayi];
            }



            long Fibonacci(int sayi)
            {
                if (sayi < 2)
                {
                    return 1;
                }
                long[] f = new long[sayi + 1];
                f[0] = 0;
                f[1] = 1;



                for (int i = 2; i <= sayi; i++)
                {
                    f[i] = f[i - 2] + f[i - 1];
                }



                return f[sayi];
            }


            // Recursive üzerinden
            long FibonacciRecursive(int sayi)
            {
                if (sayi < 2)
                    return sayi;



                return FibonacciRecursive(sayi - 1) + FibonacciRecursive(sayi - 2);
            }




            #endregion
        }
    }
}
