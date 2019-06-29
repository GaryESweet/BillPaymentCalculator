using BillPaymentCalculator.DataAccess;

namespace BillPaymnetCalculator.Buisness
{
    public class BusinessNames
    {
        public void SaveBusinessName(string name)
        {
            StoredProcedureAccess conn = new StoredProcedureAccess();
            conn.SaveBusinessName(name);
        }
        
       
    }
}