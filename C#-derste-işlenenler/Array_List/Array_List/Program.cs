using System.Collections;

namespace Array_List
{
    internal class Program
    {
        /*
         * Array List
         * Şu zamana kadar gördüğümüz ilkel dizilerin (veritipi[] olarak tamınımlanan) en büyük iki özelliği:
         * TİP BAĞIMLILIĞI VE ELEMAN SAYISI ZORUNLULUĞU
         * 
         * Ancak ArrayList nesnesiyle birlikte bu bağımlılıkları ortadan kalktı. Bir ArrayList i meydana getirirken ne eleman sayısı vermek zorundasın ne de bir veri tipi belitmek zorundasınızdır.
         * 
         * Dezavantajı Nedir?
         * 
         * ArrayList içerisindeki elemanları otomatik olarak object veri tipinde döndürme özelliğine sahiptir. (Bütün veri tiplerinin atası objecttir.) Dolayısıyla bu verileri geri almak istediğinde mecburen bir "cast" ya da "convert" işlemine 
         * (object => bilinene UNBOXING)
         * (bilinenden => object BOXING)
         */
        static void Main(string[] args)
        {
            #region Object
            // object örneği
            //object sayi = 125;
            //object metin = "Sina";
            //object mantik = true;

            //int sonuc = Convert.ToInt32(sayi) * Convert.ToInt32(sayi);  
            #endregion

            #region ArrayList
            ArrayList arrayList = new ArrayList();

            arrayList.Add(125);
            arrayList.Add("Sina Emre Bekar");
            arrayList.Add(true);
            arrayList.Add(new DateTime(2023, 01, 02));
            arrayList.Add(15.43M);
            arrayList.Add(new string[] { "Sina", "Emre", "Bekar" });
            arrayList.Add(new List<int> { 53, 45, 44 });

            //foreach (object item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arrayList[0]);

            //int sonuc = (int)arrayList[0] + 125;  
            //Console.WriteLine(sonuc);

            // while ((bool)arrayList[2]) { }

            // Count => Eleman sayısını verir.
            Console.WriteLine(arrayList.Count);

            // Contains => Var mı yok mu kontrolü
            Console.WriteLine(arrayList.Contains(125) ? "Vardır" : "Yoktur");

            // IndexOf - LastIndexOf
            Console.WriteLine(arrayList.IndexOf(125));
            Console.WriteLine(arrayList.LastIndexOf(125));

            // Insert => Araya eleman ekleme
            arrayList.Insert(3, "Malatya");

            // Remove => Eleman silmek iin ullanılır
            arrayList.Remove("Malatya");

            // TrimToSize => o anki kapasiteyi, o anki eleman sayısınıa eşitler.
            Console.WriteLine("Trimden önce kapasite " + arrayList.Capacity);
            arrayList.TrimToSize();
            Console.WriteLine("Trimden sonra kapasite " + arrayList.Capacity);

            // Clear => Diziyi temizleme
            arrayList.Clear();

            //SORT => Sort un çalışması için tek tip veri olması gerekir
            // arrayList.Sort();

            #endregion

            Console.WriteLine();
            Console.WriteLine("--------------Liste Elemanları---------------");
            Console.WriteLine();
            foreach (object item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
