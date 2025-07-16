using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class original : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnViewPlans_Click(object sender, EventArgs e)
        {
            if (ddCounty_Of_Residence.SelectedIndex > 0)
                Response.Redirect("eligibleplans.aspx?id=" + ddCounty_Of_Residence.SelectedValue);
            else
            {
                lblViewPlans.Visible = true;
                lblViewPlans.Text = "*Please select County*";
                ddCounty_Of_Residence.Style["border"] = "orangered 1px solid";
            }
        }
    }
}