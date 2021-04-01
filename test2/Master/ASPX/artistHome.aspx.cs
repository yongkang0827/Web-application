using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test2.Master.ASPX
{
    public partial class artistHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UC2.LoginTime = DateTime.Now;
        }
    }
}