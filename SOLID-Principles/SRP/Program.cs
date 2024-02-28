using SRP.BadExample;
using SRP.Entity;
using SRP.GoodExamples;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            Employee employee = new Employee() { Id = 1, FirstName = "Sina Emre", LastName = "Bekar", HireDate = new DateTime(2021, 02, 20, 14, 40, 20) };

            #region Bad Example
            //BadEmployee.CreateEmployee(employee);
            #endregion

            #region Good Example
            CreateEmployee.InsertEmployee(employee);
            BuiltLog.InsertLog(employee);
            #endregion

        }
    }
}
