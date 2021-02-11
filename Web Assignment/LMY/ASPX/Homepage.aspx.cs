using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Assignment.LMY.ASPX
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBookTkt_Click(object sender, EventArgs e)
        {
            Session["pg1"] = TextBox1.Text;
            Response.Redirect("~/LMY/ASPX/Test.aspx");

            Session["pg2"] = TextBox1.Text;
            Response.Redirect("~/TYK/ASPX/WebForm1.aspx");
        }
    }
}