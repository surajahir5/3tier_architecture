using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3tier_architecture
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindGrid1();
            }
        }

        private void BindGrid1()
        {
            userBD.Class1 odjbal = new userBD.Class1();
            Repeater1.DataSource = odjbal.BindGrid1(Convert.ToInt32(Session["id"]));
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                ((Label)e.Item.FindControl("lbl1")).Visible = false;
                ((Label)e.Item.FindControl("Label1")).Visible = false;
                ((Label)e.Item.FindControl("Label2")).Visible = false;
                ((Label)e.Item.FindControl("Label3")).Visible = false;
                ((Label)e.Item.FindControl("Label4")).Visible = false;
                ((Image)e.Item.FindControl("lbl_Image")).Visible = false;
                ((TextBox)e.Item.FindControl("TextBox1")).Visible = true;
                ((TextBox)e.Item.FindControl("TextBox2")).Visible = true;
                ((TextBox)e.Item.FindControl("TextBox3")).Visible = true;
                ((RadioButtonList)e.Item.FindControl("RadioButtonList1")).Visible = true;
                ((DropDownList)e.Item.FindControl("DropDownList1")).Visible = true;
                ((Image)e.Item.FindControl("Image1")).Visible = true;
                ((LinkButton)e.Item.FindControl("Linkedit")).Visible = false;
                //((LinkButton)e.Item.FindControl("lnkDelete")).Visible = false;
                ((LinkButton)e.Item.FindControl("Linkupdate")).Visible = true;
                ((LinkButton)e.Item.FindControl("Linkcancel")).Visible = true;
                // ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = true;
            }
            if (e.CommandName == "update")
            {
                try
                {
                string id = ((Label)e.Item.FindControl("label5")).Text;
                string name = ((TextBox)e.Item.FindControl("TextBox1")).Text;
               // string email = ((TextBox)e.Item.FindControl("email")).Text;
                string mobile = ((TextBox)e.Item.FindControl("TextBox3")).Text;
                string gender = ((RadioButtonList)e.Item.FindControl("RadioButtonList1")).SelectedValue;
                string usertype = ((DropDownList)e.Item.FindControl("DropDownList1")).SelectedValue;
                string image = ((Image)e.Item.FindControl("Image1")).ImageUrl;
                FileUpload FileUp = ((FileUpload)e.Item.FindControl("FileUpload1"));
                 string path = "~/image/";
                if (FileUp.HasFile)
                {
                    path += FileUp.FileName;
                   FileUp.SaveAs(MapPath(path));

                }
                else
                { 
                    Image img = (Image)e.Item.FindControl("Image1");
                    path = img.ImageUrl;
                }
                userBD.Class1 admup = new userBD.Class1();
                int results = admup.adminup(Convert.ToInt32(id),name,mobile,gender,usertype,image);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                BindGrid1();
            }
            if (e.CommandName == "cancel")
            {
                ((Label)e.Item.FindControl("lbl1")).Visible = true;
                ((Label)e.Item.FindControl("Label1")).Visible = true;
                ((Label)e.Item.FindControl("Label2")).Visible = true;
                ((Label)e.Item.FindControl("Label3")).Visible = true;
                ((Label)e.Item.FindControl("Label4")).Visible = true;
                ((Image)e.Item.FindControl("lbl_Image")).Visible = true;
                ((TextBox)e.Item.FindControl("TextBox1")).Visible = false;
                ((TextBox)e.Item.FindControl("TextBox2")).Visible = false;
                ((TextBox)e.Item.FindControl("TextBox3")).Visible = false;
                ((RadioButtonList)e.Item.FindControl("RadioButtonList1")).Visible = false;
                ((DropDownList)e.Item.FindControl("DropDownList1")).Visible = false;
                ((Image)e.Item.FindControl("Image1")).Visible = false;
                ((LinkButton)e.Item.FindControl("Linkedit")).Visible = true;
                //((LinkButton)e.Item.FindControl("lnkDelete")).Visible = false;
                ((LinkButton)e.Item.FindControl("Linkupdate")).Visible = false;
                ((LinkButton)e.Item.FindControl("Linkcancel")).Visible = false;
                // ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = true;
            }
           
        }
    }
}