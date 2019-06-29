using System.Data.SqlClient;

namespace BillPaymentCalculator.DataAccess
{
    public class StoredProcedureAccess
    { 

        public void SaveBusinessName(string name)
        {
            using(var db = new BillPaymentCalculatorEntities())
            {
                db.insBuisnessNames(name);
            }
        }

        public void SaveMonthlyPayment(decimal amount, bool isActive)
        {
            using(var db = new BillPaymentCalculatorEntities())
            {
                db.insMonthlyPaymentAmounts(amount, isActive);
            }
        }
    }
}