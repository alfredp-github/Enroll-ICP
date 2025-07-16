using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
            divFormMessage.InnerHtml = "";

            try
            {
                StringBuilder builder = new StringBuilder();
                divFormMessage.Visible = false;
                //string lineBreak = Environment.NewLine;
                string lineBreak = "<br />";

                if ((fname.Value.Trim().Length > 1 && fname.Value.Trim().Length < 101) && (email.Value.Trim().Length > 5 && email.Value.Trim().Length < 101) && (phone.Value.Trim().Length > 9 && phone.Value.Trim().Length < 21) && ddRole.SelectedIndex > 0)
                {
                    bool validated = false;
                    Regex rgEmail = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
                    Regex rgPhone = new Regex("^(?:\\+1)?\\s?\\(?\\d{3}\\)?[-.\\s]?\\d{3}[-.\\s]?\\d{4}$");
                    if (rgEmail.IsMatch(email.Value.Trim()) && rgPhone.IsMatch(phone.Value.Trim()))
                        validated = true;
                    else
                    {
                        validated = false;
                        if (!rgEmail.IsMatch(email.Value.Trim()))
                        {
                            builder.Append("Valid <b>Email</b> is required.");
                            builder.Append(lineBreak);
                        }
                        if (!rgPhone.IsMatch(phone.Value.Trim()))
                        {
                            builder.Append("Valid <b>Phone</b> is required.");
                        }
                    }

                    if (validated)
                    {
                        ListBox lbEmails = new ListBox();
                        //lbEmails.Items.Add("apena@brhpc.org");
                        //lbEmails.Items.Add("manthony@brhpc.org");
                        //lbEmails.Items.Add("ncohen@brhpc.org");
                        lbEmails.Items.Add(email.Value);

                        //This site is for the Registration of Agents, Brokers, Certified Application Counselors, Assisters and Case Managers. Registering will provide you with important information regarding client’s Marketplace notices and client eligibility information.

                        builder.Append("<b>Thank you for registering for Premium Plus Insurance Program Resource Access.</b>");
                        builder.Append(lineBreak);
                        builder.Append(lineBreak);
                        builder.Append("Registering will provide you with important information regarding client Marketplace notices and client eligibility information.");
                        builder.Append(lineBreak);
                        builder.Append(lineBreak);
                        builder.Append("Name: " + fname.Value);
                        builder.Append(lineBreak);
                        //builder.Append("Role: " + ddRole.SelectedValue);
                        builder.Append("Role: " + ddRole.SelectedItem.Text);
                        builder.Append(lineBreak);
                        if (organization.Value != "")
                        {
                            builder.Append("Organization: " + organization.Value);
                            builder.Append(lineBreak);
                        }
                        builder.Append("Email: " + email.Value);
                        builder.Append(lineBreak);
                        builder.Append("Phone: " + phone.Value);
                        builder.Append(lineBreak);

                        //Begin - Add to database
                        string dateNow = DateTime.Now.ToString();
                        String ConnString = ConfigurationManager.ConnectionStrings["ConnectionIBM"].ConnectionString;
                        System.Text.StringBuilder values = new System.Text.StringBuilder();
                        values.Append("@Agent_Name,");
                        values.Append("@Agent_Role,");
                        values.Append("@Agent_Organization,");
                        values.Append("@Agent_Email,");
                        values.Append("@Agent_Phone,");
                        values.Append("@Active,");
                        values.Append("@DateCreated");
                        string queryInsertUpdate = "INSERT INTO ICP_Admin_Reports.dbo.tblRegistration_Agent (" + values.ToString().Replace("@", "") + ") VALUES(" + values.ToString() + "); SELECT CAST(SCOPE_IDENTITY() AS int)";
                        using (SqlConnection conn = new SqlConnection(ConnString))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(queryInsertUpdate, conn))
                            {
                                cmd.Parameters.AddWithValue("@Agent_Name", fname.Value);
                                cmd.Parameters.AddWithValue("@Agent_Role", ddRole.SelectedValue);
                                cmd.Parameters.AddWithValue("@Agent_Organization", organization.Value);
                                cmd.Parameters.AddWithValue("@Agent_Email", email.Value);
                                cmd.Parameters.AddWithValue("@Agent_Phone", phone.Value);
                                cmd.Parameters.AddWithValue("@Active", 1);
                                cmd.Parameters.AddWithValue("@DateCreated", dateNow);

                                int modified = (int)cmd.ExecuteScalar();
                                cmd.Dispose();
                            }
                            conn.Close();
                        }
                        //End - Add to database

                        string mesg = "";
                        if (!HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost") && HttpContext.Current.Request.Url.AbsoluteUri.Contains("https://"))
                            //SendEmail_ChooseFromEmail(true, "apena@brhpc.org", "Premium Plus Insurance Program - Registration - TESTING", builder.ToString().Replace("<b>", "").Replace("</b>", ""), lbEmails);
                            //mesg = SendEmail_ChooseFromEmail(true, "notifications_ibmmbm@brhpc.org", "Premium Plus Insurance Program - Registration - TESTING", builder.ToString().Replace("<b>", "").Replace("</b>", ""), lbEmails);
                            mesg = SendEmail_ChooseFromEmail(true, "notifications_ibmmbm@brhpc.org", "Premium Plus Insurance Program - Registration", builder.ToString().Replace("<b>", "").Replace("</b>", ""), lbEmails);

                        if (mesg == "OK")
                        {
                            divForm.Visible = false;
                            divFormSubmitted.Visible = true;
                            divFormSubmitted.InnerHtml = builder.ToString() + lineBreak + "A confirmation email has been sent to: " + email.Value;
                        }
                        else
                        {
                            divFormMessage.Visible = true;
                            divFormMessage.InnerHtml = "<div style='line-height:125%; font-weight:bold; font-size:1.1em'>An unexpected error has occured while attempting to send the email confirmation.<br />The administrator has been notified.</div>";
                            throw new Exception("An unexpected error has occured while attempting to send the email confirmation. " + fname.Value + " " + email.Value + " " + phone.Value);
                        }
                    }
                    else
                    {
                        divFormMessage.Visible = true;
                        divFormMessage.InnerHtml = "<div style='margin-bottom:10px; line-height:125%; font-weight:bold; font-size:1.1em'>Please make the<br />following corrections:</div>" + builder.ToString();
                    }
                }
                else
                {
                    if (fname.Value.Length < 2 || fname.Value.Length > 100)
                    {
                        builder.Append("Valid <b>Name</b> is required.");
                        builder.Append(lineBreak);
                        fname.Style["border-color"] = "orangered";
                    }
                    if (ddRole.SelectedIndex < 1)
                    {
                        builder.Append("Valid <b>Role</b> is required.");
                        builder.Append(lineBreak);
                        ddRole.Style["border-color"] = "orangered";
                    }
                    if (email.Value.Length < 6 || email.Value.Length > 100)
                    {
                        builder.Append("Valid <b>Email</b> is required.");
                        builder.Append(lineBreak);
                        email.Style["border-color"] = "orangered";
                    }
                    if (phone.Value.Length < 10 || email.Value.Length > 20)
                    {
                        builder.Append("Valid <b>Phone</b> is required.");
                        builder.Append(lineBreak);
                        phone.Style["border-color"] = "orangered";
                    }

                    divFormMessage.Visible = true;
                    divFormMessage.InnerHtml = "<div style='margin-bottom:10px; line-height:125%; font-weight:bold; font-size:1.1em'>Please make the<br />following corrections:</div>" + builder.ToString();
                }
            }
            catch (Exception ex)
            {
                util.LogException(ex, "btnSubmit_Click", HttpContext.Current.Request.Url.AbsolutePath, "");
                divFormMessage.Visible = true;
                divFormMessage.InnerHtml = "<div style='line-height:125%; font-weight:bold; font-size:1.1em'>An unexpected error has occured.<br />The administrator has been notified.</div>";
            }


        }

        public string SendEmail_ChooseFromEmail(bool html, string tmpFrom, string tmpSubject, string tmpBody, ListBox lbEmails)
        {
            //return "";
            StringBuilder builder = new StringBuilder();
            Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();

            try
            {
                MailMessage message = new MailMessage();
                MailAddress messageAddres = new MailAddress("notifications_ibmmbm@brhpc.org");

                message.From = messageAddres;

                bool bccAdmin = true;

                if (html)
                {
                    for (int i = 0; i < lbEmails.Items.Count; ++i)
                    {
                        //tmpResult = tmpResult + lbEmails.Items[i].Text + "<br />";
                        //message.Bcc.Add(lbEmails.Items[i].Text);
                        message.To.Add(lbEmails.Items[i].Text);

                        builder.Append(lbEmails.Items[i].Text + ";");

                        //if (lbEmails.Items[i].Text == tmpAdminEmail)
                        //    bccAdmin = false;
                    }
                }
                else
                {
                    for (int i = 0; i < lbEmails.Items.Count; ++i)
                    {
                        //tmpResult = tmpResult + lbEmails.Items[i].Text + "<br />";
                        //message.Bcc.Add(lbEmails.Items[i].Text);
                        message.To.Add(lbEmails.Items[i].Text);

                        builder.Append(lbEmails.Items[i].Text + ";");

                        //if (lbEmails.Items[i].Text == tmpAdminEmail)
                        //    bccAdmin = false;
                    }
                }
                //return tmpResult;

                //if (bccAdmin)
                //    message.Bcc.Add(tmpAdminEmail);
                message.Bcc.Add("apena@brhpc.org");
                //message.Bcc.Add("manthony@brhpc.org");
                //message.Bcc.Add("ncohen@brhpc.org");

                message.Subject = tmpSubject;
                message.Body = tmpBody;
                message.IsBodyHtml = html;

                SmtpClient client = new SmtpClient();

                client.Send(message);

                return "OK";
            }
            catch (Exception ex)
            {
                util.LogException(ex, "InUtilities_SendEmail_NoReply", HttpContext.Current.Request.Url.AbsolutePath, "");

                return ex.Message;
            }
        }

    }
}