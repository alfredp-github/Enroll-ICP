using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class ae_forms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);


                switch (Request.QueryString["form"])
                {
                    case "prereg":
                        //iframe2.Src = "https://amex.surefyre.co/app/public/195/";
                        iframe2.Src = "https://amex.surefyre.co/app/public/t/fl-adap-pre-enrollment-aca-assessment/";
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-PreRegistration", HttpContext.Current.Session.SessionID, 1);
                        break;
                    case "na_aca": //Open Enrollment
                        //iframe2.Src = "https://uat-amex.surefyre.co/app/public/t/florida-adap-aca-assessment/";
                        //iframe2.Src = "https://amex.surefyre.co/app/public/t/florida-adap-aca-assessment/";
                        //*****************************************************************************************************************
                        //On 10/31/2024 Andrew shared this link for the 2025 open enrollment - https://amex.surefyre.co/app/public/234/
                        //*****************************************************************************************************************

                        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("menu_FormName")).InnerHtml = "ACA Marketplace Health Insurance Enrollment";

                        //if (DateTime.Now >= Convert.ToDateTime("11/04/2024 06:00 AM"))
                        if (DateTime.Now >= Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings["OpenEnrollmentStart_2024_2025"]))
                        {
                            iframe2.Src = "https://amex.surefyre.co/app/public/234/"; //2025 open enrollment form
                        }
                        else 
                        {
                            iframe2.Src = "https://amex.surefyre.co/app/public/t/florida-adap-aca-assessment/";
                        }

                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-NotEnrolled", HttpContext.Current.Session.SessionID, 1);
                        break;
                    /*
                    case "Re-Enrollment --- Re-certification *******************************************************************************":
                        //This will become active AFTER January 1st
                        iframe2.Src = "https://amex.surefyre.co/app/public/t/fl-adap-recertification-notice/";
                        break;
                    */
                    case "reenroll":
                        iframe2.Src = "https://amex.surefyre.co/app/public/t/fl-adap-recertification-notice/";
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-Recertified", HttpContext.Current.Session.SessionID, 1);
                        break;

                    case "ep_aca_nov": //Used for November of current year after open enrollment starts for next year
                        //iframe2.Src = "https://amex.surefyre.co/app/public/178/";
                        iframe2.Src = "https://amex.surefyre.co/app/public/210/"; //2024 I already have insurance (ACA) Door B

                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-Enrolled-Nov", HttpContext.Current.Session.SessionID, 1);
                        break;

                    case "na_aca_se": //Special Enrollment Period
                        //iframe2.Src = "https://amex.surefyre.co/app/public/169/";
                        //iframe2.Src = "https://amex.surefyre.co/app/public/t/florida-adap-aca-assessment/";
                        //11/01/2024 - Per Andrew commented out line above and replaced with line below
                        iframe2.Src = "https://amex.surefyre.co/app/public/197/"; //2024 form
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-NotEnrolled-SEP", HttpContext.Current.Session.SessionID, 1);
                        break;
                    case "miamidade":
                        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("menu_FormName")).InnerHtml = "Miami-Dade ACA Assessment";

                        //iframe2.Src = "https://amex.surefyre.co/app/public/t/miami-dade-aca-assessment/";
                        //11/03/2024 - The link above and the link below should be the same (at least for 2024 open enrollment)
                        //11/03/2024 - So, the link above seems to have automatically gotten turned into 2025 so no need to add the "if datetime.now >= '11/04/2024' 6AM"
                        iframe2.Src = "https://amex.surefyre.co/app/public/257/";
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-MiamiDade", HttpContext.Current.Session.SessionID, 1);
                        break;
                    case "tax":
                        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("menu_FormName")).InnerHtml = "Upload Documents";

                        iframe2.Src = "https://amex.surefyre.co/app/public/t/brhpc-form-upload/";
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-RequiredTaxForms", HttpContext.Current.Session.SessionID, 1);
                        break;
                    case "ep_aca":
                        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("menu_FormName")).InnerHtml = "ACA Marketplace Health Insurance Enrollment";

                        //iframe2.Src = "https://amex.surefyre.co/app/public/t/florida-adap-aca-enrollment/";
                        if (DateTime.Now >= Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings["OpenEnrollmentStart_2024_2025"]))
                            iframe2.Src = "https://amex.surefyre.co/app/public/250/"; //2025 I already have insurance (ACA) Door B
                        else
                            iframe2.Src = "https://amex.surefyre.co/app/public/210/"; //2024 I already have insurance (ACA) Door B
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-Enrolled", HttpContext.Current.Session.SessionID, 1);
                        break;
                    case "ep_emp":
                        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("menu_FormName")).InnerHtml = "Employer Health Insurance Enrollment";                        

                        iframe2.Src = "https://amex.surefyre.co/app/public/t/fl-adap-employer-coverage-enrollment/";
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-EMPLOYER", HttpContext.Current.Session.SessionID, 1);
                        break;
                    case "ep_cob":
                        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("menu_FormName")).InnerHtml = "COBRA Health Insurance Enrollment";

                        iframe2.Src = "https://amex.surefyre.co/app/public/t/fl-adap-cobra-enrollment/";
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-COBRA", HttpContext.Current.Session.SessionID, 1);
                        break;
                    case "ep_agen":
                        //iframe2.Src = "https://amex.surefyre.co/app/public/t/fl-adap-agentbrokerassister-aca-enrollment/";

                        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("menu_FormName")).InnerHtml = "ACA Marketplace Health Insurance Enrollment";

                        if (Request.QueryString["y"] == "2025")
                        {
                            //11/04/2024 - Per Andrew the Agent form should be redirected to the 2025 regular Door B ******************************************************************************************************************
                            //iframe2.Src = "https://amex.surefyre.co/app/public/230/";
                            //iframe2.Src = "https://amex.surefyre.co/app/public/250/"; //2025 I already have insurance (ACA) Door B
                            iframe2.Src = "https://amex.surefyre.co/app/public/256/"; //Andrew emailed me this link on 11/13/2025
                        }
                        else if (Request.QueryString["y"] == "2024")
                        {
                            iframe2.Src = "https://amex.surefyre.co/app/public/230/";
                            //Commenting out line above and replaced with line below after December 1st (no current year allowed)
                            //Response.Redirect("default.aspx");
                        }
                        else
                            Response.Redirect("default.aspx", false);

                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-Agent", HttpContext.Current.Session.SessionID, 1);
                        break;

                    case "medicare_assessment":
                        iframe2.Src = "https://amex.surefyre.co/app/public/t/inbound-call-medicare-assessment/";
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-Medicare", HttpContext.Current.Session.SessionID, 1);

                        break;

                    case "browarddoh":
                        //iframe2.Src = "https://uat-amex.surefyre.co/app/public/t/fl-adap-broward-county-authorization-assessment/";
                        iframe2.Src = "https://amex.surefyre.co/app/public/t/fl-adap-broward-county-authorization-assessment/";
                        util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-Broward_Assessment", HttpContext.Current.Session.SessionID, 1);

                        break;
                }

                //divIframe2.InnerHtml = Request.QueryString["form"] + "<br /><br >" + iframe2.Src;

                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "$(function () { autoResize(); });", true);


            }
        }
    }
}