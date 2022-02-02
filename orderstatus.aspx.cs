using OnlineFootWare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineFootWare
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConection con = new DbConection();

            DataTable dt = new DataTable();

            dt = con.Status();

            GVStatus.DataSource = dt;

            GVStatus.DataBind();
        }
    }
}