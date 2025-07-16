using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class existing_policy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx", false); return;

            if (!IsPostBack)
            {
                if (HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost"))
                {

                    return;
                }
                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                aExistingPolicy_ACA1.HRef = "existing-policy-aca.aspx";
                aExistingPolicy_ACA1.Attributes.Add("onclick", "AnaInsert('Already Enrolled ACA')");
                aExistingPolicy_ACA2.HRef = "existing-policy-aca.aspx";
                aExistingPolicy_ACA2.Attributes.Add("onclick", "AnaInsert('Already Enrolled ACA')");

                aExistingPolicy_Employer1.HRef = "existing-policy-employer.aspx";
                aExistingPolicy_Employer1.Attributes.Add("onclick", "AnaInsert('Already Enrolled Employer')");
                aExistingPolicy_Employer2.HRef = "existing-policy-employer.aspx";
                aExistingPolicy_Employer2.Attributes.Add("onclick", "AnaInsert('Already Enrolled Employer')");

                aExistingPolicy_Cobra1.HRef = "existing-policy-cobra.aspx";
                aExistingPolicy_Cobra1.Attributes.Add("onclick", "AnaInsert('Already Enrolled Cobra')");
                aExistingPolicy_Cobra2.HRef = "existing-policy-cobra.aspx";
                aExistingPolicy_Cobra2.Attributes.Add("onclick", "AnaInsert('Already Enrolled Cobra')");

                aExistingPolicy_Agent1.HRef = "existing-policy-agent.aspx";
                aExistingPolicy_Agent1.Attributes.Add("onclick", "AnaInsert('Already Enrolled Agent')");
                aExistingPolicy_Agent2.HRef = "existing-policy-agent.aspx";
                aExistingPolicy_Agent2.Attributes.Add("onclick", "AnaInsert('Already Enrolled Agent')");


                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-Enrolled-S1", HttpContext.Current.Session.SessionID, 1);

            }
        }
    }
}