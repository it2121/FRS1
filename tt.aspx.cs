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
    public partial class tt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM book_issue_tbl ";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            sqlconn.Close();
            sqlconn.Close();


            dt.Columns["member_id"].ColumnName = "Member Id";
            dt.Columns["member_name"].ColumnName = "Member Name";
            dt.Columns["book_id"].ColumnName = "Book Id";
            dt.Columns["book_name"].ColumnName = "Book Name";
            dt.Columns["issue_date"].ColumnName = "Issue Date";
            dt.Columns["due_date"].ColumnName = "Due Date";


            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}