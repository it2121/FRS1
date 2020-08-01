using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace foody
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton7.Visible = false;
           
            try
            {
                if (Session["username"] == null)
                {

                    LinkButton2.Visible = false;
                    LinkButton3.Visible = false;
                    LinkButton1.Visible = true;
                    LinkButton4.Visible = false;


                }
                else
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = true;
                    LinkButton3.Visible = true;
                    LinkButton3.Visible = true;

                }
            }
            catch { }

         
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("drink.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("food.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["name"] = null;
            Response.Redirect("home.aspx");
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");

        }
    }
}