using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineFootWare.Model;

namespace OnlineFootWare
{
    public partial class OrderPage : System.Web.UI.Page
    {
        FootProperty foot = new FootProperty();
        DbConection con = new DbConection();

        protected void Page_Load(object sender, EventArgs e)
        {
            

            DbConection con = new DbConection();
            
            if (!IsPostBack)
            {
                lblProductCode.Text = "" + Session["value"];
                foot.ProductCode = Convert.ToInt32(Session["value"]);
                StatusProperty status = con.Fetch(foot);
                
                lblProductName.Text = status.ProductName;
                lblPrice.Text = status.Cost.ToString();
            }
            
        }

        protected void btnBill_Click(object sender, EventArgs e)
        {

            foot.ProductCode = Convert.ToInt32(Session["value"]);

            StatusProperty status = con.Fetch(foot);
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            lblTotalAmount.Text = Convert.ToString(status.Cost * Quantity);
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("orderstatus.aspx");
        }
    }
}