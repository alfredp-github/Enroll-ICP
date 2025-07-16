using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class privacy_policy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //((HtmlGenericControl)Master.FindControl("divNavbar")).Style["margin-bottom"] = "100px";
                ((HtmlGenericControl)Master.FindControl("divNavbar")).Style["border-bottom"] = "lightgray 1px solid";

            }
        }
    }
}