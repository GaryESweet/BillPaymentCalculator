using System.Data.SqlClient;

namespace BillPaymentCalculator.DataAccess
{
    public class Connection
    {
        string connection = "metadata=res://*/Entities.csdl|res://*/Entities.ssdl|res://*/Entities.msl;provider=System.Data.SqlClient;provider connection string=\"data source=FIELDOFDREAMS;" +
              "initial catalog=BillPaymentCalculator;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        public void SaveBusinessName(string name)
        {
            using(var db = new BillPaymentCalculatorEntities())
            {
                db.insBuisnessNames(name);
            }
        }
    }
}