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
    public partial class Purchase_History : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            if (!this.IsPostBack)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PurchaseHistory", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dlHistory.DataSource = dt;
                dlHistory.DataBind();
            }
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {

            DataRowView dr = (DataRowView)e.Item.DataItem;
            string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["Image"]);
            (e.Item.FindControl("Image1") as Image).ImageUrl = imageUrl;

        }
    }
}