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

namespace test2.LMY.ASPX
{
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        string CustomerName;
        int checkCheckBox = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            checkCheckBox = 0;

            CustomerName = (string)Session["CustName"];
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM OrderList WHERE CustName = @filter", conn))
                    {
                        string filter = CustomerName;
                        sda.SelectCommand.Parameters.AddWithValue("@filter", CustomerName);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        gvImages.DataSource = dt;
                        gvImages.DataBind();
                    }
                }
            }

        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["Image"]);
                (e.Row.FindControl("Image1") as Image).ImageUrl = imageUrl;
            }
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gvImages.Rows)
            {
                CheckBox status = (row.Cells[5].FindControl("Checkbox1") as CheckBox);
                string orderID = row.Cells[0].Text;
                if (status.Checked)
                {
                    updateRowSource(orderID, "true");
                    checkCheckBox += 1;
                }
                else
                {
                    updateRowSource(orderID, "false");
                }
            }

            if (checkCheckBox > 0)
            {
                if (RadioButtonList1.SelectedValue == "1")
                {
                    Response.Redirect("~/LMY/ASPX/MakePayment.aspx");
                }
                else if (RadioButtonList1.SelectedValue == "2")
                {
                    Response.Redirect("~/LMY/ASPX/OnlinePayment.aspx");
                }
            }
            else
            {
                string msg = "Please at least select one check box to buy";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
        }

        private void updateRowSource(String orderID, String markStatus)
        {
            con.Open();
            string strAdd = "Update OrderList Set Buy=@status Where OrderID=@buy";
            SqlCommand cmdAdd = new SqlCommand(strAdd, con);

            cmdAdd.Parameters.AddWithValue("@status", markStatus);
            cmdAdd.Parameters.AddWithValue("@buy", orderID);

            cmdAdd.ExecuteNonQuery();
            con.Close();
        }

        protected void Add_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //if (e.CommandName == "Cancel")
            //{
            //    //imgName = e.CommandArgument.ToString();
            //    //String sdi = "SELECT * FROM Img WHERE Title=@title";
            //    //SqlCommand cmdAdd = new SqlCommand(sdi, con);

            //    //cmdAdd.Parameters.AddWithValue("@title", imgName);
            //    //SqlDataReader dtrProd = cmdAdd.ExecuteReader();

            //    con.Open();
            //    string imgName = e.CommandArgument.ToString();
            //    string strAdd = "Delete From Details Where ImageName=@imgName";
            //    SqlCommand cmdDelete = new SqlCommand(strAdd, con);

            //    cmdDelete.Parameters.AddWithValue("@imgName", "ART");
            //    cmdDelete.ExecuteNonQuery();
            //    con.Close();
            //}
        }

        //protected void DeleteOrder(object sender, EventArgs e)
        //{
        //foreach (GridViewRow row in gvImages.Rows)
        //{
        //    Button status = (row.Cells[5].FindControl("btnCancel") as Button);
        //    string orderID = row.Cells[0].Text;
        //    if (status.Click)
        //    {
        //        updateRowSource(orderID, "true");
        //        checkCheckBox += 1;
        //    }
        //}

        //string imgName;

        //if (e.CommandName == "Cancel")
        //{
        //    imgName = e.CommandArgument.ToString();
        //    Response.Write(imgName);

        //string strAdd = "Delete From Favourite WHERE CustName=@custName and ImageName=@imgName";
        //SqlCommand cmdAdd = new SqlCommand(strAdd, con);

        //cmdAdd.Parameters.AddWithValue("@custName", CustomerName);
        //cmdAdd.Parameters.AddWithValue("@imgName", imgName);

        //cmdAdd.ExecuteNonQuery();
        //con.Close();
        //}
        //}
    }
}