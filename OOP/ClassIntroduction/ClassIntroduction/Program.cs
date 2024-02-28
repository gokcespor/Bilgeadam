namespace ClassIntroduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek
            Person person1 = new Person();
            person1.Id = 1;
            person1.FirstName = "Gökçe";
            person1.LastName = "Spor Alagöz";
            person1.Age = 32;
            person1.TC = "123456789";
            person1.Weight = 57;
            person1.Height = 155;

            //Console.WriteLine($"Id: {person1.Id}\nFrist Name: {person1.FirstName}\nLast Name: {person1.LastName}\nAge: {person1.Age}\nTc: {person1.TC}\nWeight: {person1.Weight}\nHeight: {person1.Height}");
            Person person2 = new Person();
            person2.Id = 2;
            person2.FirstName = "Melis Su";
            person2.LastName = "Baysal";
            person2.Age = 23;
            person2.TC = "987654";
            person2.Weight = 45;
            person2.Height = 120;

            Console.WriteLine("-----------------------------------------");

            //Console.WriteLine($"Id: {person2.Id}\nFrist Name: {person2.FirstName}\nLast Name: {person2.LastName}\nAge: {person2.Age}\nTc: {person2.TC}\nWeight: {person2.Weight}\nHeight: {person2.Height}");
            Person person3 = new Person();
            person3.Id = 3;
            person3.FirstName = "Sina Emre";
            person3.LastName = "Bekar";
            person3.Age = 28;
            person3.TC = "567890";
            person3.Weight = 78;
            person3.Height = 175;

            Console.WriteLine("-----------------------------------------");

            //Console.WriteLine($"Id: {person3.Id}\nFrist Name: {person3.FirstName}\nLast Name: {person3.LastName}\nAge: {person3.Age}\nTc: {person3.TC}\nWeight: {person3.Weight}\nHeight: {person3.Height}");

            Person person4 = new Person();
            person4.Id = 4;
            person4.FirstName = "Falanca";
            person4.LastName = "Filanca";
            person4.Age = 12;
            person4.TC = "567890";
            person4.Weight = 89;
            person4.Height = 120;

            Console.WriteLine("-----------------------------------------");

            //Console.WriteLine($"Id: {person4.Id}\nFrist Name: {person4.FirstName}\nLast Name: {person4.LastName}\nAge: {person4.Age}\nTc: {person4.TC}\nWeight: {person4.Weight}\nHeight: {person4.Height}");

            List<Person> people = new List<Person> { person1, person2, person3, person4 };

            foreach (Person person in people)
            {
                Console.WriteLine($"Id: {person.Id}\nFrist Name: {person.FirstName}\nLast Name: {person.LastName}\nAge: {person.Age}\nTc: {person.TC}\nWeight: {person.Weight}\nHeight: {person.Height}");
            }
            #endregion

            #region Nesne Üretme Mantığı



            //Null referansı
            Person p; //Burada stack alanında bi pointer ekliyoruz fakat kendisinin herhangi bir referansı yok.
            p = null; //Burada referansının null olduğunu söylüyoruz.
            p.FirstName = "Sina"; //Referansına null verdikten sonra property'lerine birşeyler ekleme isterseni NULLReferenceException hatasını fırlatır. O yüzden kod çalışmaz.

            Nesne Üretme(New'leme ile)
            Person p;//Burada önce Stack alanına pointer ekledik. 
            new Person();  //Daha sonra heap alanında bir yer açtık.(Instance işlemi)

            p = new Person(); //Daha sonra heap alanında açtığımız alanın referansını "p" pointer'ına verdik.

            p.FirstName = "Sina"; //Ve artık property'lerine değer atayabiliriyoruz.

            p = new Person(); //Tekrar new'leme işlemi yaptığımızda 63. satırdaki new'lemede üretilen HEAP alanının içindeki yer Garbage Collector tarafından silinir.(Stack alanında referansı olmadığı için!)

            Nesne Üretme(Method ile)
            Person p = CreatePerson(); //Burada ise nesne üretimini bir method aracılığuı ile gerçekleştirdik. Methodun içinde üretilen "person" pointer'ını işaret ettiği HEAP alanındaki yer burada ki "p" pointerına atanır ve "person" pointer'ı silinir.
            Console.WriteLine(p.GetHashCode()); //Burada ise RAM'da referans verdiği noktanın adresini görüntülüyebiliyoruz.(GetHashCode methodu ile.)
            #endregion


        }

        static Person CreatePerson()
        {
            Person person = new Person() { Id = 1, FirstName = "Sina", LastName = "Emre", Age = 28, Height = 176, Weight = 94, TC = "56455444" };
            return person;

        }
    }
}
