using LINQ_Operations.Infrastructure.Context;
using LINQ_Operations.Infrastructure.ExtensionMethods;
using LINQ_Operations.Models.Abstract;
using LINQ_Operations.Models.Concrete;
using System.Reflection;
#region LINQ
/*
 * LINQ (Dile Entegre Edilmiş Sorgu)
 * 
 * Micosoft tarafından kullanılan ve C# 3.0 ile hayatımıza giren farlı veri kaynaklarından sorgulama yapabilmei için imkan veren kullanışlı bir sorgu dilidir.
 * 
 * Temel olarak iki farklı şeiilde kullanılır.
 * 1) Query Söz Dizimi(from ile başlarr)
 * 2) Method Söz Dizimi
 * 
 * 
 */
// int[] sayilar = { 5, 1, 3, 45, 69, 9, 3, 2 };

//// Query Söz Dizimi
//var kucukSayilar = from sayi in sayilar
//                   where sayi < 5
//                   select sayi;

//// Method Söz Dizimi
//var kucukSayilar2 = sayilar.Where(x => x < 5);
#endregion

#region Select
// Bir tablodan istediğiniz sütunları getirmenizi sağlar.
//using (var db = new AppDbContext())
//{
//    var genres = db.Genres.Select(x => new
//    {
//        x.Id,
//        x.Name,
//        x.CreatedDate,
//        x.Status

//    }
//    ).ToList();

//    foreach (var genre in genres)
//    {
//        Console.WriteLine($"Id: {genre.Id}\nTür Adıı: {genre.Name}\nEkleme Tarihi: {genre.CreatedDate}\nDurum: {(genre.Status == Status.Active ? "Aktif" : (genre.Status == Status.Modified ? "Güncellenmiş" : "Pasif") )}\n=========================");
//    }
//}
#endregion

#region Where - 1
// Fiyatı 60 ile 150 arasındaki kitapları getirelim
//using (var db = new AppDbContext())
//{
//    var books = db.Books.Where(x => x.Price >= 60 && x.Price <= 150)
//        .Select(x => new
//        {
//            x.Id,
//            x.Title,
//            x.Price,
//            x.CreatedDate
//        }).ToList();
//    foreach (var book in books)
//    {
//        Console.WriteLine($"Id: {book.Id}\nKitap: {book.Title}\nFiyat:{book.Price}\nEklenme Tarihi: {book.CreatedDate}\n====================");
//    }
//}
#endregion

#region Where - 2
// Id si 1 ile 5 arasında olan yazarlar
//using (var db = new AppDbContext())
//{
//    var authors = db.Authors.Where(x => x.Id >= 1 && x.Id <=5 )
//        .Select(x => new
//        { 
//            x.Id,
//            x.FirstName,
//            x.LastName,
//            x.FullName,
//            x.CreatedDate,
//            x.Status
//    }).ToList();
//    foreach (var author in authors)
//    {
//        Console.WriteLine($"Id: {author.Id}\nAd: {author.FirstName}\nSoyad: {author.LastName}\nTüm Adı: {author.FullName}\nEklenme Tarihi: {author.CreatedDate}\nDurumu: {author.Status.GetDisplayName()}\n======================");
//    }
//}
#endregion

#region OrderBy - 1
// Id si 1 ile 5 arasında olan yazarları isimlerine göre sıralayalım
// Then By => OrderBy da verdiğiniz sütundaki değerler aynı ise, ThenBy methodunnun içine verdiğiniz sütuna göre sıralar. Aşağıdaki örnek için adları aynı ise soyadına göre sıralar.
//using (var db = new AppDbContext())
//{
//    var authors = db.Authors.Where(x => x.Id >= 1 && x.Id <= 5)
//        .OrderBy(x => x.FirstName).ThenBy(x => x.LastName)
//        .Select(x => new
//        {
//            x.Id, 
//            x.FirstName, 
//            x.LastName, 
//            x.CreatedDate, 
//            x.Status
//        }).ToList();

//    foreach (var author in authors)
//    {
//        Console.WriteLine($"Id: {author.Id}\nYazar: {author.FirstName} {author.LastName}\nEklenme Tarihi: {author.CreatedDate}\nDurum: {author.Status.GetDisplayName()}\n===============");
//    }
//}
#endregion

