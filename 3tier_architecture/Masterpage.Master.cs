using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3tier_architecture
{
    public partial class Masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb1.Text = " Wellcome " + Session["name"];
            if (!this.IsPostBack)
            {
                bindgrid();
            }
        }

        private void bindgrid()
        {
            userBD.Class1 objpic = new userBD.Class1();
            DataSet dt = objpic.uppicture(Convert.ToInt32(Session["id"]));
            DataSet ds = new DataSet();
            ds = dt;
            for (int i = 0; i < dt.Tables.Count; i++)
            {
                string url = ds.Tables[0].Rows[i]["image"].ToString();
                Image2.ImageUrl = url;
            }
        }
    }
}