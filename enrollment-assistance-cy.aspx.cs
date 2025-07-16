using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class enrollment_assistance_cy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost"))
            {

            }
            else
            {
                //Uncomment line below after the Pre-Enrollment period has ended.
                Response.Redirect("default.aspx"); return;
            }

            if (!IsPostBack)
            {

                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                aSpecialEnrollmentPeriod.HRef = "ae-forms.aspx?form=na_aca_se";
                aSpecialEnrollmentPeriod.Attributes.Add("onclick", "AnaInsert('Not Enrolled CY')");

                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-NotEnrolled-CY", HttpContext.Current.Session.SessionID, 1);

            }
        }
    }
}