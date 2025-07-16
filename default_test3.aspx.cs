using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class default_test3 : System.Web.UI.Page
    {
        Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
            /*
            if (cb2024.Checked)
                cb2024.ForeColor = System.Drawing.Color.FromName("#f26202");
            else if (cb2025.Checked)
                cb2025.ForeColor = System.Drawing.Color.FromName("#f26202");
            */
            //if (HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost"))
            //{
            //    aExistingPolicy.HRef = "existing-policy.aspx"; return;
            //}

            //if (DateTime.Now >= Convert.ToDateTime("11/04/2024 06:00 AM"))
            if (DateTime.Now >= Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings["OpenEnrollmentStart_2024_2025"]))
            {
                //divPreEnroll_Or_OpenEnroll_OpenEnroll.Visible = true;
            }
            else if (DateTime.Now >= Convert.ToDateTime("11/01/2024 00:01 AM"))  //Pre-enroll (delayed open enrollment message)
            {
                divPreEnroll_Or_OpenEnroll_DelayOpenEnroll.Visible = true;
            }
            else //Pre-enroll (notmal message)
            {
                divPreEnroll_Or_OpenEnroll_PreEnroll.Visible = true;
            }

            //Insurance_Enrollment_2024.App_Code 
            if (!IsPostBack)
            {
                //aApprovedPlans.HRef = "Content/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id=" + DateTime.Now.Ticks.ToString();

                util.PopulateDropDownIBM(ddCounty1, "SELECT County as Item_sysID, UPPER(County) as Item_Name FROM tblOptions_Counties order by County", "Select County...", "");
                util.PopulateDropDownIBM(ddCounty2, "SELECT County as Item_sysID, UPPER(County) as Item_Name FROM tblOptions_Counties order by County", "Select County...", "");

                cb2025.Checked = true;
                cb2025.ForeColor = System.Drawing.Color.FromName("#f26202");
                cb2024.Checked = false;



                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");
                aProgramRequirements2.HRef = "program-requirements.aspx";
                aProgramRequirements2.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                if (Request.QueryString["test"] != null && Request.QueryString["test"] == "yes")
                {
                    divPreRegistration.Visible = true;

                    aPreRegistration.HRef = "enrollment-assistance-pe.aspx";
                    aPreRegistration.Attributes.Add("onclick", "AnaInsert('PreRegistration')");
                }

                aRecertified.Attributes.Add("onclick", "AnaInsert('Recertified')");

                aEnrollmentAssistance.HRef = "enrollment-assistance.aspx";
                aEnrollmentAssistance.Attributes.Add("onclick", "AnaInsert('Not Enrolled')");

                aEnrollmentAssistanceCY.HRef = "enrollment-assistance-cy.aspx";
                aEnrollmentAssistanceCY.Attributes.Add("onclick", "AnaInsert('Not Enrolled CY')");

                //aExistingPolicy.HRef = "existing-policy.aspx";
                //aExistingPolicy.Attributes.Add("onclick", "AnaInsert('Already Enrolled')");

                /*
                aMiamiDade.HRef = "ae-forms.aspx?form=miamidade";
                aMiamiDade.Attributes.Add("onclick", "AnaInsert('MiamiDade')");
                aMiamiDade2.HRef = "ae-forms.aspx?form=miamidade";
                aMiamiDade2.Attributes.Add("onclick", "AnaInsert('MiamiDade')");

                aMiamiDade3.HRef = "ae-forms.aspx?form=miamidade";
                aMiamiDade3.Attributes.Add("onclick", "AnaInsert('MiamiDade')");
                */
                aMiamiDade.HRef = "wrap-around-services.aspx?cty=MIAMI-DADE&y=2025";
                aMiamiDade.Attributes.Add("onclick", "AnaInsert('MiamiDade WrapAroundServices')");
                aMiamiDade2.HRef = "wrap-around-services.aspx?cty=MIAMI-DADE&y=2025";
                aMiamiDade2.Attributes.Add("onclick", "AnaInsert('MiamiDade WrapAroundServices')");


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
                /*
                aEligiblePlans1.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id=";
                aEligiblePlans1.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");
                aEligiblePlans2.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id=";
                aEligiblePlans2.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");
                */
                aEligiblePlans1.HRef = "eligible-plans.aspx";
                aEligiblePlans1.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");
                aEligiblePlans2.HRef = "eligible-plans.aspx";
                aEligiblePlans2.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");


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

                aMedicare3.HRef = "ae-forms.aspx?form=medicare_assessment";
                aMedicare3.Attributes.Add("onclick", "AnaInsert('Medicare')");


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


                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);

                lblIP_Address.Text = util.GetIpAddress(wrapper);
                //lblIP_Address.Style["display"] = "block"; return;

                if (!HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost") && HttpContext.Current.Request.Url.AbsoluteUri.Contains("https://"))
                    util.InsertRecord_Analytics(lblIP_Address.Text, "Load-Default", HttpContext.Current.Session.SessionID, 1);

            }

            ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).Visible = false;
            ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessageContent")).InnerHtml = "";

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
                case "MiamiDade WrapAroundServices":
                    tmpSource = tmpControl;
                    break;
                //
                case "RequiredTaxForms":
                    tmpSource = tmpControl;
                    break;

                case "ProgramRequirements":
                    tmpSource = tmpControl;
                    break;
                case "ProgramRequirementsDocs":
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

                case "Recertified":
                    tmpSource = tmpControl;
                    break;
                case "LandingPage-Recertified":
                    tmpSource = tmpControl;
                    break;


            }

            Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
            util.InsertRecord_Analytics(ipAddress, tmpSource, HttpContext.Current.Session.SessionID, 1);


            return "True";

        }

        protected void ddCounty1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb2025.Checked || cb2024.Checked)
            {
                /*
                DropDownList the_list_that_changed = (DropDownList)sender;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).Visible = true;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).InnerHtml = the_list_that_changed.ClientID;
                return;
                */
                //((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).Visible = true; 
                //((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).InnerHtml = "ddCounty1_SelectedIndexChanged"; 

                string tmpSelectedCounty = ddCounty1.SelectedItem.Text;
                ddCounty1.SelectedIndex = -1;
                string tmpYear = "";
                if (cb2025.Checked)
                    tmpYear = "2025";
                else if (cb2024.Checked)
                    tmpYear = "2024";

                divCount1_MiamiDade.Visible = false;
                divCount2_MiamiDade.Visible = false;

                DropDownList the_list_that_changed = (DropDownList)sender;

                if (ddCounty1.SelectedItem.Text.ToLower().Contains("dade"))
                    //Response.Redirect("ae-forms.aspx?form=miamidade");
                    //divCount1_MiamiDade.Visible = true;
                    Response.Redirect("wrap-around-services.aspx?cty=" + tmpSelectedCounty + "&y=" + tmpYear, false);
                else
                    Response.Redirect("ao-counties.aspx?cty=" + tmpSelectedCounty + "&y=" + tmpYear, false);

                //Label1.Text = ddCounty1.SelectedItem.Text;
            }
            else
            {
                ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).Visible = true;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessageContent")).InnerHtml = "Please select Insurance Year.";
            }


        }
        protected void ddCounty2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            DropDownList the_list_that_changed = (DropDownList)sender;
            ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).Visible = true;
            ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).InnerHtml = the_list_that_changed.ClientID;
            return;
            */
            //((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).Visible = true; 
            //((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).InnerHtml = "ddCounty2_SelectedIndexChanged"; 

            string tmpSelectedCounty = ddCounty2.SelectedItem.Text;
            ddCounty2.SelectedIndex = -1;

            divCount1_MiamiDade.Visible = false;
            divCount2_MiamiDade.Visible = false;

            DropDownList the_list_that_changed = (DropDownList)sender;

            if (ddCounty2.SelectedItem.Text.ToLower().Contains("dade"))
                //Response.Redirect("ae-forms.aspx?form=miamidade");
                //divCount1_MiamiDade.Visible = true;
                Response.Redirect("wrap-around-services.aspx?cty=" + tmpSelectedCounty + "&y=2024", false);
            else
                Response.Redirect("ao-counties.aspx?cty=" + tmpSelectedCounty + "&y=20244444444", false);

        }

        protected void lbtnPremAssistGo_Click(object sender, EventArgs e)
        {
            try
            {
                ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).Visible = false;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessageContent")).InnerHtml = "";
                divMessage.Visible = false;
                divMessageContent.InnerHtml = "";

                spanMessage1.Visible = false;
                lblSpanMessage1.Text = "";

                if (cb2025.Checked || cb2024.Checked)
                {
                    if (ddCounty1.SelectedIndex > 0)
                    {
                        string tmpSelectedCounty = ddCounty1.SelectedItem.Text;
                        ddCounty1.SelectedIndex = -1;
                        string tmpYear = "";
                        if (cb2025.Checked)
                            tmpYear = "2025";
                        else if (cb2024.Checked)
                            tmpYear = "2024";

                        divCount1_MiamiDade.Visible = false;
                        divCount2_MiamiDade.Visible = false;

                        //DropDownList the_list_that_changed = (DropDownList)sender;

                        if (tmpSelectedCounty.ToLower().Contains("dade"))
                            Response.Redirect("wrap-around-services.aspx?cty=" + tmpSelectedCounty + "&y=" + tmpYear, false);
                        else
                        {
                            if (tmpYear == "2025")
                            {
                                //Response.Redirect("enrollment-assistance-pe.aspx?cty=" + tmpSelectedCounty + "&y=" + tmpYear, false);
                                //if (DateTime.Now >= Convert.ToDateTime("11/04/2024 06:00 AM"))
                                if (DateTime.Now >= Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings["OpenEnrollmentStart_2024_2025"]))
                                {
                                    //Response.Redirect("enrollment-assistance.aspx?cty=" + tmpSelectedCounty + "&y=" + tmpYear, false); //2025 open enrollment form
                                    Response.Redirect("ao-counties.aspx?cty=" + tmpSelectedCounty + "&y=" + tmpYear, false);

                                }
                                else
                                {
                                    Response.Redirect("enrollment-assistance-pe.aspx?cty=" + tmpSelectedCounty + "&y=" + tmpYear, false); //Pre-Enrollment Form
                                }


                            }
                            else
                                Response.Redirect("ao-counties.aspx?cty=" + tmpSelectedCounty + "&y=" + tmpYear, false);
                        }
                    }
                    else
                    {
                        //((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).Visible = true;
                        //((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessageContent")).InnerHtml = "Please select your County of Residence.";
                        spanMessage1.Visible = true;
                        lblSpanMessage1.Text = "<b>**</b> Please select a <b>Year</b> and <b>County</b> of Residence <b>**</b>";
                    }
                }
                else
                {
                    //((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessage")).Visible = true;
                    //((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divMessageContent")).InnerHtml = "Please select the Insurance Year.";
                    //divMessage.Visible = true;
                    //divMessageContent.InnerHtml = "Please select the Insurance Year.";
                    spanMessage1.Visible = true;
                    lblSpanMessage1.Text = "<b>**</b> Please select a <b>Year</b> and <b>County</b> of Residence <b>**</b>";
                }

            }
            catch (Exception ex)
            {
                lblSpanMessage1.Text = "<b>**</b> An unexpected error has occured <b>**</b>";
                util.LogException(ex, "lbtnPremAssistGo_Click", HttpContext.Current.Request.Url.AbsolutePath, "");
            }



        }


    }
}