using System;
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

namespace PennyJuice
{
    public partial class PayMoney : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        int randomPin;
        string name, address, postal, email;

        protected void Page_Load(object sender, EventArgs e)
        {
            name = (String)Session["Name"];
            address = (String)Session["Address"];
            postal = (String)Session["Postal"];
            email = (String)Session["Email"];

            int price = 0;
           
            con.Open();
            string strAdd = "SELECT * FROM Payment";
            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            cmdAdd.Parameters.AddWithValue("@Buy", "Yes");
            SqlDataReader dtrProd = cmdAdd.ExecuteReader();

            if (dtrProd.HasRows)
            {
                while (dtrProd.Read())
                {
                    price += Int32.Parse(dtrProd["Price"].ToString());
                }
            }
            con.Close();
        }

        protected void ReqPin_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            randomPin = random.Next(100000, 999999);
            Session["Pin"] = Convert.ToString(randomPin);
            try
            {
                String toEmail = email;
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

        protected void Pay_Click(object sender, EventArgs e)
        {
            if (Session["Pin"] == null)
            {
                String msg = "Please press pin button to get pin number";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
            else
            {
                if (Session["Pin"].ToString().Equals(Pin.Text))
                {
                    String msg = "Pay Successful";
                    Response.Write("<script>alert('" + msg + "')</script>");
                }
            }
        }
    }
}