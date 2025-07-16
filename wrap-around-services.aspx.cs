using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class wrap_around_services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost"))
                {

                    //topMessage1.InnerHtml = "You selected: " + Request.QueryString["cty"] + " County";
                    topMessage1.InnerHtml = "You selected: " + Request.QueryString["cty"] + " County for <span style='color:#EA5276'>" + Request.QueryString["y"] + "</span> Insurance";

                    //topMessage2.InnerHtml = "Are you already enrolled in an ACA, COBRA or Employer plan? <span style='color:#EA5276'>Or...</span><br />Do you need ACA enrollment help?";
                    topMessage2.InnerHtml = "Are you requesting Part A Wrap Around Services?";

                    //aNo.HRef = "ao-counties.aspx?cty=" + Request.QueryString["cty"] + "&y=" + Request.QueryString["y"];
                    //if (DateTime.Now >= Convert.ToDateTime("11/04/2024 06:00 AM"))
                    if (DateTime.Now >= Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings["OpenEnrollmentStart_2024_2025"]))
                    {
                        aNo.HRef = "ao-counties.aspx?cty=" + Request.QueryString["cty"] + "&y=" + Request.QueryString["y"]; //2025 open enrollment form
                    }
                    else
                    {
                        if (Request.QueryString["y"] == "2025")
                            aNo.HRef = "enrollment-assistance-pe.aspx?cty=" + Request.QueryString["cty"] + "&y=" + Request.QueryString["y"]; //Pre-Enrollment Form
                        else
                            aNo.HRef = "ao-counties.aspx?cty=" + Request.QueryString["cty"] + "&y=" + Request.QueryString["y"]; //Are you already enrolled in an ACA, COBRA or Employer plan? Or... Do you need ACA enrollment help?
                    }
                    //aDoorA.HRef = "enrollment-assistance-cy.aspx";
                    //aDoorB.HRef = "existing-policy-ins.aspx";

                    //return;
                }
                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");
                
                //aSpecialEnrollmentPeriod.HRef = "ae-forms.aspx?form=na_aca_se";
                //aSpecialEnrollmentPeriod.Attributes.Add("onclick", "AnaInsert('Not Enrolled CY')");

                //aReenrollment.Attributes.Add("onclick", "AnaInsert('GoToForm-Recertified')");

                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "LandingPage-WrapAroundServices", HttpContext.Current.Session.SessionID, 1);

            }
        }
    }
}