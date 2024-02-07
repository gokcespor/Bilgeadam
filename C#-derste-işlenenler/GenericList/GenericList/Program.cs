namespace GenericList
{
    internal class Program
    {

        // List<> içerisine (<T>) verilen tipe bürünerek, o tipte bir koleksiyon oluşturmanıza olanak sağlayan dizi çeşididir. Daha önceki diziler gibi boyut arttırma işlemine gerek kalmadan eleman ekleyebildiğimiz ve Array sınıfını kullanmanıza gerek kalmadan üzerinde işlem yapabildiğimiz gelişmiş sınıftır.
        static void Main(string[] args)
        {
            #region
            //List<int> sayilar = new List<int>(); 
            //sayilar.Add(1);
            //sayilar.Add(2);
            //sayilar.Add(3);
            //sayilar.Add(4);
            //sayilar.Add(5);

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };   

            //List<string> sehirler = new List<string> { "Ankara", "İstanbul", "İzmir" };

            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            #endregion

            #region Calisma
            // Kullanıcıdan 5 adet isim isteyip bunu bir listeye aktatrıp tekrar kullanıcıya gösteriniz.

            //List<string> isimler = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("İsim giriniz: ");
            //    string isim = Console.ReadLine();
            //    isimler.Add(isim);
            //}

            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    Console.WriteLine($"Kayıtlı kişi {i+1}: {isimler[i]}");
            //}
            #endregion

            #region Calisma 2
            // 0 ile 100 arasında sayıları bir listeye aktarın ve gösterin.

            List<int> sayilar = new List<int>();

            for (int i = 0; i < 101; i++)
            {
                sayilar.Add(i);
            }
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine($"Sayılar: {sayilar[i]}");
            }
            #endregion

            
        }
    }
}
