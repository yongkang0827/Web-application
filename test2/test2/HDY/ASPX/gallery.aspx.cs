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
        String new_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
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
            SqlDataAdapter sdi = new SqlDataAdapter("SELECT * FROM Img WHERE PostId=@PostId", con);
            //cmd.Parameters.AddWithValue("@id", new_id);
            //cmd.Parameters.AddWithValue("@photo", bytes);


        }

        private void GenerateId()
        {
            SqlCommand cmdId = new SqlCommand("Select Count(ImgId) FROM ImgFav", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            new_id = "FO" + i.ToString();
        }
    }
}