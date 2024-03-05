using SOLID_Homework.SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Homework.SRP.Examples
{
    public class GenelCerrahi
    {
        public static void InsertGenelCerrahi(Doktor doktor)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                stringBuilder = new StringBuilder();
                stringBuilder.AppendLine();
                stringBuilder.Append($"Adı: {doktor.Ad}\nSoyadı: {doktor.Soyad}\nÇalıştığı Hastane: {doktor.HastaneAdi}\nGenel Cerrahiye Giriş Tarihi: {DateTime.Now}");
                File.WriteAllText(@"C:\source\Bilgeadam\SOLID-Homework\SOLID-Homework\Genel.txt", stringBuilder.ToString());
            }
            catch (Exception)
            {

                Console.WriteLine("Hata oluştu!!");
                throw;
            }
        }
    }
}

