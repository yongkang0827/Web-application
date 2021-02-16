using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace test2.LMY.ASPX
{
    public partial class Insert : System.Web.UI.Page
    {
        // create connection -> sampleDB
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);     

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();

            img.ImageUrl = "~/LMY/IMG/Artifact.jpg";
        }

        protected void Button_Click(object sender, EventArgs e)
        {

            string strAdd = "insert into PurchaseHistory Values(@ID, @name, @photoname, @photo)";
            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            cmdAdd.Parameters.AddWithValue("@ID", txt1.Text);
            cmdAdd.Parameters.AddWithValue("@name", txt2.Text);
            cmdAdd.Parameters.AddWithValue("@photoname", txt3.Text);
            cmdAdd.Parameters.AddWithValue("@photo", img.ImageUrl);

            cmdAdd.ExecuteNonQuery();


            con.Close();
        }
    }
}