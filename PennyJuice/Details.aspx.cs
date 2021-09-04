using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PennyJuice
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // Add To Cart Button
        protected void BtnPurchase_Click(object sender, EventArgs e)
        {
            var con = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            string price = String.Empty;
            string img = String.Empty;
            string name = String.Empty;
            string id;
            id = Session["ArtistList"].ToString();

            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Juice where Id=@id";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@id", id);

                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        price = oReader["Price"].ToString();
                        img = oReader["Image"].ToString();
                        name = oReader["JuiceName"].ToString();
                    }

                    myConnection.Close();
                }
            }

            //string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection gallery = new SqlConnection(con);
            gallery.Open();

            SqlCommand cmd = gallery.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [Order] ([Image], [ProductName], [Price], [Quantity]) VALUES(@image, @itemName, @itemPrice, '1')";

            cmd.Parameters.AddWithValue("@image", img);
            cmd.Parameters.AddWithValue("@itemName", name);
            cmd.Parameters.AddWithValue("@itemPrice", price);

            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('This item sucessfully add to cart.')</script>");
            }
            catch
            {
                Response.Write("<script>alert('This item is already in the cart.')</script>");
            }

            gallery.Close();
            
        }
    }
}