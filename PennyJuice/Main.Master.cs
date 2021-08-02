using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PennyJuice
{
    public partial class Main1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Master/ASPX/custHome.aspx");
        }

        protected void btnAL_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HDY/ASPX/gallery.aspx");
        }

        protected void btnArtL_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LMY/ASPX/Payment.aspx");
        }
    }
}