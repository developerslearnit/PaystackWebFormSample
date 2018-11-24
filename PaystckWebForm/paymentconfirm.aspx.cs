using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaystckWebForm
{
    public partial class paymentconfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RegisterAsyncTask(new PageAsyncTask(VerifyTransaction));
            }
            
        }

        private async Task VerifyTransaction()
        {
            var tranxRef = Request.QueryString["reference"];
            var paystackAPI = new Paystack.Net.SDK.Transactions.PaystackTransaction("YOUR_KEY");
            var response = await paystackAPI.VerifyTransaction(tranxRef);
            if (response.status)
            {
                //Payment confirmed -- Do stuff here
            }
        }
    }
}