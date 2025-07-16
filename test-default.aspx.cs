using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class test_default : System.Web.UI.Page
    {
        Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx", false); return;

            //Insurance_Enrollment_2024.App_Code
            if (!IsPostBack)
            {
                //aApprovedPlans.HRef = "Content/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id=" + DateTime.Now.Ticks.ToString();
                Response.Redirect("default.aspx"); 
                /*
                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements2.HRef = "program-requirements.aspx";

                aPreRegistration.HRef = "enrollment-assistance-pe.aspx";

                aEnrollmentAssistanceCY.HRef = "test-enrollment-assistance.aspx";

                aExistingPolicy.HRef = "existing-policy.aspx";

                aRequiredTaxForms1.HRef = "ae-forms.aspx?form=tax";
                aRequiredTaxForms2.HRef = "ae-forms.aspx?form=tax";

                aParticipatingPharmacies1.HRef = "Content/docs/cvs_and_participating_pharmacies__2_2020.pdf";
                aParticipatingPharmacies2.HRef = "Content/docs/cvs_and_participating_pharmacies__2_2020.pdf";

                aVideoTutorial1.HRef = "https://youtu.be/S6Y3JiJvKRU";
                aVideoTutorial2.HRef = "https://youtu.be/S6Y3JiJvKRU";

                aEligiblePlans1.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id=";
                aEligiblePlans2.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id=";

                aInsuranceCard1.HRef = "Content/docs/How_to_Read_an_Insurance_ID_Card_and_Information_on_Doctors_Pharmacies_&_Hospitals.pdf?id=";
                aInsuranceCard2.HRef = "Content/docs/How_to_Read_an_Insurance_ID_Card_and_Information_on_Doctors_Pharmacies_&_Hospitals.pdf?id=";

                aEOB_and_HealthInsBill1.HRef = "Content/docs/Example_EOB_and_HealthInsuranceBill.pdf?id=";
                aEOB_and_HealthInsBill2.HRef = "Content/docs/Example_EOB_and_HealthInsuranceBill.pdf?id=";

                aMedicare1.HRef = "https://www.medicare.gov/";
                aMedicare2.HRef = "https://www.medicare.gov/";

                aEducationalMaterials1.HRef = "https://www.cms.gov/marketplace/in-person-assisters/outreach-education/already-enrolled";
                aEducationalMaterials2.HRef = "https://www.cms.gov/marketplace/in-person-assisters/outreach-education/already-enrolled";

                aExplanationOfBenefits1.HRef = "https://www.cms.gov/marketplace/technical-assistance-resources/summary-of-benefits-fast-facts.pdf";
                aExplanationOfBenefits2.HRef = "https://www.cms.gov/marketplace/technical-assistance-resources/summary-of-benefits-fast-facts.pdf";

                aGrievanceProcess1.HRef = "Content/docs/BRHPC%20Premium%20Assistance%20Internal%20Client%20Complaint%20Procedure_Grievance%20Process.pdf";
                aGrievanceProcess2.HRef = "Content/docs/BRHPC%20Premium%20Assistance%20Internal%20Client%20Complaint%20Procedure_Grievance%20Process.pdf";
                */
                /*
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);

                lblIP_Address.Text = util.GetIpAddress(wrapper);

                util.InsertRecord_Analytics(lblIP_Address.Text, "Load-Default", HttpContext.Current.Session.SessionID, 1);
                */
            }
                       

        }

        [System.Web.Services.WebMethod]
        public static string InsertMethod(string tmpControl, string ipAddress)
        //public static string InsertMethod()
        {
            
            //return "qqqqq";
            string tmpSource = "ERROR";
            switch (tmpControl)
            {
                case "PreEnrollment":
                    tmpSource = tmpControl;
                    break;
                case "Not Enrolled":
                    tmpSource = tmpControl;
                    break;
                case "Already Enrolled":
                    tmpSource = tmpControl;
                    break;
                case "Educational Materials":
                    tmpSource = tmpControl;
                    break;
                case "Explanation of Benefits":
                    tmpSource = tmpControl;
                    break;
                case "Glossary of Terms":
                    tmpSource = tmpControl;
                    break;
                case "Eligible Plans":
                    tmpSource = tmpControl;
                    break;
                case "Eligible Plans - On Eligible Plans Page":
                    tmpSource = tmpControl;
                    break;
                case "VideoTutorial":
                    tmpSource = tmpControl;
                    break;
                case "PreRegistration":
                    tmpSource = tmpControl;
                    break;
                case "PreOpenEnrollAssessment":
                    tmpSource = tmpControl;
                    break;
                case "Medicare":
                    tmpSource = tmpControl;
                    break;
                case "COBRA":
                    tmpSource = tmpControl;
                    break;
                case "EMPLOYER":
                    tmpSource = tmpControl;
                    break;
                case "InsuranceCard":
                    tmpSource = tmpControl;
                    break;
                case "Agent-Broker_click":
                    tmpSource = tmpControl;
                    break;
                case "EOB_and_HealthInsBill":
                    tmpSource = tmpControl;
                    break;
                case "GrievanceProcess":
                    tmpSource = tmpControl;
                    break;
                case "MiamiDade":
                    tmpSource = tmpControl;
                    break;
                case "RequiredTaxForms":
                    tmpSource = tmpControl;
                    break;

                case "ProgramRequirements":
                    tmpSource = tmpControl;
                    break;
                case "PreRegistration_S1":
                    tmpSource = tmpControl;
                    break;
                case "Not Enrolled CY": //SEP (ie, any time NOT in the Open Enrollment Period (11/01/2023 - 01/15/2024))
                    tmpSource = tmpControl;
                    break;
                case "Already Enrolled ACA":
                    tmpSource = tmpControl;
                    break;
                case "Participating Pharmacies":
                    tmpSource = tmpControl;
                    break;

                case "COBRA_S1":
                    tmpSource = tmpControl;
                    break;
                case "EMPLOYER_S1":
                    tmpSource = tmpControl;
                    break;


            }

            Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
            util.InsertRecord_Analytics(ipAddress, tmpSource, HttpContext.Current.Session.SessionID, 1);


            return "True";

        }

    }
}