using CRUD_Operations.Infrastructure.Context;
using CRUD_Operations.Models.Concrete;
using CRUD_Operations.Models.Abstract;
#region Create Category
//using (var db = new AppDbContext())
//{
//    Category category = new Category
//    {
//        Name = "Kasap",
//        Description = "Et ve Tavuk ürünleri"
//    };
//    db.Categories.Add(category);
//    if (db.SaveChanges() > 0)
//    {
//        Console.WriteLine($"{category.Name} kategorisi database e kaydedilmiştir.");
//    }
//    else
//    {
//        Console.WriteLine("Kategori kaydedilmedi.");
//    }
//}
#endregion

#region Read Category/Categories
//using (var db = new AppDbContext())
//{
//List<Category> categories = db.Categories.ToList();
//foreach (Category category in categories)
//{
//    Console.WriteLine($"Id: {category.Id}\nAd: {category.Name}\nAçıklama: {category.Description}\nEklenme Tarihi: {category.CreatedDate}\nGüncellenme Tarihi: {(category.UpdatedDate is not null ? category.UpdatedDate : "Güncelleme yok")}\nDurum: {(category.Status == Status.Active ? "Aktif" : (category.Status == Status.Modified ? "Güncellenmiş" : "Pasif"))}\n===============================");
//}

//Category category = db.Categories.Find(2);
//Console.WriteLine($"Id: {category.Id}\nAd: {category.Name}\nAçıklama: {category.Description}\nEklenme Tarihi: {category.CreatedDate}\nGüncellenme Tarihi: {(category.UpdatedDate is not null ? category.UpdatedDate : "Güncelleme yok")}\nDurum: {(category.Status == Status.Active ? "Aktif" : (category.Status == Status.Modified ? "Güncellenmiş" : "Pasif"))}\n===============================");
//}
#endregion

#region Update Category
//using (var db = new AppDbContext())
//{
//    Category category = db.Categories.Find(2);
//    category.Name = "Değiştirilmiş Kategori";
//    category.Description = "Değiştirilmiş Açıklama";
//    category.UpdatedDate = DateTime.Now;
//    category.Status = Status.Modified;

//    db.Categories.Update(category);

//    if (db.SaveChanges() > 0)
//    {
//        Console.WriteLine($"{category.Name} kategorisi güncellenmiştir!");
//    }
//    else
//    {
//        Console.WriteLine("Kategori güncellenmedi!!");
//    }

//    Category categoryUpdate = db.Categories.Find(2);

//    Console.WriteLine($"Id: {categoryUpdate.Id}\nAd: {categoryUpdate.Name}\nAçıklama: {categoryUpdate.Description}\nEklenme Tarihi: {categoryUpdate.CreatedDate}\nGüncellenme Tarihi: {(categoryUpdate.UpdatedDate is not null ? category.UpdatedDate : "Güncelleme yok")}\nDurum: {(categoryUpdate.Status == Status.Active ? "Aktif" : (categoryUpdate.Status == Status.Modified ? "Güncellenmiş" : "Pasif"))}\n===============================");
//}


#endregion

#region Delete Category
using (var db = new AppDbContext())
{
    // Hard Delete
    //var category = db.Categories.Find(2);
    //db.Categories.Remove(category);
    //if (db.SaveChanges() > 0)
    //{
    //    Console.WriteLine("Kategori silinmiştir");
    //}
    //else
    //{
    //    Console.WriteLine("Kategori silnmemiştir.");
    //}


    // Soft Delete
    var category = db.Categories.Find(3);
    category.Status = Status.Passive;
    category.DeletedDate = DateTime.Now;

    db.Categories.Update(category);
    if (db.SaveChanges() > 0)
    {
        Console.WriteLine("Kategori pasife alınmıştır.");
    }
    else
    {
        Console.WriteLine("Kategori pasife alınamamıştır.");
    }

    List<Category> categories = db.Categories.Where(x => x.Status != Status.Passive).ToList();
    foreach (Category categoryUpdated in categories)
    {
        Console.WriteLine($"Id: {categoryUpdated.Id}\nAd: {categoryUpdated.Name}\nAçıklama: {categoryUpdated.Description}\nEklenme Tarihi: {categoryUpdated.CreatedDate}\nGüncellenme Tarihi: {(categoryUpdated.UpdatedDate is not null ? categoryUpdated.UpdatedDate : "Güncelleme yok")}\nDurum: {(categoryUpdated.Status == Status.Active ? "Aktif" : (categoryUpdated.Status == Status.Modified ? "Güncellenmiş" : "Pasif"))}\n===============================");
    }

}


#endregion