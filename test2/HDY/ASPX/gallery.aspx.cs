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
        String order_id;
        string custname, title, price;
        string CustomerName;
        byte[] img;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetCustomerName();
            con.Open();
            GenerateId();
            GenerateOrderId();
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
            string id = "PO10";
            AddFavourite(id);
        } 

        protected void btnFav1_Click(object sender, EventArgs e)
        {
            String id = "PO1";
            AddFavourite(id);
        }

        protected void btnFav2_Click(object sender, EventArgs e)
        {
            String id = "PO10";
            AddFavourite(id);  
        }

        protected void btnFav3_Click(object sender, EventArgs e)
        {           
            String id = "PO11";
            AddFavourite(id);
        }

        protected void btnFav4_Click(object sender, EventArgs e)
        {
            String id = "PO12";
            AddFavourite(id);
        }

        protected void btnFav5_Click(object sender, EventArgs e)
        {
            String id = "PO13";
            AddFavourite(id);
        }

        protected void btnFav6_Click(object sender, EventArgs e)
        {
            String id = "PO14";
            AddFavourite(id);
        }

        protected void btnFav7_Click(object sender, EventArgs e)
        {
            String id = "PO15";
            AddFavourite(id);
        }

        protected void btnFav8_Click(object sender, EventArgs e)
        {
            String id = "PO16";
            AddFavourite(id);
        }

        protected void btnFav9_Click(object sender, EventArgs e)
        {
            String id = "PO17";
            AddFavourite(id);
        }

        protected void btnFav10_Click(object sender, EventArgs e)
        {
            String id = "PO18";
            AddFavourite(id);
        }

        protected void btnFav11_Click(object sender, EventArgs e)
        {
            String id = "PO2";
            AddFavourite(id);
        }

        protected void btnFav12_Click(object sender, EventArgs e)
        {
            String id = "PO3";
            AddFavourite(id);
        }

        protected void btnFav13_Click(object sender, EventArgs e)
        {
            String id = "PO4";
            AddFavourite(id);
        }

        protected void btnFav14_Click(object sender, EventArgs e)
        {
            String id = "PO5";
            AddFavourite(id);
        }

        protected void btnFav15_Click(object sender, EventArgs e)
        {
            String id = "PO6";
            AddFavourite(id);
        }

        protected void btnFav16_Click(object sender, EventArgs e)
        {
            String id = "PO7";
            AddFavourite(id);
        }

        protected void btnFav17_Click(object sender, EventArgs e)
        {
            String id = "PO8";
            AddFavourite(id);
        }

        protected void btnFav18_Click(object sender, EventArgs e)
        {
            String id = "PO9";
            AddFavourite(id);
        }

        public void AddFavourite(string favid)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = favid;
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


            }
        }

       

        public void AddOrder(string Ordid)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = Ordid;
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

                string add = "INSERT INTO [Order] VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                SqlCommand order = new SqlCommand(add, con);

                order.Parameters.AddWithValue("@id", order_id);
                order.Parameters.AddWithValue("@cust", custname);
                order.Parameters.AddWithValue("@name", title);
                order.Parameters.AddWithValue("@photo", img);
                order.Parameters.AddWithValue("@price", price);
                order.Parameters.AddWithValue("@CustName", CustomerName);

                order.ExecuteNonQuery();
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

        protected void btnOrder2_Click(object sender, EventArgs e)
        {
            String id = "PO1";
            AddOrder(id);
        }

        protected void btnOrder3_Click(object sender, EventArgs e)
        {
            String id = "PO11";
            AddOrder(id);
        }

        protected void btnOrder4_Click(object sender, EventArgs e)
        {
            String id = "PO12";
            AddOrder(id);
        }

        protected void btnOrder5_Click(object sender, EventArgs e)
        {
            String id = "PO13";
            AddOrder(id);
        }

        protected void btnOrder6_Click(object sender, EventArgs e)
        {
            String id = "PO14";
            AddOrder(id);
        }

        protected void btnOrder7_Click(object sender, EventArgs e)
        {
            String id = "PO15";
            AddOrder(id);
        }

        protected void btnOrder8_Click(object sender, EventArgs e)
        {
            String id = "PO16";
            AddOrder(id);
        }

        protected void btnOrder9_Click(object sender, EventArgs e)
        {
            String id = "PO17";
            AddOrder(id);
        }

        protected void btnOrder10_Click(object sender, EventArgs e)
        {
            String id = "PO18";
            AddOrder(id);
        }

        protected void btnOrder11_Click(object sender, EventArgs e)
        {
            String id = "PO2";
            AddOrder(id);
        }

        protected void btnOrder12_Click(object sender, EventArgs e)
        {
            String id = "PO3";
            AddOrder(id);
        }

        protected void btnOrder13_Click(object sender, EventArgs e)
        {
            String id = "PO4";
            AddOrder(id);
        }

        protected void btnOrder14_Click(object sender, EventArgs e)
        {
            String id = "PO5";
            AddOrder(id);
        }

        protected void btnOrder15_Click(object sender, EventArgs e)
        {
            String id = "PO6";
            AddOrder(id);
        }

        protected void btnOrder16_Click(object sender, EventArgs e)
        {
            String id = "PO7";
            AddOrder(id);
        }

        protected void btnOrder17_Click(object sender, EventArgs e)
        {
            String id = "PO8";
            AddOrder(id);
        }

        protected void btnOrder18_Click(object sender, EventArgs e)
        {
            String id = "PO9";
            AddOrder(id);
        }

        protected void btnOrder1_Click(object sender, EventArgs e)
        {
            String id = "PO1";
            AddOrder(id);
        }

        private void GenerateOrderId()
        {
           
            SqlCommand cmdId = new SqlCommand("Select Count(OrderId) FROM [Order]", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            order_id = "O" + i.ToString();
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