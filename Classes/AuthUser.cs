using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Insurance_Enrollment_2024.Classes
{
    public class AuthUser : System.Web.Services.Protocols.SoapHeader
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //public bool IsValid()
        public string IsValid()
        {
            int count = 0;
            //Query database for correct user credentials and return true or false accordlingly

            //string config = ConfigurationManager.ConnectionStrings[""].ConnectionString;

            try
            {
                //Check if username and password authenticated correctly
                if (UserName != "" && Password != "")
                {
                    String ConnString = ConfigurationManager.ConnectionStrings["ConnectionWebFormsIdentity"].ConnectionString;
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    //adapter.SelectCommand.CommandTimeout = 80;
                    adapter.SelectCommand = new SqlCommand("select * from tblUsers where Username = '" + UserName + "'", conn);
                    //adapter.SelectCommand = new SqlCommand("select * from AspNetUsers where Username = '" + UserName + "'", conn);
                    DataTable dt = new DataTable();
                    conn.Open();
                    try
                    {
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        //ADAP.ExceptionUtility.ExceptionUtility.LogException(ex, "InUtilities", HttpContext.Current.Request.Url.AbsolutePath + " - " + query, "");
                        dt = null;
                    }
                    finally
                    {
                        conn.Close();
                        adapter.Dispose();
                    }

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        string savedPasswordHash = dt.Rows[0]["Password"].ToString();
                        //string savedPasswordHash = dt.Rows[0]["PasswordHash"].ToString();
                        dt.Dispose();

                        /* Extract the bytes */
                        byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                        /* Get the salt */
                        byte[] salt = new byte[16];
                        Array.Copy(hashBytes, 0, salt, 0, 16);
                        /* Compute the hash on the password the user entered */
                        var pbkdf2 = new Rfc2898DeriveBytes(Password, salt, 10000);
                        byte[] hash = pbkdf2.GetBytes(20);
                        /* Compare the results */
                        bool loginSuccessful = true;
                        try
                        {
                            for (int i = 0; i < 20; i++)
                                if (hashBytes[i + 16] != hash[i])
                                    throw new UnauthorizedAccessException();
                        }
                        catch (Exception ex)
                        {
                            loginSuccessful = false;
                        }

                        if (loginSuccessful)
                        {
                            return "login Successful";
                            //return true;
                        }
                        else
                            return "login unsuccessful - " + UserName + " - " + Password;
                        //return false;
                    }
                    else
                        return "No record found for supplied username";
                    //return false;
                }
                else
                    return "Must supply username and password";
                //return false;
            }
            catch (Exception ex)
            {
                return "Catch Error: " + ex.Message;
                //return false;
            }



        }
    }
}