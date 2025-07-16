using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class premium_insurance_enrollment : System.Web.UI.Page
    {
        Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                util.PopulateDropDownIBM(ddCounty1, "SELECT County as Item_sysID, UPPER(County) as Item_Name FROM tblOptions_Counties order by County", "Select County...", "");

                cb2025.Checked = true;
                cb2025.ForeColor = System.Drawing.Color.FromName("#f26202");
                cb2024.Checked = false;


                /*
                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);
                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "LandingPage-Recertified", HttpContext.Current.Session.SessionID, 1);
                */
            }
        }

        protected void lbtnPremAssistGo_Click(object sender, EventArgs e)
        {
            try
            {

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