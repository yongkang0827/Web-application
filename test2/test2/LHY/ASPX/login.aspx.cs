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
            string strAdd = "Select * From Customer Where Username=@id";

            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            cmdAdd.Parameters.AddWithValue("@ID", txtUsername.Text);
            SqlDataReader dtrProd = cmdAdd.ExecuteReader();

            if (dtrProd.HasRows)
            {
                while (dtrProd.Read())
                {
                    string password = txtPassw.Text;
                    if (password.Equals(dtrProd["Password"].ToString()))
                    {
                        Login = true;

                    }



                }
            }

            con.Close();
        }
    }
}