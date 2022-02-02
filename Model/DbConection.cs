using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineFootWare.Model
{
    public class DbConection
    {
        string ConnectionStr = "Data Source=100.72.130.5;Initial Catalog=Training;Persist Security Info=True;User ID=TrainingUsr;Password=Tr@ininGU$r@#321";
       
        public DataTable ViewDb(FootProperty foot)
        {
            SqlConnection conobj = new SqlConnection(ConnectionStr);
            SqlDataAdapter da = new SqlDataAdapter($"select ProductCode,Name,Cost  from AKFoodwares where Category = '{foot.Category}'", conobj);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return dt;
        }

        public StatusProperty Fetch(FootProperty foot)
        {
            StatusProperty status = new StatusProperty();
            SqlConnection conobj = new SqlConnection(ConnectionStr);
            SqlDataAdapter da = new SqlDataAdapter($"select * from AKFoodwares where ProductCode = {foot.ProductCode} ", conobj);
            DataTable dt = new DataTable();
            da.Fill(dt);
            status.ProductCode = Convert.ToInt32(dt.Rows[0][0]);
            status.ProductName = dt.Rows[0][1].ToString();
            status.Cost = Convert.ToInt32(dt.Rows[0][2]);
            return status;
        }
        public void Payment(StatusProperty status)
        {
            SqlConnection conobj = new SqlConnection(ConnectionStr);
            conobj.Open();
            SqlCommand query = new SqlCommand($"insert into AkOrderStatus values({status.ProductCode},'{status.ProductName}',{status.Cost},{status.Quantity},{status.TotalAmount})",conobj); ;
            query.ExecuteNonQuery();
            conobj.Close();
        }

        public DataTable Status()
        {
            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlDataAdapter da = new SqlDataAdapter("select * from OrderPage_AK", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



    }
}