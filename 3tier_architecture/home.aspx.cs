using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3tier_architecture
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {

            try
            {
                userBD.Class1 objBal = new userBD.Class1();
                Repeater1.DataSource = objBal.BindGrid(Convert.ToInt32(Session["id"]));
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}        
        
   