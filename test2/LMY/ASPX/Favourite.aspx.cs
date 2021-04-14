using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test2.LMY.ASPX
{
    public partial class Favourite : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        string CustomerName;

        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerName = (string)Session["CustName"];
            con.Open();
            if (!IsPostBack)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Favourite WHERE CustName = @filter", con);

                try
                {               
                    string filter = CustomerName;
                    sda.SelectCommand.Parameters.AddWithValue("@filter", CustomerName);
                }
                catch(SqlException sqlx)
                {
                    //string msg = "Data Binding Error occurred,Please visit after some time";
                    Response.Write("<script>alert('" + sqlx.Message + "')</script>");
                }

                try
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dlFavourite.DataSource = dt;
                    dlFavourite.DataBind();
                }
                catch(DataException ex)
                {
                    string msg = "Data Error";
                    Response.Write("<script>alert('" + msg + "')</script>");
                }
                catch(Exception ex)
                {
                    string msg = "Data Binding Error occurred,Please visit after some time";
                    Response.Write("<script>alert('" + msg + "')</script>");
                }                
            }
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (!IsPostBack)
            {
                DataRowView dr = (DataRowView)e.Item.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["Image"]);
                (e.Item.FindControl("Image1") as Image).ImageUrl = imageUrl;
            }
        }

        protected void dlFavourite_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string imgName;

            if (e.CommandName == "Unfavourite")
            {
                imgName = e.CommandArgument.ToString();


                string strAdd = "Delete From Favourite WHERE CustName=@custName and ImageName=@imgName";
                SqlCommand cmdAdd = new SqlCommand(strAdd, con);

                cmdAdd.Parameters.AddWithValue("@custName", CustomerName);
                cmdAdd.Parameters.AddWithValue("@imgName", imgName);

                cmdAdd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}