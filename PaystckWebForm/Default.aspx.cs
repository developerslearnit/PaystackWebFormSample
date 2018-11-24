using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaystckWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void payNow_Click(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(InitTransaction)); 
        }

        private async Task InitTransaction()
        {
            var paystackAPI = new Paystack.Net.SDK.Transactions.PaystackTransaction("YOUR_KEY");

            var response = await paystackAPI.InitializeTransaction("email@customer.com", 500000, "", "", "", "http://localhost:1063/paymentconfirm.aspx");

            if (response.status)
            {
                Response.AddHeader("Access-Control-Allow-Origin", "*");
                Response.AppendHeader("Access-Control-Allow-Origin", "*");
                Response.Redirect(response.data.authorization_url);
            }
        }
    }
}