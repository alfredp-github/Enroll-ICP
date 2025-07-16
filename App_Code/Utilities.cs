using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024.App_Code
{
    public class Utilities
    {

       
        public void InsertRecord_Analytics(string IP_Address, string Source, string SessionID, int Active)
        {

            //return;

            string queryInsertUpdate = "";

            //SqlConnection conn = new SqlConnection(ConnString);
            try
            {
                string dateNow = DateTime.Now.ToString();

                String ConnString = ConfigurationManager.ConnectionStrings["ConnectionIBM"].ConnectionString;

                System.Text.StringBuilder values = new System.Text.StringBuilder();

                values.Append("@IP_Address,");
                values.Append("@Source,");
                values.Append("@SessionID,");
                values.Append("@Active,");
                values.Append("@DateCreated");

                // SqlCommand myCommand = new SqlCommand("Insert into Log_Analytics_Enroll (IP_Address, Source, SessionID, Active, DateCreated) values('" + util.GetIpAddress(wrapper) + "','Agent-Broker','" + HttpContext.Current.Session.SessionID + "',1,getdate())", conn);

                queryInsertUpdate = "INSERT INTO Log_Analytics_Enroll (" + values.ToString().Replace("@", "") + ") VALUES(" + values.ToString() + "); SELECT CAST(SCOPE_IDENTITY() AS int)";

                int item_sysID = -1;

                using (SqlConnection conn =
                    new SqlConnection(ConnString))
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        //new SqlCommand("INSERT INTO EmployeeDetails VALUES(" + "@Id, @Name, @Address)", conn))
                        new SqlCommand(queryInsertUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@IP_Address", IP_Address);
                        cmd.Parameters.AddWithValue("@Source", Source);
                        cmd.Parameters.AddWithValue("@SessionID", SessionID);

                        cmd.Parameters.AddWithValue("@Active", 1);
                        cmd.Parameters.AddWithValue("@DateCreated", dateNow);


                        //int rows = cmd.ExecuteNonQuery();
                        int modified = (int)cmd.ExecuteScalar();
                        item_sysID = modified;
                        cmd.Dispose();
                    }
                    //return "";

                    conn.Close();

                }
                //util.ClearForm_Recursive(divForm.Controls);
                //return "";

            }
            catch (Exception ex)
            {
                LogException(ex, "analytics", "InsertRecord_Analytics - " + Source, "");
                //return "";

            }

        }

        public string GetIpAddress(HttpRequestBase request)
        {
            try
            {
                if (request.Headers["CF-CONNECTING-IP"] != null)
                    return request.Headers["CF-CONNECTING-IP"];

                var ipAddress = request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                //return ipAddress + "<br />" + request.ServerVariables["REMOTE_ADDR"];

                if (!string.IsNullOrEmpty(ipAddress))
                {
                    var addresses = ipAddress.Split(',');
                    if (addresses.Length != 0)
                    {
                        if (addresses[0] == "Blank1")
                        {
                            return "";
                        }
                        else if (Regex.IsMatch(addresses[0].Replace(".", ""), @"^[0-9]+$"))
                        {
                            return addresses[0];
                        }
                        else
                            return "Not a valid IP Address1";
                    }
                    else
                    {
                        if (request.UserHostAddress == "")
                        {
                            return "Blank2";
                        }
                        else if (Regex.IsMatch(request.UserHostAddress.Replace(".", ""), @"^[0-9]+$"))
                        {
                            return request.UserHostAddress;
                        }
                        else
                            return "Not a valid IP Address2";
                    }
                }
                else
                {
                    if (request.UserHostAddress == "")
                    {
                        return "Blank3";
                    }
                    else if (Regex.IsMatch(request.UserHostAddress.Replace(".", ""), @"^[0-9]+$"))
                    {
                        return request.UserHostAddress;
                    }
                    else
                        return "Not a valid IP Address3";
                }
            }
            catch (Exception ex)
            {
                LogException(ex, "analytics", "GetIpAddress - ", "");
                return "Exception";

            }

        }

        public void LogException(Exception exc, string UserName, string ErrorPage, string Client_sysID)
        {
            //try
            //{
            //String ConnString = ConfigurationManager.ConnectionStrings["ConnectionADAP"].ConnectionString;
            String ConnString = "Data Source=SQLSERVER\\MSSQL2SERVER,50314;Initial Catalog=ICP;Integrated Security=True;Trusted_Connection=Yes";
            SqlConnection conn = new SqlConnection(ConnString);

            SqlCommand command = new SqlCommand("tblErrorLog_INSERT", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;

            //if (ErrorPage == "")
            //    ErrorPage = HttpContext.Current.Request.Url.AbsolutePath;

            //if (Client_sysID != "")
            //    ErrorPage = ErrorPage + " -Client:" + Client_sysID + ";";

            if (exc.InnerException != null)
            {
                command.Parameters.Add("@ErrorMessage", SqlDbType.VarChar).Value = exc.InnerException.Message;
                command.Parameters.Add("@ErrorException", SqlDbType.VarChar).Value = ErrorPage + " ---- " + exc.StackTrace;
            }
            else
            {
                command.Parameters.Add("@ErrorMessage", SqlDbType.VarChar).Value = exc.Message;
                command.Parameters.Add("@ErrorException", SqlDbType.VarChar).Value = ErrorPage + " ---- " + exc.StackTrace;
            }

            //command.Parameters.Add("@Client_sysID", SqlDbType.Int).Value = rdpCertificationDate.DbSelectedDate != null ? Convert.ToInt32(Session["Client_sysID"]) : DBNull.Value;

            conn.Open();
            int rows = command.ExecuteNonQuery();
            conn.Close();
            command.Dispose();


        }

        public DataTable GetDataTableIBM(string query)
        {
            try
            {
                if (query != "")
                {
                    //String ConnString = ConfigurationManager.ConnectionStrings["ConnectionIBM"].ConnectionString;
                    String ConnString = ConfigurationManager.ConnectionStrings["ConnectionIBM"].ConnectionString;

                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    //adapter.SelectCommand.CommandTimeout = 80;
                    adapter.SelectCommand = new SqlCommand(query, conn);

                    //Command command = new XXXCommand("UPDATE table SET fieldName = '@fieldName'", connection);
                    //command.commandText = "Update Table set fieldName = @Value"
                    //command.Parameters.Add("@Value", SqlDbType.Bit).Value = checkbox.selected

                    DataTable myDataTable = new DataTable();

                    conn.Open();

                    try
                    {
                        adapter.Fill(myDataTable);
                    }
                    catch (Exception ex)
                    {
                        if (HttpContext.Current.Session["LoggedInUser"] != null)
                            LogException(ex, HttpContext.Current.Session["LoggedInUser"].ToString() + "-InUtilities", HttpContext.Current.Request.Url.AbsolutePath + " - " + query, "");
                        else
                            LogException(ex, "InUtilities", HttpContext.Current.Request.Url.AbsolutePath + " - " + query, "");

                        myDataTable = null;
                    }
                    finally
                    {
                        conn.Close();
                        adapter.Dispose();

                    }

                    return myDataTable;
                }
                else return null;
            }
            catch (Exception ex)
            {
                LogException(ex, "InUtilities", HttpContext.Current.Request.Url.AbsolutePath + " - " + query, "");
                return null;
            }


        }

        public void PopulateDropDownIBM(DropDownList tmpDD, string query, string pleaseSelect, string lastOption)
        {
            Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
            DataTable dt = util.GetDataTableIBM(query);

            tmpDD.DataSource = dt;
            tmpDD.DataTextField = "Item_Name";
            tmpDD.DataValueField = "Item_sysID";
            tmpDD.DataBind();

            if (pleaseSelect != "")
            {
                ListItem li = new ListItem();
                li.Text = pleaseSelect;
                li.Value = "0";
                tmpDD.Items.Insert(0, li);
            }
            if (lastOption != "")
            {
                ListItem li = new ListItem();
                li.Text = lastOption;
                li.Value = "1000";
                tmpDD.Items.Add(li);
            }
        }





    }
}