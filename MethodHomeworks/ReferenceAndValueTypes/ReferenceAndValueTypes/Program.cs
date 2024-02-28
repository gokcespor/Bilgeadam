namespace ReferenceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Type
            Student student1 = new Student();
            student1.FirstName = "Sina";
            student1.LastName = "Emre";

            Student student2 = student1;
            student2.FirstName = "Mahmut";
            Console.WriteLine(student1.FirstName);

            Console.WriteLine($"Student1 adres: {student1.GetHashCode()}\nStudent2 adres: {student2.GetHashCode()}");

            #endregion

            #region Reference Type
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Sina";
            ogrenci1.Soyad = "Emre";

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Ad = "Mahmut";

            Console.WriteLine(ogrenci1.Ad);

            Console.WriteLine($"Öğrenci1 adres: {ogrenci1.GetHashCode()}\nÖğrenci2 adres: {ogrenci2.GetHashCode()}");

            #endregion
        }
    }
}