#region OrderBy - 2
// Fiyatı 60 dan büyük olan kitapları fiyat bilgisine göre azalan şekilde sıralayın
//using (var db = new AppDbContext())
//{
//    var books = db.Books.Where(x => x.Price >= 60)
//        .OrderByDescending(x => x.Price)
//        .Select(x => new
//        {
//            x.Id,
//            x.Title,
//            x.Price,
//            x.CreatedDate,
//            x.Status
//        }).ToList();
//    foreach (var book in books)
//    {
//        Console.WriteLine($"Id: {book.Id}\nKitabın Adı: {book.Title}\nFiyatı: {book.Price}\nEklenme Tarihi: {book.CreatedDate}\nDurum: {book.Status.GetDisplayName()}\n===============");
//    }
//}
#endregion

#region First - 1
// Kitap tablosundaki 1. kaydı getirelim
//using (var db = new AppDbContext())
//{
//    var book = db.Books.First();
//    Console.WriteLine($"Id: {book.Id}\nKitap: {book.Title}\nEklenme Tarihi: {book.CreatedDate}\nDurum: {book.Status.GetDisplayName()}");
//}
#endregion

#region First - 2
// Kitap tablosundaki 51. kaydı getirelim
//using (var db = new AppDbContext())
//{
//    try
//    {
//        var book = db.Books.First(x => x.Id == 51);
//        Console.WriteLine($"Id: {book.Id}\nKitap: {book.Title}\nEklenme Tarihi: {book.CreatedDate}\nDurum: {book.Status.GetDisplayName()}");

//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Böyle bir kitap bulunamadı.");
//        throw;
//    }
//}
#endregion

#region FirstOrDefault
// Kitap tablosundaki 51. kaydı getirelim
//using (var db = new AppDbContext())
//{
//    var book = db.Books.FirstOrDefault(x => x.Id == 51);
//    if (book is not null)
//    {
//        Console.WriteLine($"Id: {book.Id}\nKitap: {book.Title}\nEklenme Tarihi: {book.CreatedDate}\nDurum: {book.Status.GetDisplayName()}");
//    }
//    else
//    {
//        Console.WriteLine("Böyle bir kitap bulunamadı.");
//    }
//}
/*
 * First de TRY-CATCH kullanılırken, FisrtOrDefault ta if kullanılır.
 */
#endregion

#region FirstOrDefault - 2
// TürId si korku olan türü getir.(Id, Tür, Adı)
//using (var db = new AppDbContext())
//{
//    var genre = db.Genres.FirstOrDefault(x => x.Id == "korku");
//    if (genre is not null)
//    {
//        Console.WriteLine($"Id: {genre.Id}\nTür: {genre.Name}\nDurum: {genre.Status.GetDisplayName()}");
//    }
//    else
//    {
//        Console.WriteLine("Böyle bir kitap bulunamadı.");
//    }
//}
#endregion

#region Find
// Sadece Id lerde arama yapar.
// Id si 5 olan kitabı getirelim
//using (var db = new AppDbContext())
//{
//    var book = db.Books.Find(5);
//    if (book is not null)
//    {
//        Console.WriteLine($"Id: {book.Id}\nKitap: {book.Title}\nDurum: {book.Status.GetDisplayName()}");
//    }
//    else
//    {
//        Console.WriteLine("Böyle bir kitap bulunamadı.");
//    }
//}
#endregion

#region Take
// Parameterede verdiğiniz değer kadar üstten seçip alır.
// Fiyatı en yüksek 5 kitabı getirin.

//using (var db = new AppDbContext())
//{
//    var books = db.Books.OrderByDescending(x => x.Price)
//        .Take(5)
//        .Select(x => new
//        {
//            x.Id,
//            x.Title,
//            x.Price
//        }).ToList();
//    foreach (var book in books)
//    {
//        Console.WriteLine($"Id: {book.Id}\nKitap: {book.Title}\nFiyat: {book.Price} TL\n=====================");
//    }
//}
#endregion

