using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if(TextBox1.Text != "")
            {
                Response.Redirect("NYStateTest.aspx");
            }
            else
            {
                Label1.Text = "Please enter a name";
            }
        }



    }
}