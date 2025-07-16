using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class existing_policy_ins_aca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                if (Request.QueryString["y"] == "2025")
                {

                    //divApprovedPlans.InnerHtml = "<b>Note:</b> 2025 Program Approved Plan list will be available shortly";

                    aEligiblePlans1.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_" + Request.QueryString["y"] + ".pdf?id=";
                    aEligiblePlans1.InnerHtml = "" + Request.QueryString["y"] + " Program Approved Plan";
                    aEligiblePlans1.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");
                    aEligiblePlans2.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_" + Request.QueryString["y"] + ".pdf?id=";
                    aEligiblePlans2.InnerHtml = "View the " + Request.QueryString["y"] + " Program Approved Plan list by County";
                    aEligiblePlans2.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");

                    h1Header2.InnerHtml = "I have Already Enrolled in an ACA Health Insurance Marketplace Plan for " + Request.QueryString["y"];

                    aYes.HRef = "existing-policy-agent.aspx?y=" + Request.QueryString["y"];
                    aYes.Attributes.Add("onclick", "AnaInsert('Already Enrolled Agent')");

                    aNo.HRef = "ae-forms.aspx?form=ep_aca";
                    aNo.Attributes.Add("onclick", "AnaInsert('ACA_S1')");
                }
                else if (Request.QueryString["y"] == "2024")
                {
                    
                    aEligiblePlans1.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_" + Request.QueryString["y"] + ".pdf?id=";
                    aEligiblePlans1.InnerHtml = "" + Request.QueryString["y"] + " Program Approved Plan";
                    aEligiblePlans1.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");
                    aEligiblePlans2.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_" + Request.QueryString["y"] + ".pdf?id=";
                    aEligiblePlans2.InnerHtml = "View the " + Request.QueryString["y"] + " Program Approved Plan list by County";
                    aEligiblePlans2.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");

                    h1Header2.InnerHtml = "I have Already Enrolled in an ACA Health Insurance Marketplace Plan for " + Request.QueryString["y"];

                    aYes.HRef = "existing-policy-agent.aspx?y=" + Request.QueryString["y"];
                    aYes.Attributes.Add("onclick", "AnaInsert('Already Enrolled Agent')");

                    aNo.HRef = "ae-forms.aspx?form=ep_aca_nov";
                    aNo.Attributes.Add("onclick", "AnaInsert('ACA_S1')");
                    
                    //Commenting out line above and replaced with line below after December 1st (no current year allowed)
                    //Response.Redirect("default.aspx");

                }
                else
                    Response.Redirect("default.aspx", false);

                /*
                aYes.HRef = "existing-policy-agent.aspx";
                aYes.Attributes.Add("onclick", "AnaInsert('Already Enrolled Agent')");
                aNo.HRef = "ae-forms.aspx?form=ep_aca";
                aNo.Attributes.Add("onclick", "AnaInsert('ACA_S1')");
                */

                //aExistingPolicy_ACA1.HRef = "ae-forms.aspx?form=ep_aca";
                //aExistingPolicy_ACA1.Attributes.Add("onclick", "AnaInsert('ACA_S1')");


                //aExistingPolicy_2023_ACA1.HRef = "ae-forms.aspx?form=ep_aca_nov";
                //aExistingPolicy_2023_ACA1.Attributes.Add("onclick", "AnaInsert('ACA_Nov_S1')");

                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-ACA-S1", HttpContext.Current.Session.SessionID, 1);

            }
        }

        protected void btnExistingPolicy_ACA1_Click(object sender, EventArgs e)
        {
            /*
            if (rblAreYouAnAgent.SelectedValue == "No")
                Response.Redirect("ae-forms.aspx?form=ep_aca");
            else if (rblAreYouAnAgent.SelectedValue == "Yes")
                Response.Redirect("existing-policy-agent.aspx");
            else
                rblAreYouAnAgent.BackColor = System.Drawing.Color.Yellow;
            */
        }

    }
}