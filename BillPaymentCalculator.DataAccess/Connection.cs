namespace BillPaymentCalculator.DataAccess
{
    public class Connection
    {
        string connection = "metadata=res://*/Entities.csdl|res://*/Entities.ssdl|res://*/Entities.msl;provider=System.Data.SqlClient;provider connection string=\"data source=FIELDOFDREAMS;" +
              "initial catalog=BillPaymentCalculator;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
    }
}