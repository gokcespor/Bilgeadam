using System.ComponentModel;

namespace ArrayClass
{
    internal class Program
    {
        /*
         * ARRAY CLASS
         * Şu ana dek görmüş olduğumuz ilkel diziler bize üzerinde çok fazla işlem yapma olanağı sağlamamaktadır. Eğer diziyi tekrar boyutlandırmak, sıralamak, temizlemek, tersine çevirmek gibi temel işlemler yapmak istiyorsanız Array sınıfı size yardımcı olacaktır.
         */


        static void Main(string[] args)
        {
            string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Bursa", "Eskişehir", "Konya", "Trabzon", "Sivas", "Eskişehir"};
            // 1. Parametre Kaynak Dizi
            // 2. Parametre Başlanacak index değeri
            // 3. Parametre Kendisi dahil kaç adet silecek
            #region Array.Clear()
            // Diziden eleman silmek için kullanılır.
            //Array.Clear(sehirler, 2, 3);

            // Dizinin tamamını temizleme
            //Array.Clear(sehirler);

            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            #endregion

            #region Array.Copy()
            // Bir diziden başka bir diziye eleman kopyalamak için kullanılır
            //string[] yeniSehirler = new string[4];


            // 1. ve 2. overload

            //Array.Copy(sehirler, yeniSehirler, 4);
            // 1. Parametre Kaynak dizi
            // 2. parametre hedef dizi
            // 3. parametre kaç adet kopyalayacak


            //Array.Copy(sehirler, 0, yeniSehirler, 0, 4);
            // 1. Parametre Kaynak dizi
            // 2. parametre kaynak dizinin kaçıncı index ninden kopyalamaya başlanır.
            // 3. parametre hedef dizi
            // 4. Parametre hedef dizinin kaçıncı index ine kopyalama gerçekleşecek
            // 5. Parametre kaç adet kopyalanacak

            //foreach (string sehir in yeniSehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            #endregion

            #region Array.IndexOf()
            //// Dizide aradığınız elemanın index numarasını döndüren methodtur. eğer elamna aradığınız değer dizi içerisinde mevcut değilse size -1 döner. Eğer eleman dizi içerisinde iki defa geçiyorsa size ilk elemanın index ini döndürecektir.
            //Console.WriteLine("Şehir girin: ");
            //string gelenDeger = Console.ReadLine();
            //int index = Array.IndexOf(sehirler, gelenDeger);

            // 1. Overload
            // 1. Parametre Kaynak Dizi
            // 2. Parametre Hedef dizi
            // 3. Parametre Başlangıç index i

            //int index = Array.IndexOf(sehirler, gelenDeger, 6);

            //Console.WriteLine(index);
            //Console.WriteLine(index < 0 ? "Aradığınız eleman dizi içerisinde yer almamaktadır." : $"Aradığınız eleman index numarası : {index}" );


            #endregion

            #region Array.LastIndexOf()
            // Dizide aradığınız elemanın index numarasını döndüren methodtur. Eğer eleman aradığınız değer dizi içerisinde mevcut değilse size -1 döner. Eğer eleman dizi içerisinde iki defa geçiyorsa size ilk elemanın index ini döndürecektir.
            //Console.WriteLine("Şehir girin: ");
            //string gelenDeger = Console.ReadLine();
            //int index = Array.LastIndexOf(sehirler, gelenDeger);
            // 1. Overload
            // 1. Parametre Kaynak Dizi
            // 2. Parametre Hedef dizi
            // 3. Parametre Başlangıç index i

            //index = Array.LastIndexOf(sehirler, gelenDeger, 6);
            //Console.WriteLine(index);

            //Console.WriteLine(index < 0 ? "Aradığınız eleman dizi içerisinde yer almamaktadır." : $"Aradığınız eleman index numarası : {index}");
            #endregion


            #region Soru
            // Bir eleman bir defa mı birden çok defa mı dizinin içinde olduğunu kullanıcıya söyleyin

            
            //Console.WriteLine("Şehir adı giriniz:");
            //string gelenSehir = Console.ReadLine();
            //int index1 = Array.IndexOf(sehirler, gelenSehir);
            //int index2 = Array.LastIndexOf(sehirler, gelenSehir);
            //if (index1 == index2)
            //{
            //    Console.WriteLine($"{gelenSehir} şehri bir defa geçmektedir");
            //}
            //else if (index1 < 0)
            //{
            //    Console.WriteLine("Böyle bir şehir bulunamadı");
            //}
            //else
            //{
            //    Console.WriteLine($"{gelenSehir} şehri bir çok defa geçmektedir");
            //}


            #endregion

            #region Array.Resize()
            // İlkel dizinin eleman sayısını arttırmak ya da azaltmak için kullanılan methodtur.

            //Console.WriteLine(sehirler.Length);
            //Array.Resize(ref sehirler, 23);
            //Console.WriteLine(sehirler.Length);
            #endregion

            #region Calisma
            // Şehirler dizisine Zonguldak şehrini ekleyin.
            //Array.Resize(ref sehirler, sehirler.Length + 1);

            //sehirler[sehirler.Length - 1] = "Zonguldak";

            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            #endregion

            #region Array.Sort()
            // Dizinizi sıralamak için kullanacağınız methoddur. Elemanların yerini değiştirdiği için indexleri de değişecektir. Sıralama işlemi a- z ye (küçükten büyüğe doğru) gerçekleşecektir.
            // 1.overload
            //Array.Sort(sehirler);

            // 5. overload
            // Array.Sort(sehirler, 2, 5);

            // 1. paramtere kaynak dizi
            // 2. parametre başlangıç index değeri
            // 3. parametre kaç adet sıralanacak


            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            #endregion

            #region Array.Reverse()
            // 1. paramtere kaynak dizi
            // 2. parametre başlangıç index değeri
            // 3. parametre diziyi ters çevirir


            //Array.Reverse(sehirler, 2, 5);

            // Diziyi ters çevirir
            //Array.Reverse(sehirler);
            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            #endregion


            #region Calisma
            // Şehirler dizisinin Z den A ya sıralayın.

            //Array.Sort(sehirler);
            //Array.Reverse(sehirler);
            //foreach (string sehir in sehirler)
            //{
            //   Console.WriteLine(sehir);
            //}
            #endregion



        }
    }
}
