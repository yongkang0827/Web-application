﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace test2.LMY.ASPX
{
    public partial class OnlinePayment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        int randomPin;
        string CustomerName, history_id;
        double totalPrice = 0, totalItemPrice = 0;
        int num = 0;
        string imgName, imgQuantity, imgPrice, price, quantImg;
        String[] ImgArray = new string[50];
        String[] ImgQuant = new string[50];
        String[] ImgPric = new string[50];
        byte[] img;
        int oldQuantity, newQuantity;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblAllName.Text = " ";
            lblAllQuant.Text = " ";
            lblAllPrice.Text = " ";
            lblAllTotalPrice.Text = " ";
            totalPrice = 0;
            num = 0;

            TextBox1.Text = DateTime.Now.ToString();
            CustomerName = Session["CustName"].ToString();
            GenerateHistoryId();

            con.Open();
            SqlCommand sdi = new SqlCommand("SELECT * FROM OrderList WHERE Buy=@yes AND CustName=@cust", con);

            sdi.Parameters.AddWithValue("@yes", "true");
            sdi.Parameters.AddWithValue("@cust", CustomerName);
            SqlDataReader dtrProdSel = sdi.ExecuteReader();

            if (dtrProdSel.HasRows)
            {
                while (dtrProdSel.Read())
                {
                    imgName = dtrProdSel["ImageName"].ToString();
                    //ImgArray[num] += imgName;
                    lblAllName.Text += imgName + "</br>";

                    imgQuantity = dtrProdSel["Quantity"].ToString();
                    //ImgQuant[num] += imgQuantity;
                    lblAllQuant.Text += imgQuantity + "</br>";

                    imgPrice = dtrProdSel["Price"].ToString();
                    //ImgPric[num] += imgPrice;
                    lblAllPrice.Text += imgPrice + "</br>";

                    totalItemPrice = Convert.ToDouble(imgPrice) * Convert.ToInt32(imgQuantity);
                    lblAllTotalPrice.Text += Convert.ToString(totalItemPrice) + "</br>";

                    totalPrice += totalItemPrice;

                    num = num + 1;
                }
            }
            lblTotalPay.Text = Convert.ToString(totalPrice);
            con.Close();
        }

        protected void btnSearchPin_Click(object sender, EventArgs e)
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
        private void GenerateHistoryId()
        {
            con.Open();
            SqlCommand cmdId = new SqlCommand("Select Count(HistoryId) FROM PurchaseHistory", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            history_id = "HO" + i.ToString();
            con.Close();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HDY/ASPX/gallery.aspx");
        }

        protected void btnPay_Click(object sender, EventArgs e)
        {
            num = 0;
            con.Open();
            SqlCommand sdi = new SqlCommand("SELECT * FROM OrderList WHERE Buy=@yes AND CustName=@cust", con);

            sdi.Parameters.AddWithValue("@yes", "true");
            sdi.Parameters.AddWithValue("@cust", CustomerName);
            SqlDataReader dtrProdSel = sdi.ExecuteReader();

            if (dtrProdSel.HasRows)
            {
                while (dtrProdSel.Read())
                {
                    imgName = dtrProdSel["ImageName"].ToString();
                    ImgArray[num] += imgName;

                    imgQuantity = dtrProdSel["Quantity"].ToString();
                    ImgQuant[num] += imgQuantity;

                    imgPrice = dtrProdSel["Price"].ToString();
                    ImgPric[num] += imgPrice;
                    num = num + 1;
                }
            }
            con.Close();
            ImgSave();
        }

        protected void ImgSave()
        {
            int i;
            for (i = 0; i < num; i++)
            {
                con.Open();

                SqlCommand sdi = new SqlCommand("SELECT * FROM Img WHERE Title=@imgName", con);
                sdi.Parameters.AddWithValue("@imgName", ImgArray[i]);
                SqlDataReader dtrProd = sdi.ExecuteReader();

                if (dtrProd.HasRows)
                {
                    while (dtrProd.Read())
                    {
                        price = dtrProd["Price"].ToString();
                        img = (byte[])(dtrProd["ImgUpload"]);
                    }
                }
                con.Close();
                GenerateHistoryId();
                Payment(ImgArray[i]);
            }
        }

        private void Payment(String ImageParaName)
        {
            if (Session["Pin"] == null)
            {
                String msg = "Please press pin button to get pin number";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
            else
            {
                if (Session["Pin"].ToString().Equals(txtPin.Text))
                {
                    if (HavePurchaseRow(ImageParaName))
                    {
                        con.Open();
                        SqlCommand sdi = new SqlCommand("SELECT * FROM PurchaseHistory Where CustName=@name AND ImageName=@imgName", con);

                        sdi.Parameters.AddWithValue("@name", CustomerName);
                        sdi.Parameters.AddWithValue("@imgName", ImageParaName);
                        SqlDataReader dtrProd = sdi.ExecuteReader();

                        if (dtrProd.HasRows)
                        {
                            while (dtrProd.Read())
                            {
                                oldQuantity = Convert.ToInt32(dtrProd["Quantity"].ToString());
                            }
                        }
                        con.Close();

                        con.Open();
                        SqlCommand sdiNew = new SqlCommand("SELECT * FROM OrderList Where CustName=@name AND ImageName=@imgName", con);

                        sdiNew.Parameters.AddWithValue("@name", CustomerName);
                        sdiNew.Parameters.AddWithValue("@imgName", ImageParaName);
                        SqlDataReader dtrProdNew = sdiNew.ExecuteReader();

                        if (dtrProdNew.HasRows)
                        {
                            while (dtrProdNew.Read())
                            {
                                newQuantity = Convert.ToInt32(dtrProdNew["Quantity"].ToString());
                            }
                        }
                        con.Close();

                        con.Open();
                        String stringQuantity = Convert.ToString(oldQuantity + newQuantity);

                        string strAdd = "Update PurchaseHistory Set Quantity = @quant Where CustName=@name AND ImageName=@imgName";
                        SqlCommand cmdAdd = new SqlCommand(strAdd, con);

                        cmdAdd.Parameters.AddWithValue("@name", CustomerName);
                        cmdAdd.Parameters.AddWithValue("@imgName", ImageParaName);
                        cmdAdd.Parameters.AddWithValue("@quant", stringQuantity);



                        cmdAdd.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        string strDelete = "Delete From OrderList Where ImageName=@imgName AND CustName=@name";
                        SqlCommand cmdDelete = new SqlCommand(strDelete, con);

                        cmdDelete.Parameters.AddWithValue("@name", CustomerName);
                        cmdDelete.Parameters.AddWithValue("@imgName", ImageParaName);
                        cmdDelete.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {

                        con.Open();
                        SqlCommand sdi = new SqlCommand("SELECT * FROM OrderList WHERE  CustName=@name AND ImageName=@imgName", con);

                        sdi.Parameters.AddWithValue("@name", CustomerName);
                        sdi.Parameters.AddWithValue("@imgName", ImageParaName);
                        SqlDataReader dtrProd = sdi.ExecuteReader();

                        if (dtrProd.HasRows)
                        {
                            while (dtrProd.Read())
                            {
                                quantImg = dtrProd["Quantity"].ToString();
                            }

                            con.Close();
                            con.Open();

                            string add = "INSERT INTO PurchaseHistory VALUES (@id, @cust, @name, @date, @photo, @price,@quantity)";
                            SqlCommand history = new SqlCommand(add, con);

                            history.Parameters.AddWithValue("@id", history_id);
                            history.Parameters.AddWithValue("@cust", CustomerName);
                            history.Parameters.AddWithValue("@name", ImageParaName);
                            history.Parameters.AddWithValue("@date", TextBox1.Text);
                            history.Parameters.AddWithValue("@photo", img);
                            history.Parameters.AddWithValue("@price", price);
                            history.Parameters.AddWithValue("@quantity", quantImg);

                            history.ExecuteNonQuery();

                        }
                        con.Close();

                        con.Open();
                        string strDelete = "Delete From OrderList Where ImageName=@imgName AND CustName=@name";
                        SqlCommand cmdDelete = new SqlCommand(strDelete, con);

                        cmdDelete.Parameters.AddWithValue("@name", CustomerName);
                        cmdDelete.Parameters.AddWithValue("@imgName", ImageParaName);
                        cmdDelete.ExecuteNonQuery();
                        con.Close();
                    }
                    SendMail();
                }
                else
                {
                    String msg = "Invalid Pin Number";
                    Response.Write("<script>alert('" + msg + "')</script>");
                }
            }
        }

        public Boolean HavePurchaseRow(String name)
        {
            con.Close();
            con.Open();

            SqlCommand check = new SqlCommand("SELECT * FROM PurchaseHistory WHERE CustName=@Cust AND ImageName=@img", con);

            check.Parameters.AddWithValue("@Cust", CustomerName);
            check.Parameters.AddWithValue("@img", name);
            SqlDataReader dtr = check.ExecuteReader();

            if (dtr.HasRows)
            {
                con.Close();
                return true;

            }

            con.Close();
            return false;
        }
        protected void SendMail()
        {
            try
            {
                String toEmail = "artistweblimgrp@gmail.com";
                String fromEmail = "limmy-wm18@student.tarc.edu.my";
                String headEmail = "Art Website Purchase Notice";
                String totalImgName = " ";
                int i;
                for (i = 0; i < num; i++)
                {
                    totalImgName = totalImgName +
                        "<br>Name = " + ImgArray[i] + ", Quantity = " + ImgQuant[i] + ", Price per each = " + ImgPric[i];
                }
                String bodyEmail = "You Have Purchase : " + totalImgName;
                bodyEmail += "</br> Total Prices : " + totalPrice;

                MailMessage message = new MailMessage(fromEmail, toEmail, headEmail, bodyEmail);
                message.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("artistweblimgrp@gmail.com", "artistweb123");
                client.Send(message);

                //String msg = "Email Sended";
                //Response.Write("<script>alert('" + msg + "')</script>");
                //Response.Redirect("~/HDY/ASPX/gallery.aspx");
            }
            catch (Exception ex)
            {
                String msg = "Email Send Error";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
        }
    }
}