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
        string custname, title, price;
        string CustomerName;
        byte[] img;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetCustomerName();
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }


        protected void imgBtn1_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO1";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn2_Click(object sender, ImageClickEventArgs e)
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn3_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO11";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn4_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO12";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn5_Click1(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO13";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn6_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO14";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn7_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO15";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn8_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO16";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn9_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO2";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn10_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO3";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgbtn11_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO4";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn12_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO5";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn13_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO6";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn14_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO7";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn15_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO8";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        protected void imgBtn16_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = "PO9";
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

                string add = "INSERT INTO Favourite VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand favourite = new SqlCommand(add, con);

                favourite.Parameters.AddWithValue("@id", favourite_id);
                favourite.Parameters.AddWithValue("@cust", custname);
                favourite.Parameters.AddWithValue("@name", title);
                favourite.Parameters.AddWithValue("@photo", img);
                favourite.Parameters.AddWithValue("@price", price);
                favourite.Parameters.AddWithValue("@CustName", CustomerName);

                favourite.ExecuteNonQuery();
                con.Close();

                Response.Redirect("~/LMY/ASPX/Favourite.aspx?id=" + favourite_id);
            }
        }

        private void GenerateId()
        {
            SqlCommand cmdId = new SqlCommand("Select Count(FavouriteId) FROM Favourite", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            favourite_id = "FO" + i.ToString();
        }

        protected void GetCustomerName()
        {
            ////Get Now is who webpage
            con.Open();
            string strAdd = "Select * From Login where Id=@ID";
            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            //Find ID
            SqlCommand cmdId = new SqlCommand("Select Count(Id) FROM Login", con);
            int numLogin = Convert.ToInt32(cmdId.ExecuteScalar());

            //Enter Search
            cmdAdd.Parameters.AddWithValue("@ID", numLogin);
            SqlDataReader dtrProd = cmdAdd.ExecuteReader();

            if (dtrProd.HasRows)
            {
                while (dtrProd.Read())
                {
                    CustomerName = dtrProd["Username"].ToString();
                }
            }
            con.Close();
        }
    }
}