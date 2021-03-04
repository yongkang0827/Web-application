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
        String details_id;
        int quantity;
             

        protected void Page_Load(object sender, EventArgs e)
        {
            GetCustomerName();
            con.Open();
            GenerateId();
            GenerateOrderId();
            GenerateDetailsId();
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



        private void GenerateId()
        {
            SqlCommand cmdId = new SqlCommand("Select Count(FavouriteId) FROM Favourite", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            favourite_id = "FO" + i.ToString();
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

        protected void btnView1_Click(object sender, EventArgs e)
        {
            String id = "PO1";
            AddDetails(id);
        }

        protected void btnView2_Click(object sender, EventArgs e)
        {
            String id = "PO10";
            AddDetails(id);
        }

        protected void btnView3_Click(object sender, EventArgs e)
        {
            String id = "PO11";
            AddDetails(id);
        }

        protected void btnView4_Click(object sender, EventArgs e)
        {
            String id = "PO12";
            AddDetails(id);
        }

        protected void btnView5_Click(object sender, EventArgs e)
        {
            String id = "PO13";
            AddDetails (id);
        }

        protected void btnView6_Click(object sender, EventArgs e)
        {
            String id = "PO14";
            AddDetails(id);
        }

        protected void btnView7_Click(object sender, EventArgs e)
        {
            String id = "PO15";
            AddDetails(id);
        }

        protected void btnView8_Click(object sender, EventArgs e)
        {
            String id = "PO16";
            AddDetails(id);
        }

        protected void btnView9_Click(object sender, EventArgs e)
        {
            String id = "PO17";
            AddDetails(id);
        }

        protected void btnView10_Click(object sender, EventArgs e)
        {
            String id = "PO18";
            AddDetails(id);
        }

        protected void btnView11_Click(object sender, EventArgs e)
        {
            String id = "PO2";
            AddDetails(id);
        }

        protected void btnView12_Click(object sender, EventArgs e)
        {
            String id = "PO3";
            AddDetails(id);
        }

        protected void btnView13_Click(object sender, EventArgs e)
        {
            String id = "PO4";
            AddDetails(id);
        }

        protected void btnView14_Click(object sender, EventArgs e)
        {
            String id = "PO5";
            AddDetails(id);
        }

        protected void btnView15_Click(object sender, EventArgs e)
        {
            String id = "PO6";
            AddDetails(id);
        }

        protected void btnView16_Click(object sender, EventArgs e)
        {
            String id = "PO7";
            AddDetails(id);
        }

        protected void btnView17_Click(object sender, EventArgs e)
        {
            String id = "PO8";
            AddDetails(id);
        }

        protected void btnView18_Click(object sender, EventArgs e)
        {
            String id = "PO9";
            AddDetails(id);
        }

        protected void Add_ItemCommand(object source, DataListCommandEventArgs e)
        {
 
               
            string imgName;
            string id;
            if (e.CommandName == "Addfavourite")
            {
                imgName = e.CommandArgument.ToString();
                Label1.Text = imgName;
                String sdi = "SELECT * FROM Img WHERE Title=@title";
                SqlCommand cmdAdd = new SqlCommand(sdi, con);

                cmdAdd.Parameters.AddWithValue("@title", imgName);
                SqlDataReader dtrProd = cmdAdd.ExecuteReader();

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
                    title = e.CommandArgument.ToString();
                    Label1.Text = title;
                    string add = "INSERT INTO Favourite VALUES (@name, @photo, @price, @CustName)";
                    SqlCommand favourite = new SqlCommand(add, con);


                    favourite.Parameters.AddWithValue("@name", title);
                    favourite.Parameters.AddWithValue("@photo", img);
                    favourite.Parameters.AddWithValue("@price", price);
                    favourite.Parameters.AddWithValue("@CustName", CustomerName);

                    favourite.ExecuteNonQuery();
                    con.Close();

                }
            }
            else if (e.CommandName == "Details")
            {
                imgName = e.CommandArgument.ToString();
                //string strAdd = "Delete From Details";
                imgName = e.CommandArgument.ToString();
                Label1.Text = imgName;
                String sdi = "SELECT * FROM Img WHERE Title=@title";
                SqlCommand cmdAdd = new SqlCommand(sdi, con);

                cmdAdd.Parameters.AddWithValue("@title", imgName);
                SqlDataReader dtrProd = cmdAdd.ExecuteReader();

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

                    string add = "INSERT INTO [Details] VALUES (@id, @cust, @name, @photo, @price, @CustName)";
                    SqlCommand details = new SqlCommand(add, con);

                    details.Parameters.AddWithValue("@id", details_id);
                    details.Parameters.AddWithValue("@cust", custname);
                    details.Parameters.AddWithValue("@name", title);
                    details.Parameters.AddWithValue("@photo", img);
                    details.Parameters.AddWithValue("@price", price);
                    details.Parameters.AddWithValue("@CustName", CustomerName);
                   
                   // details.Parameters.AddWithValue("@imgId", imgName);

                    details.ExecuteNonQuery();
                    con.Close();
                    Response.Redirect("~/CWK/ASPX/Details.aspx");
                }
            }
        }
        

        public void AddDetails(string Detid)
        {
            string strAdd = "Delete From Details";
            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            cmdAdd.ExecuteNonQuery();
            con.Close();
            con.Open();

            SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE PostId=@PostId", con);
            String id = Detid;
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

                string add = "INSERT INTO [Details] VALUES (@id, @cust, @name, @photo, @price, @CustName, @imgId)";
                SqlCommand details = new SqlCommand(add, con);

                details.Parameters.AddWithValue("@id", details_id);
                details.Parameters.AddWithValue("@cust", custname);
                details.Parameters.AddWithValue("@name", title);
                details.Parameters.AddWithValue("@photo", img);
                details.Parameters.AddWithValue("@price", price);
                details.Parameters.AddWithValue("@CustName", CustomerName);
                details.Parameters.AddWithValue("@imgId", Detid);

                details.ExecuteNonQuery();
                con.Close();
                Response.Redirect("~/CWK/ASPX/Details.aspx");

            }
        }
        private void GenerateDetailsId()
        {
            SqlCommand cmdId = new SqlCommand("Select Count(DetailsId) FROM Details", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            details_id = "PO" + i.ToString();
        }
    }
}