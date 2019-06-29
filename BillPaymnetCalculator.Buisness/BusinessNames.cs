using BillPaymentCalculator.DataAccess;

namespace BillPaymnetCalculator.Buisness
{
    public class BusinessNames
    {
        public void SaveBusinessName(string name)
        {
            Connection conn = new Connection();
            conn.SaveBusinessName(name);
        }
        
       
    }
}