namespace Delegates
{
    public delegate void Giybetci(string mesaj);
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Delegate
             * Bir olay gerçekleştiğinde birden fazla fonksiyonu çağırmak istediğğinizi düşünelim. Örneğin kullanıcı bir düğmeye tıkladığında birden fazla methodun otomatik olarak çağrılmasını istiyorsunuz. Bunun için delegate kullanabilirsiniz. Burada amaç şu: Bir olay olduğunda birden fala yer bu olayı bildirebilmek. Bu olay ile ilgilenenler delegate ile olaydan haberi olur.
             * 
             * ya da 
             * 
             * Temsilci olarak adlandırılabilecek bu yapı, projeyi asıl ayakta tutan nesneleri yormak yerine, onların işlerini üzerine alarak geröekleştirmekten sorumlu olan tiptir. Bu sayede uygulamamızın her bir kolu ü<zerine düşen görevi eksiksiz yerine getirerek daha uzun süreli ve performanslı uygulamalar ortaya koyma şansına sahip olabilirsiniz.
             * 
             * Unutulmaması gereken nokta ise, delegate aslında bir class tır.
             * 
             * delegate tanımlamak için;
             * 
             * 1) 
             */
            Giybetci giybetci = new Giybetci(MeliseSoyle);
            giybetci += YunusEmreyeSoyle;
            giybetci += HocayaSoyle;
            giybetci += GokceyeSoyle;

            string haber = "Gökçe Hanım araba almış. Duydunuz muuuuuuu??";
            giybetci(haber);

            Console.WriteLine();
            Console.WriteLine("==============");
            Console.WriteLine();

            string haber2 = "Hocca gitmiş";
            giybetci(haber2);

            void MeliseSoyle(string mesaj)
            {
                Console.WriteLine("Melis'e şu haber verildi => " + mesaj);
            }
            void YunusEmreyeSoyle(string mesaj)
            {
                Console.WriteLine("Yunu Emre'ye şu haber verildi => " + mesaj);
            }
            void HocayaSoyle(string mesaj)
            {
                Console.WriteLine("Beni karıştırmayın. Bu haberle ilgilenmiyorum. => " + mesaj);
            }
            void GokceyeSoyle(string mesaj)
            {
                Console.WriteLine("Zaten ben aldım. Bana niye söylüyorsunuz. => " + mesaj);
            }
        }
    }
}
