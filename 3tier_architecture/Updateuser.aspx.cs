using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class Updateuser : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["intrn"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                showdata();
            }
        }

        private void showdata()
        {
            userBD.Class1 class11 = new userBD.Class1();
            DataSet results = class11.show(Convert.ToInt32(Session["id"]));
            DataSet ds = new DataSet();
            ds = results;

            if (ds.Tables[0].Rows.Count>0)
            {
                TextBox1.Text = results.Tables[0].Rows[0]["name"].ToString();
                TextBox2.Text = results.Tables[0].Rows[0]["email"].ToString();
                TextBox3.Text = results.Tables[0].Rows[0]["mobile"].ToString();
                RadioButtonList1.SelectedValue = results.Tables[0].Rows[0]["gender"].ToString();
            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userBD.Class1 objdal = new userBD.Class1();
            string Name = TextBox1.Text;
            string Email = TextBox2.Text;
            string Mobile = TextBox3.Text;
            string Gender = RadioButtonList1.SelectedValue;
            int results = objdal.Update(Convert.ToInt32(Session["id"]), Name, Email, Mobile, Gender);
            if (results > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data Uploaded Successfully')", true);
                Response.Redirect("home.aspx");
            }
        }
       
    }
}
