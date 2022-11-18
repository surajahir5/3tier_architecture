using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3tier_architecture
{
    public partial class loginlayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            userDB.Class1 objbd=new userDB.Class1();
            DataSet result = objbd.log(TextBox1.Text, TextBox2.Text);
            DataSet ds = new DataSet();
            ds = result;
            if (ds.Tables[0].Rows.Count >0)
            {
                Session["id"]=ds.Tables[0].Rows[0]["id"].ToString();
                Session["name"] = ds.Tables[0].Rows[0]["name"].ToString();
                Session["usertype"] = ds.Tables[0].Rows[0]["usertype"].ToString();
                if (Session["usertype"].Equals("user"))
                {
                    Response.Redirect("home.aspx");
                }
                else{
                    Response.Redirect("admin.aspx");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Userlayer.aspx");
        }
    }
}