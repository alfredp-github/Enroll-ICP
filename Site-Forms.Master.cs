using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class Site_Forms : System.Web.UI.MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            //if (!HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost") && HttpContext.Current.Request.Url.AbsoluteUri.Contains("http://"))
            //    Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri.Replace("http://", "https://"));

            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                aParticipatingPharmacies1.HRef = "Content/docs/cvs_and_participating_pharmacies__2_2020.pdf";
                aParticipatingPharmacies1.Attributes.Add("onclick", "AnaInsert('Participating Pharmacies')");

                //aVideoTutorial1.HRef = "https://youtu.be/S6Y3JiJvKRU";
                aVideoTutorial1.HRef = "tutorials.aspx";
                aVideoTutorial1.Attributes.Add("onclick", "AnaInsert('VideoTutorial')");

                //aEligiblePlans1.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id=";
                aEligiblePlans1.HRef = "eligible-plans.aspx";
                aEligiblePlans1.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");

                aInsuranceCard1.HRef = "Content/docs/How_to_Read_an_Insurance_ID_Card_and_Information_on_Doctors_Pharmacies_&_Hospitals.pdf?id=";
                aInsuranceCard1.Attributes.Add("onclick", "AnaInsert('InsuranceCard')");

                aEOB_and_HealthInsBill1.HRef = "Content/docs/Example_EOB_and_HealthInsuranceBill.pdf?id=";
                aEOB_and_HealthInsBill1.Attributes.Add("onclick", "AnaInsert('EOB_and_HealthInsBill')");

                //aMedicare1.HRef = "https://www.medicare.gov/";
                aMedicare1.HRef = "ae-forms.aspx?form=medicare_assessment";
                aMedicare1.Attributes.Add("onclick", "AnaInsert('Medicare')");

                aEducationalMaterials1.HRef = "https://www.cms.gov/marketplace/in-person-assisters/outreach-education/already-enrolled";
                aEducationalMaterials1.Attributes.Add("onclick", "AnaInsert('Educational Materials')");

                aExplanationOfBenefits1.HRef = "https://www.cms.gov/marketplace/technical-assistance-resources/summary-of-benefits-fast-facts.pdf";
                aExplanationOfBenefits1.Attributes.Add("onclick", "AnaInsert('Explanation of Benefits')");

                aGrievanceProcess1.HRef = "Content/docs/BRHPC%20Premium%20Assistance%20Internal%20Client%20Complaint%20Procedure_Grievance%20Process.pdf";
                aGrievanceProcess1.Attributes.Add("onclick", "AnaInsert('GrievanceProcess')");



            }
        }
    }
}