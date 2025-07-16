using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class enrollment_assistance_pe : System.Web.UI.Page
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
                if (Request.QueryString["cty"] != null && Request.QueryString["cty"] != "")
                    topMessage1.InnerHtml = "You selected: " + Request.QueryString["cty"] + " County for <span style='color:#EA5276'>" + Request.QueryString["y"] + "</span> Insurance";


                //Response.Redirect("default.aspx");
                //aPreRegistration.HRef = "ae-forms.aspx?form=prereg";
                //aPreRegistration.Attributes.Add("onclick", "AnaInsert('PreRegistration_S1')");

                
                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                aPreRegistration.HRef = "ae-forms.aspx?form=prereg";
                aPreRegistration.Attributes.Add("onclick", "AnaInsert('PreRegistration_S1')");
                //aPreRegistration.HRef = "ae-forms.aspx?form=na_aca";
                //aPreRegistration.Attributes.Add("onclick", "AnaInsert('PreRegistration_S1')");
                //******************* NEED TO CREATE A SEPARATE PAGE "enrollment-assistance.aspx" FOR OPEN ENROLLMENT ON 11/01/2023 ************************************************************************************

                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-PreRegistration_S1", HttpContext.Current.Session.SessionID, 1);
                
            }
        }
    }
}