using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class program_requirements_docs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //((HtmlGenericControl)Master.FindControl("divNavbar")).Style["border-bottom"] = "lightgray 1px solid";

                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-ProgramRequirements-Docs", HttpContext.Current.Session.SessionID, 1);

            }

        }
    }
}