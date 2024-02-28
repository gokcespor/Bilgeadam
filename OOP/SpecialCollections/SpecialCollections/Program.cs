using System.Collections;
using System.Collections.Specialized;

namespace SpecialCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hashtable
            // Anahtar-Değer ikili mantığı ile (key-value pair) çalışan özel bir koleksiyon tipidir. Hashtable veri olarak anahtar ve değer kısımlarını "object" tipinde veri alır.

            // Genellikle büyük boyutlu koleksiyonlar için kullanılmaktadır. (Ornek Nortwind veri tabanındaki Orders tablosu)

            // Hashtable, içerisindeki değerleri RAM deki referans değerlerine göre sıralar.
            // Hashtable daki key mantığı gerçek bir key mantığıdır. Unique olmak zorundadır ve kullanılan bir değer bir daha asla kullanılmaz.

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("isim", "Gökçe");
            //hashtable.Add(5, 25);
            //hashtable.Add(3, "Spor Alagöz");
            //hashtable.Add(DateTime.Now.Minute, DateTime.Now.AddDays(-3).Date);

            //Değer Çekmek
            //Console.WriteLine(hashtable["isim"]);
            //Console.WriteLine(hashtable[DateTime.Now.Minute]);

            //Silme
            //hashtable.Remove(5);

            //Var mı diye kontrol etme
            //if (hashtable.ContainsKey(15))
            //{
            //    Console.WriteLine("15 numaralı key doludur.");
            //}
            //else
            //{
            //    hashtable[15] = "Alex De Souza";
            //}

            //foreach (var key in hashtable.Keys)
            //{
            //    Console.WriteLine(string.Format("Anahtar: {0} - Değer: {1}", key, hashtable[key]));
            //    Console.WriteLine($"Anahtar: {key} - Değer: {hashtable[key]}");
            //}
            #endregion

            #region ListDictionary
            // Bu koleksiyon Hashtable dan daha az gelişmiş bir özel koleksiyon tipidir. Tıpkı hashtable gibi bu da key-value pair mantığıyla çalışır.
            // Daha az gelişmesine örnek olarak ContainsKey ya da ContainsValue gibi methodların bu koleksiyon içerisinde bulunmaması örnek gösterilebilir.
            //ListDictionary listDictionary = new ListDictionary();
            //listDictionary.Add(1, "İstanbul");
            //listDictionary.Add(2, "Ankara");
            //listDictionary.Add(3, "İzmir");
            //listDictionary.Add(4, "Bursa");
            //listDictionary.Add(5, "Eskişehir");
            //listDictionary.Add(6, "İzmit");
            //listDictionary.Add(7, "Gebze");
            //listDictionary.Add(8, "Karabük");
            //listDictionary.Add(9, "Malatya");
            //listDictionary.Add(10, "Şırnak");
            //listDictionary.Add(11, "Adıyaman");
            //listDictionary.Add(12, "Bolu");

            //foreach (var key in listDictionary.Keys)
            //{
            //    Console.WriteLine(string.Format("{0} - {1}", key, listDictionary[key]));
            //    Console.WriteLine($"{key} - {listDictionary[key]}");
            //}
            #endregion

            #region HybridDictinoary
            // Hashtable ve ListDictionary mantığı gibi key-value mantığı ile çalışır.
            // Ancak MSDN in söylediğine göre eğer koleksiyonunuz küçükse (eleman sayısı 10 ve altındaysa) ListDictionary olarak davranır, eleman sayısı 10 un üzerinde çıktığı anda kendini Hashtable a döndürür.
            // Koleksiyonunuz büyüklüğüne göre yapacağınız doğru bir koleksiyon seçimi size performans olarak geri döner.

            HybridDictionary hybridDictionary = new HybridDictionary();
            hybridDictionary.Add(1, "İstanbul");
            hybridDictionary.Add(2, "Ankara");
            hybridDictionary.Add(3, "İzmir");
            hybridDictionary.Add(4, "Bursa");
            hybridDictionary.Add(5, "Eskişehir");
            hybridDictionary.Add(6, "İzmit");
            hybridDictionary.Add(7, "Gebze");
            hybridDictionary.Add(8, "Karabük");

            // 9 a geçtiği an Hashtable gibi davranır sıralamasını ona göre düzenler.
            //hybridDictionary.Add(9, "Malatya");

            foreach (var key in hybridDictionary.Keys)
            {
                Console.WriteLine(string.Format("{0} - {1}", key, hybridDictionary[key]));
            }

            #endregion
        }
    }
}
