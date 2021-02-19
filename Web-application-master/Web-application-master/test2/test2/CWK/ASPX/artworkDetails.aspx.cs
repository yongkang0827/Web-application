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


namespace test2.CWK.ASPX
{
    public partial class artworkDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        byte[] img;
        string custname, title;
        
        string price;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuyNow_Click(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO10";
            sdi.Parameters.AddWithValue("@PostId", id);
            SqlDataReader dtrProd = sdi.ExecuteReader();

            if (dtrProd.HasRows)
            {
                while (dtrProd.Read())
                {
                    custname = dtrProd["PostId"].ToString();
                    title = dtrProd["Title"].ToString();
                    price = dtrProd["Price"].ToString();

                    img = (byte[])(dtrProd["ImgUpload"]);

                }

                con.Close();
                con.Open();
            }
        }

    }
}
