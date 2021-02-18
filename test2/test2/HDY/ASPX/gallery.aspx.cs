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

namespace test2.HDY.ASPX
{
    public partial class gallery : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        String favourite_id;
        string custname, title;
        string photo;
        string price;
        byte[] img;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            GenerateId();
            if (!this.IsPostBack)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Img", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
        }


        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {

            DataRowView dr = (DataRowView)e.Item.DataItem;
            string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["ImgUpload"]);
            (e.Item.FindControl("Image1") as Image).ImageUrl = imageUrl;           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                
                favourite.ExecuteNonQuery();
                con.Close();
            }
        }

        private void GenerateId()
        {
            SqlCommand cmdId = new SqlCommand("Select Count(FavouriteId) FROM Favourite", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            favourite_id = "FO" + i.ToString();
        }
    }
}