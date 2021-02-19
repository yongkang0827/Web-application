using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace test2.LHY.ASPX
{
    public partial class login : System.Web.UI.Page
    {
        bool Login = false;
        // create connection -> sampleDB
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (ddlRole.SelectedValue.Equals("Customer"))
            {
                string strAdd = "Select * From Customer Where Username=@ID and Password=@Pass";

                SqlCommand cmdAdd = new SqlCommand(strAdd, con);

                cmdAdd.Parameters.AddWithValue("@ID", txtUsername.Text);
                cmdAdd.Parameters.AddWithValue("@Pass", txtPassw.Text);
                SqlDataReader dtrProd = cmdAdd.ExecuteReader();

                if (dtrProd.HasRows)
                {
                    Response.Redirect("~/Home.aspx");
                }
                else
                {
                    string msg = "Invalid username or password";
                    Response.Write("<script>alert('" + msg + "')</script>");
                }
            }
            else
            {
                string strAdd = "Select * From Artist Where Username=@ID and Password=@Pass";

                SqlCommand cmdAdd = new SqlCommand(strAdd, con);

                cmdAdd.Parameters.AddWithValue("@ID", txtUsername.Text);
                cmdAdd.Parameters.AddWithValue("@Pass", txtPassw.Text);
                SqlDataReader dtrProd = cmdAdd.ExecuteReader();

                if (dtrProd.HasRows)
                {
                    Response.Redirect("~/Home.aspx");
                }
                else
                {
                    string msg = "Invalid username or password";
                    Response.Write("<script>alert('" + msg + "')</script>");
                }
            }





            con.Close();
        }
    }
}