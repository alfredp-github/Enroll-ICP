using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class existing_policy_aca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx", false); return;

            if (!IsPostBack)
            {

                aProgramRequirements1.HRef = "program-requirements.aspx";
                aProgramRequirements1.Attributes.Add("onclick", "AnaInsert('ProgramRequirements')");

                aExistingPolicy_ACA1.HRef = "ae-forms.aspx?form=ep_aca";
                aExistingPolicy_ACA1.Attributes.Add("onclick", "AnaInsert('ACA_S1')");

                aEligiblePlans1.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2024.pdf?id=";
                aEligiblePlans1.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");
                aEligiblePlans2.HRef = "Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2024.pdf?id=";
                aEligiblePlans2.Attributes.Add("onclick", "AnaInsert('Eligible Plans')");

                aExistingPolicy_2023_ACA1.HRef = "ae-forms.aspx?form=ep_aca_nov";
                aExistingPolicy_2023_ACA1.Attributes.Add("onclick", "AnaInsert('ACA_Nov_S1')");

                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-ACA-S1", HttpContext.Current.Session.SessionID, 1);

            }
        }
    }
}