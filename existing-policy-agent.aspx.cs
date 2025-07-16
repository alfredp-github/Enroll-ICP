using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class existing_policy_agent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                //aExistingPolicy_Agent1.HRef = "ae-forms.aspx?form=ep_agen";
                //aExistingPolicy_Agent1.Attributes.Add("onclick", "AnaInsert('Agent-Broker_S1')");

                if (Request.QueryString["y"] == "2025")
                {

                    //divApprovedPlans.InnerHtml = "<div class=\"nex - title - 2\">Marketplace / ACA</div><br /><b>Note:</b> 2025 Program Approved Plan list will be available shortly";

                    aApprovedPlans1.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_" + Request.QueryString["y"] + ".pdf?id=";
                    aApprovedPlans1.InnerHtml = "" + Request.QueryString["y"] + " Program Approved Plan";

                    aApprovedPlans2.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_" + Request.QueryString["y"] + ".pdf?id=";
                    aApprovedPlans2.InnerHtml = "View the " + Request.QueryString["y"] + " Program Approved Plan list by County";

                    aExistingPolicy_Agent1.HRef = "ae-forms.aspx?form=ep_agen&y=" + Request.QueryString["y"];
                    aExistingPolicy_Agent1.Attributes.Add("onclick", "AnaInsert('Agent-Broker_S1')");
                }
                else if (Request.QueryString["y"] == "2024")
                {
                    
                    aApprovedPlans1.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_" + Request.QueryString["y"] + ".pdf?id=";
                    aApprovedPlans1.InnerHtml = "" + Request.QueryString["y"] + " Program Approved Plan";

                    aApprovedPlans2.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_" + Request.QueryString["y"] + ".pdf?id=";
                    aApprovedPlans2.InnerHtml = "View the " + Request.QueryString["y"] + " Program Approved Plan list by County";

                    aExistingPolicy_Agent1.HRef = "ae-forms.aspx?form=ep_agen&y=" + Request.QueryString["y"];
                    aExistingPolicy_Agent1.Attributes.Add("onclick", "AnaInsert('Agent-Broker_S1')");
                    
                    //Commenting out line above and replaced with line below after December 1st (no current year allowed)
                    //Response.Redirect("default.aspx");

                }
                else
                    Response.Redirect("default.aspx", false);


                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-Agent-Broker-S1", HttpContext.Current.Session.SessionID, 1);

            }
        }
    }
}