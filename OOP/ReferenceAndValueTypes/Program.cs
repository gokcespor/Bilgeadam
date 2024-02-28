namespace ReferenceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Type
            //int a = 5;
            //int b = a;
            //b = b + 10;

            //Console.WriteLine(a);

            Student student1 = new Student();
            student1.FirstName = "Sina";
            student1.LastName = "Emre";

            Student student2 = student1;
            student2.FirstName = "Mahmut";

            Console.WriteLine(student1.FirstName);

            Console.WriteLine($"Student1 Adres => {student1.GetHashCode()}\nStudent2 Adres => {student2.GetHashCode()}");

            #endregion

            #region Reference Type
            //int[] sayilar1 = { 12, 14, 16 };
            //int[] sayilar2 = sayilar1;
            //sayilar2[1] = 24;

            //Console.WriteLine(sayilar1[1]);

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Sina";
            ogrenci1.Soyad = "Emre";

            Ogrenci ogrenci2 = ogrenci1;
            ogrenci2.Ad = "Mahmut";

            Console.WriteLine(ogrenci1.Ad);

            Console.WriteLine($"Öğrenci1 Adres => {ogrenci1.GetHashCode()}\nÖğrenci2 Adres => {ogrenci2.GetHashCode()}");
            #endregion
        }

    }
}
