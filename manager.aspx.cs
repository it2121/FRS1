using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
namespace foody
{
    public partial class manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM tables ";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            sqlconn.Close();
            sqlconn.Close();



            dt.Columns["table_id"].ColumnName = "Table ID";
            dt.Columns["chares"].ColumnName = "Chares";

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void fill()
        {


            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM tables WHERE table_id = '" + TextID.Text.Trim() + "'";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {


                foreach (DataRow row in dt.Rows)
                {


                    TextCH.Text = row["chares"].ToString();





                }
            }
            sqlconn.Close();


        }

        void add()
        {


            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);

            string sqlq = "INSERT INTO tables(table_id,chares) VALUES('" + TextID.Text.Trim() + "','" + TextCH.Text.Trim() + "')";

            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();


            sqlconn.Close();
            refresh();
        }

        void refresh()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM tables ";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            sqlconn.Close();


            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        void up()
        {
            string mainconn1 = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn1 = new MySqlConnection(mainconn1);

            string sqlq1 = "UPDATE tables SET chares = '" + TextCH.Text.Trim() + "' WHERE table_id ='" + TextID.Text.Trim() + "'";
            MySqlCommand sqlcmd1 = new MySqlCommand(sqlq1, sqlconn1);
            sqlconn1.Open();
            sqlcmd1.ExecuteNonQuery();
            sqlconn1.Close();
            refresh();
        }
        void del()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);


            string sqlq = "DELETE FROM tables WHERE table_id ='" + TextID.Text.Trim() + "'";

            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();
            //Response.Write("<script>alert('The Deleting was Successful.');</script>");


            sqlconn.Close();
            refresh();

        }

        bool thereis()
        {
            bool thereis = false;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM tables WHERE table_id = '" + TextID.Text.Trim() + "'";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                thereis = true;
            }
            else { thereis = false; }
            return thereis;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (!thereis())
            {
                add();

            }
            else
            {
                Response.Write("<script>alert('Record Exist.');</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (thereis())
            {

                up();
            }
            else
            {
                Response.Write("<script>alert('Record Does Not Exist.');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (thereis())
            {

                del();
            }
            else
            {
                Response.Write("<script>alert('Record Does Not Exist.');</script>");
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if (thereis() == true)
            {
                fill();

            }
            else
            {
                Response.Write("<script>alert('Record Does Not Exist.');</script>");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}