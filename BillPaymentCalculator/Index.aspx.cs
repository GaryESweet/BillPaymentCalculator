using BillPaymnetCalculator.Buisness;
using System;

namespace BillPaymentCalculator
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BusinessName.Text = "Save Name";
        }

        private void SaveBusinessName(string name)
        {
            BusinessNames saveName = new BusinessNames();
            saveName.SaveBusinessName(name);
        }

        protected void BusinessName_Click(object sender, EventArgs e)
        {
            string name = BusinessNameInput.Value;
            SaveBusinessName(name);
            ClearInput();
        }

        private void ClearInput()
        {
            BusinessNameInput.Value = string.Empty;
        }

        protected void btnMonthlyPayment_Click(object sender, EventArgs e)
        {

        }
    }
}