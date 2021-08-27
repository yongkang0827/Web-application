using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PennyJuice
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

            if (e.CommandName == "viewArtist")
            {
                Session["ArtistList"] = e.CommandArgument.ToString();
                Response.Redirect("Details.aspx?id=" + e.CommandArgument.ToString());

            }
        }
    }
}