#region Take&Skip
// Türü roman olan fiyatı en yüksek 3. kitabı getirin.
//using (var db = new AppDbContext())
//{
//    var books = db.Books.Where(x => x.GenreId == "roman")
//        .OrderByDescending(x => x.Price)
//        .Skip(2)
//        .Take(1)
//        .Select(x => new
//        {
//            x.Id,
//            x.Title,
//            x.Price,
//            x.GenreId,
//            x.Status
//        }).ToList();
//    foreach (var book in books)
//    {
//        Console.WriteLine($"Id: {book.Id}\nKitap:{book.Title}\nTürId: {book.GenreId}\nDurum: {book.Status}");
//    }
//}
#endregion

#region Contains
// İçeriyor mu diye sorar
// İçerisinde a harfi geçen kiatpları getir
//using (var db = new AppDbContext())
//{
//    var books = db.Books.Where(x => x.Title.Contains("a")).ToList();
//    foreach (var book in books)
//    {
//        Console.WriteLine($"Kitap: {book.Title}\n=================");
//    }
//}
#endregion

#region Any
// Verdiğiniz şartı sağlayan var mı yok mu diye bakar
// Türü aşk olan bir kitap var mı
//using (var db = new AppDbContext())
//{
//    var result = db.Books.Any(x => x.GenreId == "ask");
//    Console.WriteLine($"Türü aşk olan kitap {(result ? "vardır" : "yoktur")}");
//}
#endregion

// AGGREGATE FUNCTION
#region Count
// Kaç kitap vardır
//using (var db = new AppDbContext())
//{
//    var result = db.Books.Count();
//    Console.WriteLine($"Kitap sayısı: {result}");
//}
#endregion

#region Sum
// Kitapların fiyatlarının toplamı kaçtır?
//using (var db = new AppDbContext())
//{
//    var totalPrice = db.Books.Sum(x => x.Price);
//    Console.WriteLine($"Kitapların toplamı : {totalPrice}TL");
//}
#endregion

#region Min&Max
// Veri tabanındaki en pahalı kitabın fiyatı ve en ucuz kitabın fiyatı kaçtır?
//using (var db = new AppDbContext())
//{
//    var mostExpensive = db.Books.Max(x => x.Price);
//    var cheapest = db.Books.Min(x => x.Price);
//    Console.WriteLine($"En pahalı kitabın fiyatı : {mostExpensive}TL, en ucuz kitabın fiyatı: {cheapest}TL");
//}
#endregion

#region GroupBy With Count - 1 
// Kİtapları türlerine göre gruplayalım
//using (var db = new AppDbContext())
//{
//    var books = db.Books.GroupBy(x => x.Genre.Name)
//        .Select(x => new
//        {
//            GenreName = x.Key, // key kolon numarası verir
//            Count = x.Count()
//        }).ToList();

//    foreach (var book in books)
//    {
//        Console.WriteLine($"Tür Adı: {book.GenreName} - Adet: {book.Count}\n");
//    }
//}
#endregion

#region GroupBy With Count - 2
// 2 den fazla kitabı olan yazarları yazdırın
//using (var db = new AppDbContext())
//{
//    var result = db.BookAuthors.GroupBy(x => x.Author.FirstName + " " + x.Author.LastName)
//        .Select(x => new
//        {
//            AuthorName = x.Key,
//            Count = x.Count()
//        })
//        .Where(x => x.Count >= 2)
//        .OrderByDescending(x => x.Count)
//        .ToList();

//    foreach (var item in result)
//    {
//        Console.WriteLine($"Yazar: {item.AuthorName} - Kitap Sayısı: {item.Count}\n");
//    }
//}
#endregion

#region GroupBy With Sum
// Türlerine göre kitapların fiyatlarının toplamı
using (var db = new AppDbContext())
{
    var result = db.Books.GroupBy(x => x.Genre.Name)
        .Select(x => new
        {
            GenreName = x.Key,
            TotalPrice = x.Sum(y => y.Price)
        })
        .ToList();

    foreach (var item in result)
    {
        Console.WriteLine($"Tür Adı: {item.GenreName} - Toplam Fiyat: {item.TotalPrice}");
    }
}
#endregion