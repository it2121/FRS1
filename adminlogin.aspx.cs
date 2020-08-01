using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace foody
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

         if (ch()==true)
            {


            }
           


        }
      
     
        bool ch()
        {

            bool ok = false;

            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM admins WHERE username = '" + TextBox1.Text.Trim() + "' AND password = '" + TextBox2.Text.Trim() + "'";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                ok = true;
                Session["username"] = TextBox1.Text.Trim();
                foreach (DataRow row in dt.Rows)
                {
                    Session["name"] = row["name"].ToString();
                }


                Response.Redirect("home.aspx");



            }
            else
            {

                Response.Write("<script>alert('username or password are not correct');</script>");


            }
            sqlconn.Close();






          
            return ok;
        }
      
    }
}