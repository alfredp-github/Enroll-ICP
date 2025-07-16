using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class enrollment_assistance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                //aSpecialEnrollmentPeriod.HRef = "ae-forms.aspx?form=na_aca_se";
                //aSpecialEnrollmentPeriod.Attributes.Add("onclick", "AnaInsert('Not Enrolled CY')");
                aSpecialEnrollmentPeriod.HRef = "ae-forms.aspx?form=na_aca";
                aSpecialEnrollmentPeriod.Attributes.Add("onclick", "AnaInsert('Not Enrolled')");

                //if (DateTime.Now >= Convert.ToDateTime("11/04/2024 06:00 AM"))
                if (DateTime.Now >= Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings["OpenEnrollmentStart_2024_2025"]))
                {
                    h1Header2.InnerHtml = "I have NOT enrolled in a Marketplace/ACA Plan for 2025";
                    aSpecialEnrollmentPeriod.InnerHtml = "I need insurance for 2025";
                }
                else
                {
                    h1Header2.InnerHtml = "I have NOT enrolled in a Marketplace/ACA Plan for 2024";
                    aSpecialEnrollmentPeriod.InnerHtml = "I need insurance for 2024";
                }

                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-NotEnrolled", HttpContext.Current.Session.SessionID, 1);

            }
        }
    }
}