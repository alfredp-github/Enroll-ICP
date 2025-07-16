using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class existing_policy_ins : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (false)//(HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost"))
                {

                    aExistingPolicy_ACA1.HRef = "existing-policy-ins-aca.aspx";
                    aExistingPolicy_ACA2.HRef = "existing-policy-ins-aca.aspx";

                    aExistingPolicy_Employer1.HRef = "existing-policy-employer.aspx";
                    aExistingPolicy_Employer2.HRef = "existing-policy-employer.aspx";

                    aExistingPolicy_Cobra1.HRef = "existing-policy-cobra.aspx";
                    aExistingPolicy_Cobra2.HRef = "existing-policy-cobra.aspx";

                    return;
                }
                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                /*
                aExistingPolicy_ACA1.HRef = "existing-policy-aca.aspx";
                aExistingPolicy_ACA1.Attributes.Add("onclick", "AnaInsert('Already Enrolled ACA')");
                aExistingPolicy_ACA2.HRef = "existing-policy-aca.aspx";
                aExistingPolicy_ACA2.Attributes.Add("onclick", "AnaInsert('Already Enrolled ACA')");
                */
                if (Request.QueryString["y"] == "2025")
                {
                    h1Header2.InnerHtml = "I have Already enrolled in an Insurance Plan for " + Request.QueryString["y"];

                    aExistingPolicy_ACA1.HRef = "existing-policy-ins-aca.aspx?y=" + Request.QueryString["y"];
                    aExistingPolicy_ACA1.Attributes.Add("onclick", "AnaInsert('Already Enrolled ACA')");
                    aExistingPolicy_ACA2.HRef = "existing-policy-ins-aca.aspx?y=" + Request.QueryString["y"];
                    aExistingPolicy_ACA2.Attributes.Add("onclick", "AnaInsert('Already Enrolled ACA')");

                    aNeedPolicy.HRef = "enrollment-assistance.aspx";
                    aNeedPolicy.InnerHtml = "*If you do not have any of these, then <u>Get Assitance with Enrollment</u> for " + Request.QueryString["y"];
                }
                else if (Request.QueryString["y"] == "2024")
                {
                    
                    h1Header2.InnerHtml = "I have Already enrolled in an Insurance Plan for " + Request.QueryString["y"];

                    aExistingPolicy_ACA1.HRef = "existing-policy-ins-aca.aspx?y=" + Request.QueryString["y"];
                    aExistingPolicy_ACA1.Attributes.Add("onclick", "AnaInsert('Already Enrolled ACA')");
                    aExistingPolicy_ACA2.HRef = "existing-policy-ins-aca.aspx?y=" + Request.QueryString["y"];
                    aExistingPolicy_ACA2.Attributes.Add("onclick", "AnaInsert('Already Enrolled ACA')");

                    aNeedPolicy.HRef = "enrollment-assistance-cy.aspx";
                    aNeedPolicy.InnerHtml = "*If you do not have any of these, then <u>Get Assitance with Enrollment</u> for " + Request.QueryString["y"];
                    
                    //Commenting out line above and replaced with line below after December 1st (no current year allowed)
                    //Response.Redirect("default.aspx");

                }
                else
                    Response.Redirect("default.aspx", false);


                aExistingPolicy_Employer1.HRef = "existing-policy-employer.aspx";
                aExistingPolicy_Employer1.Attributes.Add("onclick", "AnaInsert('Already Enrolled Employer')");
                aExistingPolicy_Employer2.HRef = "existing-policy-employer.aspx";
                aExistingPolicy_Employer2.Attributes.Add("onclick", "AnaInsert('Already Enrolled Employer')");

                aExistingPolicy_Cobra1.HRef = "existing-policy-cobra.aspx";
                aExistingPolicy_Cobra1.Attributes.Add("onclick", "AnaInsert('Already Enrolled Cobra')");
                aExistingPolicy_Cobra2.HRef = "existing-policy-cobra.aspx";
                aExistingPolicy_Cobra2.Attributes.Add("onclick", "AnaInsert('Already Enrolled Cobra')");

                //aExistingPolicy_Agent1.HRef = "existing-policy-agent.aspx";
                //aExistingPolicy_Agent1.Attributes.Add("onclick", "AnaInsert('Already Enrolled Agent')");
                //aExistingPolicy_Agent2.HRef = "existing-policy-agent.aspx";
                //aExistingPolicy_Agent2.Attributes.Add("onclick", "AnaInsert('Already Enrolled Agent')");


                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-Enrolled-S1", HttpContext.Current.Session.SessionID, 1);

            }
        }
    }
}