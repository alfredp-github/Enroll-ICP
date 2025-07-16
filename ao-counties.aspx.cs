using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class ao_counties : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost"))
                {

                    topMessage1.InnerHtml = "You selected: " + Request.QueryString["cty"] + " County for <span style='color:#EA5276'>" + Request.QueryString["y"] + "</span> Insurance";
                    //topMessage2.InnerHtml = "Are you already enrolled in an ACA, COBRA or Employer plan? <span style='color:#EA5276'>Or...</span><br />Do you need ACA enrollment help?";
                    topMessage2.InnerHtml = "Are you already enrolled in an ACA, COBRA or Employer plan? <span style='color:#EA5276'>Or...</span> Do you need ACA enrollment help?";

                    lblYear1.Text = Request.QueryString["y"];
                    lblYear2.Text = Request.QueryString["y"];
                    lblYear3.Text = Request.QueryString["y"];
                    lblYear4.Text = Request.QueryString["y"];

                    //if (DateTime.Now >= Convert.ToDateTime("11/04/2024 06:00 AM"))
                    if (DateTime.Now >= Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings["OpenEnrollmentStart_2024_2025"]))
                    {
                        if (Request.QueryString["y"] == "2025")
                        {
                            aDoorA.HRef = "enrollment-assistance.aspx";
                            aDoorB.HRef = "existing-policy-ins.aspx?y=" + Request.QueryString["y"];

                            if (Request.QueryString["cty"].ToLower() == "broward")
                            {
                                divBrowardCounty.Visible = true;
                            }

                        }
                        else if (Request.QueryString["y"] == "2024")
                        {
                            aDoorA.HRef = "enrollment-assistance-cy.aspx";
                            aDoorB.HRef = "existing-policy-ins.aspx?y=" + Request.QueryString["y"];
                            //Commenting out line above and replaced with line below after December 1st (no current year allowed)
                            //Response.Redirect("default.aspx");

                        }
                        else
                            Response.Redirect("default.aspx", false);
                    }
                    else
                    {
                        aDoorA.HRef = "enrollment-assistance-cy.aspx";
                        aDoorB.HRef = "existing-policy-ins.aspx?y=" + Request.QueryString["y"];
                    }

                    //return;
                }
                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                //aSpecialEnrollmentPeriod.HRef = "ae-forms.aspx?form=na_aca_se";
                //aSpecialEnrollmentPeriod.Attributes.Add("onclick", "AnaInsert('Not Enrolled CY')");

                //aReenrollment.Attributes.Add("onclick", "AnaInsert('GoToForm-Recertified')");

                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "LandingPage-AO-Counties", HttpContext.Current.Session.SessionID, 1);

            }
        }
    }
}