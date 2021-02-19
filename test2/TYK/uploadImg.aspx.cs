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

namespace test2.TYK
{
    public partial class uploadImg : System.Web.UI.Page
    {
        String ArtistID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            GetArtistID();
            con.Open();
            GenerateId();
            String query = "SELECT * FROM Img WHERE ArtistId LIKE'" + ArtistID + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            if (IsPostBack == false)
            {
                txtDate.Text = DateTime.Now.ToString();
                txtArtist.Text = ArtistID;
            }
        }


        protected void btnUpload_Click(object sender, EventArgs e)
        {
            byte[] byteImg;
            BinaryReader brImg = new BinaryReader(FileUpload1.PostedFile.InputStream);
            byteImg = brImg.ReadBytes(FileUpload1.PostedFile.ContentLength);

            string sql = "INSERT INTO Img VALUES(@PostId, @ImgUpload, @Title, @Description, @Quantity,@DateUpload,@ArtistId,@Price)";
            SqlCommand cmdUpload = new SqlCommand(sql, con);

            cmdUpload.Parameters.AddWithValue("@PostId", lblID.Text);
            cmdUpload.Parameters.AddWithValue("@ImgUpload", byteImg);
            cmdUpload.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmdUpload.Parameters.AddWithValue("@Description", txtDescribe.Text);
            cmdUpload.Parameters.AddWithValue("@Quantity", txtStock.Text);
            cmdUpload.Parameters.AddWithValue("@DateUpload", txtDate.Text);
            cmdUpload.Parameters.AddWithValue("@ArtistId", txtArtist.Text);
            cmdUpload.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmdUpload.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/TYK/Gallery.aspx");
        }

        private void GenerateId()
        {
            SqlCommand cmdId = new SqlCommand("Select Count(PostId) FROM Img", con);
            int i = Convert.ToInt32(cmdId.ExecuteScalar());
            i++;
            lblID.Text = "PO" + i.ToString();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Text = null;
            txtDescribe.Text = null;
            txtStock.Text = null;
            txtPrice.Text = null;
            FileUpload1.Dispose();
        }

        protected void GetArtistID()
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
                    ArtistID = dtrProd["Id"].ToString();
                }
            }
            con.Close();
        }


    }
}