using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Data;

namespace test2.CWK.ASPX
{
    public partial class Details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        String ArtistName;
        String history_id;
        string CustomerName, title, price;
        int currentQty, purchaseQty;
        byte[] img;
        String order_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetArtistName();
            GetCustomerName();
            con.Open();
            GenerateOrderId();
            GenerateHistoryId();
            if (!this.IsPostBack)
            {             
                txtDate.Text = DateTime.Now.ToString();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Details", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dlDetails.DataSource = dt;
                dlDetails.DataBind();
              
            }

        }
        

        protected void GetArtistName()
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
                    ArtistName = dtrProd["Username"].ToString();
                }
            }
            con.Close();

        }

        protected void dlDetails_ItemDataBound(object sender, DataListItemEventArgs e)
        {

            DataRowView dr = (DataRowView)e.Item.DataItem;
            string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["Image"]);
            (e.Item.FindControl("Image1") as Image).ImageUrl = imageUrl;
        }

        protected void btnBuyNow_Click(object sender, EventArgs e)
        {
            SqlCommand sdi = new SqlCommand("SELECT * FROM Details WHERE DetailsId=@PostId", con);

            sdi.Parameters.AddWithValue("@PostId", "PO1");
            SqlDataReader dtrPr = sdi.ExecuteReader();
            string detailsid = " ";

            if (dtrPr.HasRows)
            {
                while (dtrPr.Read())
                {
                    detailsid = dtrPr["detailsid"].ToString();
                }
            }
            con.Close();
            Purchase(detailsid);
          
           
        }


        public void Purchase(string WantBuyid)
        {
            //Store in purchase history
            con.Open();
            SqlCommand sdi = new SqlCommand("SELECT * FROM Details", con);

            SqlDataReader dtrProd = sdi.ExecuteReader();

            if (dtrProd.HasRows)
            {
                while (dtrProd.Read())
                {
                    title = dtrProd["ImageName"].ToString();
                    price = dtrProd["Price"].ToString();

                    img = (byte[])(dtrProd["Image"]);
                }

                con.Close();
                con.Open();
                
                string add = "INSERT INTO PurchaseHistory VALUES (@id, @cust, @name, @date, @photo, @price,@quantity)";
                SqlCommand history = new SqlCommand(add, con);

                history.Parameters.AddWithValue("@id", history_id);
                history.Parameters.AddWithValue("@cust", CustomerName);
                history.Parameters.AddWithValue("@name", title);
                history.Parameters.AddWithValue("@date", txtDate.Text);
                history.Parameters.AddWithValue("@photo", img);
                history.Parameters.AddWithValue("@price", price);              
                history.Parameters.AddWithValue("@quantity", txtQty.Text);//add quantity in purchase history

                history.ExecuteNonQuery();
                
            }
            con.Close();

            //Update Stock
            con.Open();
            string updateStk = "Select Quantity from Img where Title=@title";
            SqlCommand updateQuery = new SqlCommand(updateStk, con);
            updateQuery.Parameters.AddWithValue("@title", title);

            SqlDataReader dtrUpdate = updateQuery.ExecuteReader();

            if (dtrUpdate.HasRows)
            {
                while (dtrUpdate.Read())
                {
                    currentQty = (int)dtrUpdate["Quantity"];
                    purchaseQty = Int32.Parse(txtQty.Text);
                }
            }
            con.Close();
            currentQty -= purchaseQty;

            con.Open();
            string reduceStk = "UPDATE Img SET Quantity = @Quantity WHERE Title=@title";
            SqlCommand reduceQuery = new SqlCommand(reduceStk, con);
            reduceQuery.Parameters.AddWithValue("@Quantity", currentQty);
            reduceQuery.Parameters.AddWithValue("@title", title);
            reduceQuery.ExecuteNonQuery();
            con.Close();

            //Store in order
            //con.Open();
            //SqlCommand sdOrder = new SqlCommand("SELECT * FROM Details", con);


            //SqlDataReader dtrPro = sdOrder.ExecuteReader();

            //if (dtrPro.HasRows)
            //{
            //    while (dtrPro.Read())
            //    {
            //        CustomerName = dtrPro["CustName"].ToString();
            //        title = dtrPro["ImageName"].ToString();
            //        price = dtrPro["Price"].ToString();

            //        img = (byte[])(dtrPro["Image"]);

            //    }

            //    con.Close();
            //    con.Open();

            //    string add = "INSERT INTO [Order] VALUES (@id, @cust, @name, @photo, @price, @CustName)";
            //    SqlCommand order = new SqlCommand(add, con);

            //    order.Parameters.AddWithValue("@id", order_id);
            //    order.Parameters.AddWithValue("@cust", CustomerName);
            //    order.Parameters.AddWithValue("@name", title);
            //    order.Parameters.AddWithValue("@photo", img);
            //    order.Parameters.AddWithValue("@price", price);
            //    order.Parameters.AddWithValue("@CustName", CustomerName);

            //    order.ExecuteNonQuery();               
            //}
            //con.Close();
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

        protected void dlDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dlDetails_ItemCommand(object source, DataListCommandEventArgs e)
        {
            con.Open();
            SqlCommand sdi = new SqlCommand("SELECT * FROM Details", con);

            SqlDataReader dtrProd = sdi.ExecuteReader();
          
            if (dtrProd.HasRows)
            {
                while (dtrProd.Read())
                {
                    title = dtrProd["ImageName"].ToString();
                    price = dtrProd["Price"].ToString();

                    img = (byte[])(dtrProd["Image"]);
                }

                con.Close();
                con.Open();

                

                string add = "INSERT INTO PurchaseHistory VALUES (@id, @cust, @name, @date, @photo, @price,@quantity)";
                SqlCommand history = new SqlCommand(add, con);

                history.Parameters.AddWithValue("@id", history_id);
                history.Parameters.AddWithValue("@cust", CustomerName);
                history.Parameters.AddWithValue("@name", title);
                history.Parameters.AddWithValue("@date", txtDate.Text);
                history.Parameters.AddWithValue("@photo", img);
                history.Parameters.AddWithValue("@price", price);
                history.Parameters.AddWithValue("@quantity",txtQty.Text);//add quantity in purchase history

                history.ExecuteNonQuery();

               

            }
            con.Close();
        }

            private void GenerateHistoryId()
        {
            SqlCommand cmdId = new SqlCommand("Select Count(HistoryId) FROM PurchaseHistory", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            history_id = "HO" + i.ToString();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            string strAdd = "Delete From Details";
            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            cmdAdd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/HDY/ASPX/Gallery.aspx");
        }     
    }
}