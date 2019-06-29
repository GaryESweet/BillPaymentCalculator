using BillPaymnetCalculator.Buisness;
using System;

namespace BillPaymentCalculator
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void SaveBusinessName()
        {
            string name = BusinessNameInput.Value;        
            
            BusinessNames saveName = new BusinessNames();
            saveName.SaveBusinessName(name);            
        }

        protected void BusinessName_Click(object sender, EventArgs e)
        {
            SaveBusinessName();
        }

        private void ClearInput()
        {
            BusinessNameInput.Value = string.Empty;
            MonthlyPaymentInput.Value = string.Empty;
        }

        protected void btnMonthlyPayment_Click(object sender, EventArgs e)
        {
            SaveMonthlyPayment();
        }

        private void SaveMonthlyPayment()
        {
            //Call Business SaveMonthlyPayment
            string monthlyPayment = MonthlyPaymentInput.Value;
            bool isDecimal = decimal.TryParse(monthlyPayment, out decimal payment);
            if (isDecimal)
            {
                SaveMonthlyPayment();
            }
            else
            {
                //Error Message to User
            }
        }
    }
}