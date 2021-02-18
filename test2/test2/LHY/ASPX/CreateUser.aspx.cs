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
    public partial class CreateUser : System.Web.UI.Page
    {
        // create connection -> sampleDB
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        string CustomerID;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            GenerateId();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string strAdd = "INSERT INTO Customer VALUES(@ID, @name, @phone,@pass)";

            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            cmdAdd.Parameters.AddWithValue("@ID", CustomerID);

            cmdAdd.Parameters.AddWithValue("@name", txtUsername.Text);

            cmdAdd.Parameters.AddWithValue("@phone", txtPhone.Text);

            cmdAdd.Parameters.AddWithValue("@pass", txtPassw.Text);

            cmdAdd.ExecuteNonQuery();
            con.Close();
        }

        private void GenerateId()
        {
            SqlCommand cmdId = new SqlCommand("Select Count(CustID) FROM Customer", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            CustomerID = "CO" + i.ToString();
        }
    }
}