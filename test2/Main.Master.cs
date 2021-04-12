using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        String name;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Menu1_MenuItemDataBound(object sender,MenuEventArgs e)
        {
            if (SiteMap.CurrentNode != null)
            {
                if(e.Item.Text==SiteMap.CurrentNode.Title)
                {
                    if (e.Item.Parent != null)
                    {
                        e.Item.Parent.Selected = true;

                    }
                    else
                    {
                        e.Item.Selected = true;
                    }
                }
            }
        }

        protected void Menu2_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            if (SiteMap.CurrentNode != null)
            {
                if (e.Item.Text == SiteMap.CurrentNode.Title)
                {
                    if (e.Item.Parent != null)
                    {
                        e.Item.Parent.Selected = true;

                    }
                    else
                    {
                        e.Item.Selected = true;
                    }
                }
            }
        }
    }
}