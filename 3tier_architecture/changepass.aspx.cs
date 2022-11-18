using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3tier_architecture
{

    public partial class changepass : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["intrn"].ToString());
        string str = null;
        SqlCommand com;
        byte up;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            str = "select * from usertask where id='" + Session["id"].ToString() + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                if (TextBox1.Text == reader["password"].ToString())
                {
                    up = 1;
                }
            }
            reader.Close();
            con.Close();
            if (up == 1)
            {
                userBD.Class1 objchange = new userBD.Class1();
                
                string password = TextBox2.Text;
                int results = objchange.Change(Convert.ToInt32(Session["id"]),password);
                if (results > 0)
                {
                    Response.Write("<script>alert('Password changed Successfully')</script>");
                    Response.Redirect("home.aspx");
                }
                   

            }
            else
            {
                Response.Write("<script>alert('Please enter correct Old password')</script>");
            }
        }
    }
}