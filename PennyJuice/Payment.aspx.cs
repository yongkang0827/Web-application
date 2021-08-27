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
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            int price = 0;

            con.Open();
            string strAdd = "SELECT * FROM Payment";
            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            cmdAdd.Parameters.AddWithValue("@Buy", "Yes");
            SqlDataReader dtrProd = cmdAdd.ExecuteReader();

            if (dtrProd.HasRows)
            {
                while (dtrProd.Read())
                {
                    int total;
                    total = Int32.Parse(dtrProd["Quantity"].ToString()) * Int32.Parse(dtrProd["Price"].ToString());
                    price += total;
                }
            }
            con.Close();

            Label1.Text = price.ToString();
        }

        

        protected void Pay_Click(object sender, EventArgs e)
        {
            Session["Name"] = Name.Text;
            Session["Address"] = Address.Text;
            Session["Postal"] = Postal.Text;
            Session["Email"] = Email.Text;
            Response.Redirect("~/PayMoney.aspx");
        }
    }
}