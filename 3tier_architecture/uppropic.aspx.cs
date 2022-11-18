using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3tier_architecture
{
    public partial class uppropic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                imagedata();
            }
        }

        private void imagedata()
        {
            userBD.Class1 objpic = new userBD.Class1();
            DataSet dt = objpic.uppicture(Convert.ToInt32(Session["id"]));
            DataSet ds = new DataSet();
            ds = dt;
            for (int i = 0; i < dt.Tables.Count; i++)
            {
                string url = ds.Tables[0].Rows[i]["image"].ToString();
                Image1.ImageUrl = url;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (FileUpload1.PostedFile != null)
            {
                string strpath = Path.GetExtension(FileUpload1.FileName);
                if (strpath != ".jpg" && strpath != ".jpeg" && strpath != ".png")
                {
                    Label1.Text = "Only images files Allowed(jpg,jpeg,png) !";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }

                string fileimg = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/image/") + fileimg);

                userBD.Class1 objp = new userBD.Class1();
                string img = "~/image/" + fileimg;
                objp.pic(Convert.ToInt32(Session["id"]), img);

                Response.Redirect("home.aspx");
            }
        }
    }
}