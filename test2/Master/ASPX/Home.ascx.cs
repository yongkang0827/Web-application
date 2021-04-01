using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test2.Master.ASPX
{
    public partial class Home : System.Web.UI.UserControl
    {
        public DateTime LoginTime;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginTime.Text = LoginTime.ToString();
            HttpCookie cookie = Request.Cookies["UserDetails"];
            if (cookie != null)
            {
                lblName.Text = cookie["Name"];
            }
            if (!IsPostBack)
            {
                slideShow();
            }
        }
        public void slideShow()
        {
            Random random = new Random();
            int i = random.Next(1, 5);
            Image1.ImageUrl = "../IMG/" + i.ToString() + ".jpg";

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            slideShow();
        }
    }
   }