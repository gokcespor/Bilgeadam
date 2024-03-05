using SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.BadExample
{
    public class BadEmployee
    {
        public static void CreateEmployee(Employee employee)
        {
            StringBuilder stringBuilder = new StringBuilder(); // string dosyası kullanmak için oluşturuldu
            try
            {
                #region İşlem 1: Çalışanın özlük bilgilerinin kayıt edilmesi
                stringBuilder.Append("Id: " + employee.Id);
                stringBuilder.AppendLine();

                stringBuilder.Append("Ad: " + employee.FirstName);
                stringBuilder.AppendLine();

                stringBuilder.Append("Soyad: " + employee.LastName);
                stringBuilder.AppendLine();

                stringBuilder.Append("İşe Giriş Tarihi: " + employee.HireDate);
                stringBuilder.AppendLine();

                File.WriteAllText(@"C:\Users\gokce\OneDrive\Masaüstü\Database\PersonelDB.txt", stringBuilder.ToString());
                #endregion

                #region İşlem 2: Çalışanın sisteme giriş yapması sonucunda oluşan Log ların(Kayıtların) tutulması
                stringBuilder = new StringBuilder();
                stringBuilder.AppendLine();
                stringBuilder.Append("Giriş Tarihi: " + DateTime.Now);
                stringBuilder.AppendLine();
                stringBuilder.Append("Çaışan " + employee.FirstName + " " + employee.LastName);

                File.WriteAllText(@"C:\Users\gokce\OneDrive\Masaüstü\Database\LogDB.txt", stringBuilder.ToString());
                #endregion
            }
            catch (Exception)
            {
                Console.WriteLine("Hata oluştu!!");
                throw;
            }
        }
    }
}
