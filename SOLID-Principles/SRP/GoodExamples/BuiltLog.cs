using SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.GoodExamples
{
    public class BuiltLog
    {
        public static void InsertLog(Employee employee)
        {
            StringBuilder stringBuilder = new StringBuilder(); // string dosyası kullanmak için oluşturuldu
            try
            { 
                #region İşlem 2: Çalışanın sisteme giriş yapması sonucunda oluşan Log ların(Kayıtların) tutulması
                stringBuilder = new StringBuilder();
                stringBuilder.AppendLine();
                stringBuilder.Append("Giriş Tarihi: " + DateTime.Now);
                stringBuilder.AppendLine();
                stringBuilder.Append("Çalışan " + employee.FirstName + " " + employee.LastName);

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
