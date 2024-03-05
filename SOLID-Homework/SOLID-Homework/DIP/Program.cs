using DIP.Concrete;

Hastane hastane1 = new Hastane(new Cerrahi());
Hastane hastane2 = new Hastane(new Pediatri());

Console.WriteLine(hastane1.DepartmanInfo());
Console.WriteLine(hastane2.DepartmanInfo());