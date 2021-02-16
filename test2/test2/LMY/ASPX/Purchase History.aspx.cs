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
    public partial class Purchase_History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Love Button
            //imgLove1.ImageUrl = "~/LMY/IMG/not love.png";
            //img1.ImageUrl = "~/LMY/IMG/Prodromes.jpg";

            //Open Database
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();

            //Retrieve Data
            string strSelect = "Select * from PurchaseHistory where CustId=@id";

            SqlCommand cmdSelect = new SqlCommand(strSelect, con);
            String com = "C001";

            cmdSelect.Parameters.AddWithValue("@id", com);

            SqlDataReader dtrProd = cmdSelect.ExecuteReader();

            if (dtrProd.HasRows)
            {
                while (dtrProd.Read())
                {
                    //string msg = dtrProd["Photo_Name"].ToString();

                    img1.ImageUrl = dtrProd["Photo"].ToString();
                    img2.ImageUrl = dtrProd["Photo"].ToString();

                    //lblimg1.Text = msg;
                    //lblimg2.Text = msg;

                    //Label1.Text = dtrProd["Photo"].ToString();
                }
            }

            con.Close();
        }
    }
}