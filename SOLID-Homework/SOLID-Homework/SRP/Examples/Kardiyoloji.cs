using SOLID_Homework.SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Homework.SRP.Examples
{
    public class Kardiyoloji
    {
        public static void InsertKardiyoloji(Doktor doktor)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"Ad: {doktor.Ad}");
                stringBuilder.AppendLine();

                stringBuilder.Append($"Soyad: {doktor.Soyad}");
                stringBuilder.AppendLine();

                stringBuilder.Append($"Hastane Adı: {doktor.HastaneAdi}");
                stringBuilder.AppendLine();

                stringBuilder.Append($"Kardiyolojiye Giriş Tarihi: {doktor.HireDate}");
                stringBuilder.AppendLine();

                File.WriteAllText(@"C:\source\Bilgeadam\SOLID-Homework\SOLID-Homework\KardiyolojiDB.txt", stringBuilder.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Hata oluştu!!");
                throw;
            }
        }
    }
}

