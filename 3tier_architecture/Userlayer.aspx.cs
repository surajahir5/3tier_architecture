using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3tier_architecture
{
    public partial class Userlayer : System.Web.UI.Page
    {
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            RadioButtonList1.SelectedValue = "";
        }

        public void InsertData()
        {
            userschema.Class1 objSchema = new userschema.Class1();
            objSchema.Name = TextBox1.Text;
            objSchema.Email = TextBox2.Text;
            objSchema.Password= TextBox3.Text;
            objSchema.Mobile= TextBox4.Text;
            objSchema.Gender= RadioButtonList1.SelectedValue;
            userBD.Class1 objBAL = new userBD.Class1();
            int result = objBAL.Insert(objSchema);
            if (result > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data Saved Successfully')", true);
            }
          
        }
    
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Button1.Text == "Submit")
                {
                    InsertData();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }       
}