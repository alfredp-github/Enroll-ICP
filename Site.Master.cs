using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class Site : System.Web.UI.MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            //if (!HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost") && HttpContext.Current.Request.Url.AbsoluteUri.Contains("http://"))
            //    Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri.Replace("http://", "https://"), true);

            //Label1.Text = HttpContext.Current.Request.Url.AbsoluteUri; return;

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
                /*
                aPreRegistration1.HRef = "enrollment-assistance-pe.aspx";
                aPreRegistration1.Attributes.Add("onclick", "AnaInsert('PreRegistration')");
                aPreRegistration2.HRef = "enrollment-assistance-pe.aspx";
                aPreRegistration2.Attributes.Add("onclick", "AnaInsert('PreRegistration')");
                */

                aReEnrollment1.HRef = "enrollment-verification.aspx";
                aReEnrollment2.HRef = "enrollment-verification.aspx";
                //aReEnrollment.Attributes.Add("onclick", "AnaInsert('??????????????')");
                aInsurancePremiumAssistanceStart1.HRef = "premium-insurance-enrollment.aspx";
                aInsurancePremiumAssistanceStart2.HRef = "premium-insurance-enrollment.aspx";

                aEnrollmentAssistance1.HRef = "enrollment-assistance.aspx";
                aEnrollmentAssistance1.Attributes.Add("onclick", "AnaInsert('Not Enrolled')");
                aEnrollmentAssistance2.HRef = "enrollment-assistance.aspx";
                aEnrollmentAssistance2.Attributes.Add("onclick", "AnaInsert('Not Enrolled')");

                aEnrollmentAssistanceCY1.HRef = "enrollment-assistance-cy.aspx";
                aEnrollmentAssistanceCY1.Attributes.Add("onclick", "AnaInsert('Not Enrolled CY')");
                aEnrollmentAssistanceCY2.HRef = "enrollment-assistance-cy.aspx";
                aEnrollmentAssistanceCY2.Attributes.Add("onclick", "AnaInsert('Not Enrolled CY')");

                aExistingPolicy1.HRef = "existing-policy.aspx";
                aExistingPolicy1.Attributes.Add("onclick", "AnaInsert('Already Enrolled')");
                aExistingPolicy2.HRef = "existing-policy.aspx";
                aExistingPolicy2.Attributes.Add("onclick", "AnaInsert('Already Enrolled')");

                aRequiredTaxForms1.HRef = "ae-forms.aspx?form=tax";
                aRequiredTaxForms1.Attributes.Add("onclick", "AnaInsert('RequiredTaxForms')");
                aRequiredTaxForms2.HRef = "ae-forms.aspx?form=tax";
                aRequiredTaxForms2.Attributes.Add("onclick", "AnaInsert('RequiredTaxForms')");


                aParticipatingPharmacies1.HRef = "Content/docs/cvs_and_participating_pharmacies__2_2020.pdf";
                aParticipatingPharmacies1.Attributes.Add("onclick", "AnaInsert('Participating Pharmacies')");
                aParticipatingPharmacies2.HRef = "Content/docs/cvs_and_participating_pharmacies__2_2020.pdf";
                aParticipatingPharmacies2.Attributes.Add("onclick", "AnaInsert('Participating Pharmacies')");

                //aVideoTutorial1.HRef = "https://youtu.be/S6Y3JiJvKRU";
                aVideoTutorial1.HRef = "tutorials.aspx";
                aVideoTutorial1.Attributes.Add("onclick", "AnaInsert('VideoTutorial')");
                //aVideoTutorial2.HRef = "https://youtu.be/S6Y3JiJvKRU";
                aVideoTutorial2.HRef = "tutorials.aspx";
                aVideoTutorial2.Attributes.Add("onclick", "AnaInsert('VideoTutorial')");

                //aEligiblePlans1.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id=";
                aEligiblePlans1.HRef = "eligible-plans.aspx";
                aEligiblePlans1.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");
                //aEligiblePlans2.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id=";
                aEligiblePlans2.HRef = "eligible-plans.aspx";

                aEligiblePlans2.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");

                aGlossaryOfTerms1.HRef = "Content/docs/Glossary_of_Terms.pdf?id=";
                aGlossaryOfTerms1.Attributes.Add("onclick", "AnaInsert('Glossary of Terms')");
                aGlossaryOfTerms2.HRef = "Content/docs/Glossary_of_Terms.pdf?id=";
                aGlossaryOfTerms2.Attributes.Add("onclick", "AnaInsert('Glossary of Terms')");

                aInsuranceCard1.HRef = "Content/docs/How_to_Read_an_Insurance_ID_Card_and_Information_on_Doctors_Pharmacies_&_Hospitals.pdf?id=";
                aInsuranceCard1.Attributes.Add("onclick", "AnaInsert('InsuranceCard')");
                aInsuranceCard2.HRef = "Content/docs/How_to_Read_an_Insurance_ID_Card_and_Information_on_Doctors_Pharmacies_&_Hospitals.pdf?id=";
                aInsuranceCard2.Attributes.Add("onclick", "AnaInsert('InsuranceCard')");

                aEOB_and_HealthInsBill1.HRef = "Content/docs/Example_EOB_and_HealthInsuranceBill.pdf?id=";
                aEOB_and_HealthInsBill1.Attributes.Add("onclick", "AnaInsert('EOB_and_HealthInsBill')");
                aEOB_and_HealthInsBill2.HRef = "Content/docs/Example_EOB_and_HealthInsuranceBill.pdf?id=";
                aEOB_and_HealthInsBill2.Attributes.Add("onclick", "AnaInsert('EOB_and_HealthInsBill')");

                //aMedicare1.HRef = "https://www.medicare.gov/";
                aMedicare1.HRef = "ae-forms.aspx?form=medicare_assessment";
                aMedicare1.Attributes.Add("onclick", "AnaInsert('Medicare')");
                //aMedicare2.HRef = "https://www.medicare.gov/";
                aMedicare2.HRef = "ae-forms.aspx?form=medicare_assessment";
                aMedicare2.Attributes.Add("onclick", "AnaInsert('Medicare')");
                //


                aEducationalMaterials1.HRef = "https://www.cms.gov/marketplace/in-person-assisters/outreach-education/already-enrolled";
                aEducationalMaterials1.Attributes.Add("onclick", "AnaInsert('Educational Materials')");
                aEducationalMaterials2.HRef = "https://www.cms.gov/marketplace/in-person-assisters/outreach-education/already-enrolled";
                aEducationalMaterials2.Attributes.Add("onclick", "AnaInsert('Educational Materials')");

                aExplanationOfBenefits1.HRef = "https://www.cms.gov/marketplace/technical-assistance-resources/summary-of-benefits-fast-facts.pdf";
                aExplanationOfBenefits1.Attributes.Add("onclick", "AnaInsert('Explanation of Benefits')");
                aExplanationOfBenefits2.HRef = "https://www.cms.gov/marketplace/technical-assistance-resources/summary-of-benefits-fast-facts.pdf";
                aExplanationOfBenefits2.Attributes.Add("onclick", "AnaInsert('Explanation of Benefits')");

                aGrievanceProcess1.HRef = "Content/docs/BRHPC%20Premium%20Assistance%20Internal%20Client%20Complaint%20Procedure_Grievance%20Process.pdf";
                aGrievanceProcess1.Attributes.Add("onclick", "AnaInsert('GrievanceProcess')");
                aGrievanceProcess2.HRef = "Content/docs/BRHPC%20Premium%20Assistance%20Internal%20Client%20Complaint%20Procedure_Grievance%20Process.pdf";
                aGrievanceProcess2.Attributes.Add("onclick", "AnaInsert('GrievanceProcess')");

                aProgramRequirements.HRef = "program-requirements.aspx";
                aProgramRequirements.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                aProgramRequirementsDocs.HRef = "program-requirements-docs.aspx";
                aProgramRequirementsDocs.Attributes.Add("onclick", "AnaInsert('ProgramRequirementsDocs')");


            }


        }
    }
}