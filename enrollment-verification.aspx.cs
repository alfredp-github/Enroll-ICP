using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class enrollment_verification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost"))
                {

                    return;
                }
                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                //aSpecialEnrollmentPeriod.HRef = "ae-forms.aspx?form=na_aca_se";
                //aSpecialEnrollmentPeriod.Attributes.Add("onclick", "AnaInsert('Not Enrolled CY')");

                aReenrollment.Attributes.Add("onclick", "AnaInsert('GoToForm-Recertified')");

                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "LandingPage-Recertified", HttpContext.Current.Session.SessionID, 1);

            }
        }
    }
}