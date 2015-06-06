using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlashCards
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void MultiplicationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Multiplication.aspx");
        }

        protected void AdditionButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addition.aspx");
        }
       
    }
}