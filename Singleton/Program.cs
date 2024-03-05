using Singleton.Concrete;

#region Normal Nesne Üretimi
//Person person = new Person();
//Person person2 = new Person();
//Person person3 = new Person();

//// Buradaki HasCode ların (RAM deki adresleri) hepsi birbirinden farklıdır. Çünkü bunlar farklı nesnelerdir.
//Console.WriteLine("1 => " + person.GetHashCode());
//Console.WriteLine("1 => " + person2.GetHashCode());
//Console.WriteLine("1 => " + person3.GetHashCode());
#endregion

#region Sigleton Nesne Üretimi
Person person = Person.CreatePerson();
Person person2 = Person.CreatePerson();
Person person3 = Person.CreatePerson();

// Buradaki HasCode ların (RAM deki adresleri) hepsi birbirinin aynısıdır.. Çünkü bunlar tek bir nesnelerdir.
Console.WriteLine("1 => " + person.GetHashCode());
Console.WriteLine("1 => " + person2.GetHashCode());
Console.WriteLine("1 => " + person3.GetHashCode());
#endregion