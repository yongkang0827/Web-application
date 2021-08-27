using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PennyJuice
{
    public partial class Order : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        int checkCheckBox = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string strAdd = "Delete From Payment";
            SqlCommand cmdDelete = new SqlCommand(strAdd, con);

            cmdDelete.ExecuteNonQuery();
            con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
/*            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Control control = e.Row.Cells[6].Controls[0];
                if (control is ImageButton)
                {
                    ((ImageButton)control).OnClientClick =
                        "return confirm('Are you sure you want to delete?');";
                }
            }
*/        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox status = (row.Cells[0].FindControl("Checkbox1") as CheckBox);
                string item = row.Cells[2].Text;

                if (status.Checked)
                {
                    updateRowSource(item);
                    checkCheckBox += 1;
                }
            }

            string msg;

            if (checkCheckBox > 0)
            {
                msg = "Check Out Successfully";
            }
            else
            {
                msg = "Please at least select one check box to buy";
            }

            ScriptManager.RegisterStartupScript(this, this.GetType(),
            "alert",
            "alert('" + msg + "');window.location ='Order.aspx';",
               true);
            Response.Redirect("~/Payment.aspx");

        }

        private void updateRowSource(String productName)
        {
            string quantity = "", price = "";
            con.Open();
            string strAdd = "SELECT * FROM [Order] WHERE [ProductName] = @ProductName";
            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            cmdAdd.Parameters.AddWithValue("@ProductName", productName);
            SqlDataReader dtrProd = cmdAdd.ExecuteReader();

            if (dtrProd.HasRows)
            {
                while (dtrProd.Read())
                {
                    quantity = dtrProd["Quantity"].ToString();
                    price = dtrProd["Price"].ToString();
                }
            }
            con.Close();

            /////////////////////////
            
            if(price != null && quantity != null)
            {
                con.Open();
                string strAddPay = "INSERT INTO Payment VALUES (@ProductName, @Price, @Quantity, @Buy)";
                SqlCommand cmdAddPay = new SqlCommand(strAddPay, con);

                cmdAddPay.Parameters.AddWithValue("@ProductName", productName);
                cmdAddPay.Parameters.AddWithValue("@Price", price);
                cmdAddPay.Parameters.AddWithValue("@Quantity", quantity);
                cmdAddPay.Parameters.AddWithValue("@Buy", "Yes");

                cmdAddPay.ExecuteNonQuery();
                con.Close();
            }
           
        }

    }
}