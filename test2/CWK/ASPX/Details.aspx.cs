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
using System.Net.Mail;

namespace test2.CWK.ASPX
{
    public partial class Details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        String ArtistName;
        String history_id;
        string CustomerName, title, price;
        byte[] img;
        String order_id;
        int quantity, newQuantity;
        int randomPin;

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
            txtDate.Text = txtPin.Text + "   " + Session["Pin"].ToString();
            if (Session["Pin"].ToString().Equals(txtPin.Text))
            {
                if (HavePurchaseRow())
                {
                    con.Open();
                    SqlCommand sdi = new SqlCommand("SELECT * FROM PurchaseHistory Where CustName=@name AND ImageName=@imgName", con);

                    sdi.Parameters.AddWithValue("@name", CustomerName);
                    sdi.Parameters.AddWithValue("@imgName", title);
                    SqlDataReader dtrProd = sdi.ExecuteReader();

                    if (dtrProd.HasRows)
                    {
                        while (dtrProd.Read())
                        {
                            quantity = Convert.ToInt32(dtrProd["Quantity"].ToString());

                        }
                    }
                    newQuantity = quantity + Convert.ToInt32(txtQty.Text);
                    con.Close();

                    con.Open();
                    string strAdd = "Update PurchaseHistory Set Quantity = @quant Where CustName=@name AND ImageName=@imgName";
                    SqlCommand cmdAdd = new SqlCommand(strAdd, con);

                    cmdAdd.Parameters.AddWithValue("@name", CustomerName);
                    cmdAdd.Parameters.AddWithValue("@imgName", title);
                    cmdAdd.Parameters.AddWithValue("@quant", newQuantity);



                    cmdAdd.ExecuteNonQuery();
                    con.Close();
                }
                else
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
                }
                SendMail(title, txtQty.Text);
            }
            else
            {
                String msg = "Invalid Pin Number";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
        }

        public Boolean HavePurchaseRow()
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
            }
            con.Close();
            ////////////////////////////////
            //Checking
            con.Open();

            SqlCommand check = new SqlCommand("SELECT * FROM PurchaseHistory WHERE CustName=@Cust AND ImageName=@img", con);

            check.Parameters.AddWithValue("@Cust", CustomerName);
            check.Parameters.AddWithValue("@img", title);
            SqlDataReader dtr = check.ExecuteReader();

            if (dtr.HasRows)
            {
                con.Close();
                return true;
            }

            con.Close();
            return false;
        }


        protected void SendMail(String imgName, String totalBuy)
        {
            try
            {
                String toEmail = "artistweblimgrp@gmail.com";
                String fromEmail = "limmy-wm18@student.tarc.edu.my";
                String headEmail = "Art Website Purchase Notice";
                String bodyEmail = "You Have Purchase : " + imgName + " with quantity = " + totalBuy;

                MailMessage message = new MailMessage(fromEmail, toEmail, headEmail, bodyEmail);
                message.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("artistweblimgrp@gmail.com", "artistweb123");
                client.Send(message);

                String msg = "Email Sended";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
            catch (Exception ex)
            {
                String msg = "Email Send Error";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
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

        protected void PinNumber(object sender, EventArgs e)
        {
            Random random = new Random();
            randomPin = random.Next(100000, 999999);
            Session["Pin"] = Convert.ToString(randomPin);
            try
            {
                String toEmail = "artistweblimgrp@gmail.com";
                String fromEmail = "artistweblimgrp@gmail.com";
                String headEmail = "Credit Card Pin Number";
                String bodyEmail = "Pin Number is " + Convert.ToString(randomPin);

                MailMessage message = new MailMessage(fromEmail, toEmail, headEmail, bodyEmail);
                message.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("artistweblimgrp@gmail.com", "artistweb123");
                client.Send(message);

                String msg = "Email Sended";
                Response.Write("<script>alert('" + msg + "')</script>");




            }
            catch (Exception ex)
            {
                String msg = "Email Send Error";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
        }
    }
}