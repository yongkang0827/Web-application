using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Assignment.TYK.ASPX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox AdultNo = PreviousPage.FindControl("TextBox1") as TextBox;

                Label1.Text = "Departure Date : " + AdultNo.Text;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             
        }
    }
}