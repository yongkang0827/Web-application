using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test2.ErrorPages
{
    public partial class GeneralError : System.Web.UI.Page
    {
        //    protected void Page_Load(object sender, EventArgs e)
        //    {
        //        //Place your code here
        //        if (Application["exception"] != null)
        //        {
        //            Exception ex = new Exception();
        //            ex = (Exception)Application["ex"];
        //            string FileUrl = (string)Application["location"];
        //            string msg = (string)Application["Message"];
        //            string InnerMsg = (string)Application["innerMessage"];

        //            Response.Write("<table width='60%' border='1'>");
        //            Response.Write("<tr><td><p style='background:Silver;<b>Alert,</br>'>");
        //            Response.Write("One error was encountered in : </br>" + FileUrl);
        //            Response.Write("page. <br/><font color=red>" + msg + "</font><br/>");
        //            Response.Write(InnerMsg + "<font></br></br>");
        //            Response.Write("</table>");



        //        }
        //        else
        //            Response.Write("No error");
        //    }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            //Place your code here
            if (Application["exception"] != null)
            {
                Exception ex = new Exception();
                ex = (Exception)Application["ex"];
                string FileUrl = (string)Application["location"];
                string msg = (string)Application["Message"];
                string InnerMsg = (string)Application["innerMessage"];

                try
                {
                    throw ex;
                }
                catch (DivideByZeroException)
                {
                    Response.Write("<table width='60%' border='1'>");
                    Response.Write("<tr><td><p style='background:Silver;<b>Alert,</br>'>");
                    Response.Write("One error was encountered in : </br>" + FileUrl);
                    Response.Write("page. <br/><font color=red>" + msg + "</font><br/>");
                    Response.Write(InnerMsg + "<font></br></br>");
                    Response.Write("</table>");

                    try
                    {
                        throw ex;
                    }
                    catch (Exception)
                    {
                        Response.Write("<br/> Exception 2");
                        Response.Write("</table>");
                    }
                }
                catch (Exception)
                {
                    Response.Write("<table width='60%' border='1'>");
                    Response.Write("<tr><td><p style='background:Silver;<b>Alert,</br>'>");
                    Response.Write("One error was encountered in : </br>" + FileUrl);
                    Response.Write("page. <br/><font color=red>" + msg + "</font><br/>");
                    Response.Write(InnerMsg + "<font></br></br>");
                    Response.Write("</table>");
                }




            }
            else
                Response.Write("No error");
        }
    }
}