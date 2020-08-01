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
    public partial class resmaker : System.Web.UI.Page
    {  int num1 = 0, num2 = 0;
        int count1 = 0, count2 = 0;
        int[] food ;
        protected void Page_Load(object sender, EventArgs e)
        {if (!IsPostBack)
            {


                ListBox1.Height = 200;
                ListBox2.Height = 200;
                preset();


                string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
                MySqlConnection sqlconn = new MySqlConnection(mainconn);
                string sqlq = "SELECT * FROM resv ";
                MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
                sqlconn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                sqlconn.Close();
                sqlconn.Close();

                dt.Columns["table_id"].ColumnName = "Table ID";
                dt.Columns["ord"].ColumnName = "Order";
                dt.Columns["totalprice"].ColumnName = "Total Cost";
                dt.Columns.RemoveAt(3);


            GridView1.DataSource = dt;
            GridView1.DataBind();


            string mainconn1 = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn1 = new MySqlConnection(mainconn1);
            string sqlq1 = "SELECT * FROM tables ";
            MySqlCommand sqlcmd1 = new MySqlCommand(sqlq1, sqlconn1);
            sqlconn1.Open();
            MySqlDataAdapter sda1 = new MySqlDataAdapter(sqlcmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);


            sqlconn1.Close();
            dt1.Columns[0].ColumnName = "Avalable Tables";
            dt1.Columns[1].ColumnName = "Chares";

            // GridView1.Columns.Clear();

            GridView2.DataSource = dt1;
            GridView2.DataBind();

               
            }
            createf();
            createf2();
           
        }



        void createf(){

            for (int i = 0; i < ListBox1.Items.Count; i++) {
                TextBox tb1 = new TextBox();
                tb1.ID = i + "";

                tb1.Text = "1";
                Label name = new Label();
                name.Text = ListBox1.Items[i] + "";
                name.ID = "l" + i;
                tb1.TextMode = TextBoxMode.Number;
                name.Visible = false;
                tb1.Visible = false;
                ph.Controls.Add(name);
                ph.Controls.Add(tb1);
            }
            


            }
        void createf2()
        {

            for (int i = 0; i < ListBox2.Items.Count; i++)
            {
                TextBox tb1 = new TextBox();
                tb1.ID = i + "2";

                tb1.Text = "1";
                Label name = new Label();
                name.Text = ListBox2.Items[i] + "";
                name.ID = "l2" + i;
                tb1.TextMode = TextBoxMode.Number;
                name.Visible = false;
                tb1.Visible = false;
                ph2.Controls.Add(name);
                ph2.Controls.Add(tb1);
            }

        }
        int counter1()
        {
            int c = 0;
            foreach (int i in ListBox1.GetSelectedIndices())
            {
                c++;
            }
            return c;
        }
        int counter2()
        {
            int c = 0;
            foreach (int i in ListBox2.GetSelectedIndices())
            {
                c++;
            }
            return c;
        }
        int [] foodfill() {
           int[] food = new int[ListBox1.Items.Count];
            int x = 0;
            foreach (int i in ListBox1.GetSelectedIndices())
            {
                food[x] = i;

                x = x + 1;
        





            }

            return food;
        }

        int[] drinkfill()
        {
            int[] food = new int[ListBox2.Items.Count];
            int x = 0;
            foreach (int i in ListBox2.GetSelectedIndices())
            {
                food[x] = i;

                x = x + 1;






            }

            return food;
        }



        int getPriceD(string str) {
            string st = str;
            int x = 0;

            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM drink WHERE drink_name = '" + str + "'";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {


                foreach (DataRow row in dt.Rows)
                {


                  
                    x = Convert.ToInt32( row["price"].ToString());





                }
            }
            sqlconn.Close();



            return x;
        }

        int getPriceF(string str)
        {
            string st = str;
            int x = 0;

            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM food WHERE food_name = '" + str + "'";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {


                foreach (DataRow row in dt.Rows)
                {



                    x = Convert.ToInt32(row["price"].ToString());





                }
            }
            sqlconn.Close();



            return x;
        }



        protected void LinkButton1_Click(object sender, EventArgs e)
        {



           
         
            foreach (int i in ListBox1.GetSelectedIndices())
            {
               

                ph.FindControl("" + i).Visible = true; ;
                ph.FindControl("l" + i).Visible = true; ;


              

            }

           
            foreach (int i in ListBox2.GetSelectedIndices())
            {
             

                ph2.FindControl( i+"2").Visible = true; ;
                ph2.FindControl("l2" + i).Visible = true; ;




            }



        }
      
        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int pricefood = 0;
            int[] fo = foodfill();
            String s="";
            for (int i =0; i < counter1(); i++) {

            TextBox temp = ph.FindControl(fo[i]+"") as TextBox;
                pricefood += (getPriceF(ListBox1.Items[fo[i]] + "") * Convert.ToInt32(temp.Text));

                if (counter1() - i == 1)
                {
                    s = s + ListBox1.Items[fo[i]] + "(" + temp.Text + ")";
                }
                else {
                    s = s + ListBox1.Items[fo[i]] + "(" + temp.Text + "),";

                }


            }



         



            int pricedr = 0;

            int[] dr = drinkfill();
            String ss = "";
            for (int i = 0; i < counter2(); i++)
            {

                

                TextBox temp = ph2.FindControl(dr[i] + "2") as TextBox;
                pricedr += (getPriceD(ListBox2.Items[dr[i]] + "") * Convert.ToInt32( temp.Text));
                if (counter2() - i == 1)
                {
                    ss = ss + ListBox2.Items[dr[i]] + "(" + temp.Text + ")";
                }
                else
                {
                    ss = ss + ListBox2.Items[dr[i]] + "(" + temp.Text + "),";

                }


            }
            String order = s + "," + ss;
            int totalprice = pricefood + pricedr;

            if (thereis())
            {

                add(order, totalprice);


            }
            else {
                Response.Write("<script>alert('Table Does Not Exist.');</script>");

            }

     




        }
        void add(string ord,int price)
        {

            string or = ord;
            int pr = price;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);

            string sqlq = "INSERT INTO resv(table_id,ord,totalprice) VALUES('" + TextBox1.Text.Trim() + "','" + or+ "','" +pr + "')";

            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();


            sqlconn.Close();
            Response.Redirect("resmaker.aspx");
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        bool thereis()
        {
            bool thereis = false;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM tables WHERE table_id = '" + TextBox1.Text.Trim() + "'";
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

       

        void preset()
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT food_name FROM food";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ListBox1.DataSource = dt;
          
            ListBox1.DataValueField = "food_name";

            ListBox1.DataBind();
            
            sqlconn.Close();

            string mainconn1 = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn1 = new MySqlConnection(mainconn1);
            string sqlq1 = "SELECT drink_name FROM drink";
            MySqlCommand sqlcmd1 = new MySqlCommand(sqlq1, sqlconn1);
            sqlconn1.Open();
            MySqlDataAdapter sda1 = new MySqlDataAdapter(sqlcmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            ListBox2.DataSource = dt1;
            ListBox2.DataValueField = "drink_name";
            ListBox2.DataBind();
            sqlconn1.Close();

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //Check your condition here
                    DateTime dt = Convert.ToDateTime(e.Row.Cells[5].Text);
                    DateTime today = DateTime.Today;
                    if (today > dt)
                    {
                        e.Row.BackColor = System.Drawing.Color.PaleVioletRed;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}