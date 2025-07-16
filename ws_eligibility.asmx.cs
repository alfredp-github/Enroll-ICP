using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols; // Has "SoapHeader"

namespace Insurance_Enrollment_2024
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "https://enroll.brhpc.org/WebService_Eligibility/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class WebService_Eligibility : System.Web.Services.WebService
    {
        //public AuthHeader Credentials;
        //[SoapHeader("Credentials")]

        public Classes.AuthUser User;

        [WebMethod]
        //[SoapHeader("User", Required = true)]
        [SoapHeader("User")]
        //public string HelloWorld(string str)
        //public string HelloWorld(string uname, string pword, string str)
        //public Classes.ClientStatus HelloWorld(string uname, string pword, string str)
        public Classes.ClientStatus GetClientStatus(string ssn, string first_name, string last_name, string dob)
        {
            /*
            if (Credentials.UserName.ToLower() != "Guru99" || Credentials.Password.ToLower() != "Guru99Password")
            {
                throw new SoapException("Unauthorized", SoapException.ClientFaultCode);
            }
            else
            {
                return "Hello, " + str;
            }
            */
            /*
            Classes.ClientStatus cStatus1 = new Classes.ClientStatus();

            cStatus1.CheckStatus = "Client Not Found";
            cStatus1.Eligible = "";
            cStatus1.EligibilityExpireDate = "";
            cStatus1.FPL = "";
            cStatus1.FPL_Exception = "";
            cStatus1.Suspended = "";
            cStatus1.Medicare = "";
            cStatus1.Medicaid = "";

            cStatus1.DataMismatch_FirstName = "";
            cStatus1.DataMismatch_LastName = "";
            cStatus1.DataMismatch_DOB = "";
            cStatus1.DataMismatch_SSN = "";
            return cStatus1;
            */

            try
            {

                //throw new Exception("Test error log");

                if (User != null)
                {

                    //User.UserName = uname;
                    //User.Password = pword;

                    //if (User.IsValid())
                    string tmpValid = User.IsValid();
                    if (tmpValid == "login Successful")
                    {
                        String ConnString = ConfigurationManager.ConnectionStrings["ConnectionIBM"].ConnectionString;
                        //SqlConnection conn = new SqlConnection(ConnString);
                        //SqlDataAdapter adapter = new SqlDataAdapter();
                        //adapter.SelectCommand.CommandTimeout = 80;

                        // ********************************************************************************************************************************************
                        // ********************************************************************************************************************************************
                        // **************** Have to change this to Parameterized query to avoid SQL Injection ******************************************************
                        //string tmpQuery = "select SCPClientFirst, SCPClientLast, SCPDateOfBirth, SCPSSN, Eligible, SCPHousePoverty, SCPEligDateExpire from view_PE_Client_Profile_Full_Latest where replace(SCPSSN,'-','') = '" + ssn + "' ";
                        bool proceedWithQuery = false;
                        bool validSSN = false;
                        bool validDOB = false;
                        //if (ssn.Trim().Replace("'", "").Replace("-", "").Replace(" ", "").Length > 8)
                        //    proceedWithQuery = true;
                        if (ssn.Trim().Replace("'", "").Replace("-", "").Replace(" ", "").Length > 8)
                        {
                            if (ValidSSN(ssn.Trim().Replace("'", "").Replace("-", "").Replace(" ", "")))
                            {
                                validSSN = true;
                                proceedWithQuery = true;
                            }
                        }

                        //string tmpMedicare = " ,ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_MedicareMedicaid x where x.Medicare = 1 and x.SCPClientID = a.SCPClientID),'Unknown') as Medicare ";
                        //string tmpMedicaid = " ,ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_MedicareMedicaid x where x.Medicaid = 1 and x.SCPClientID = a.SCPClientID),'Unknown') as Medicaid ";
                        string tmpMedicare = " ,ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.view_Report_PE_Client_MedicareMedicaid x where x.Medicare = 1 and x.SCPClientID = a.SCPClientID),'Unknown') as Medicare ";
                        string tmpMedicaid = " ,ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.view_Report_PE_Client_MedicareMedicaid x where x.Medicaid = 1 and x.SCPClientID = a.SCPClientID),'Unknown') as Medicaid ";
                        // ************************************************* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! **************************************************************************************
                        // ************************************************* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! **************************************************************************************
                        // ************************************************* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! **************************************************************************************
                        // *************************************************                                                              **************************************************************************************
                        // *************************************************                                                              **************************************************************************************
                        // **********************************************  This report above is being populated/updated MANUALLY !!??!????  *************************************************************************************
                        // *************************************************                                                              **************************************************************************************
                        // *************************************************                                                              **************************************************************************************
                        // ************************************************* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! **************************************************************************************
                        // ************************************************* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! **************************************************************************************
                        // ************************************************* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! **************************************************************************************

                        //string tmpSuspended_ExcludeReasons = " AND SuspensionReason NOT IN ('Unapproved ACA Plan') ";
                        string tmpSuspended_ExcludeReasons = " AND SuspensionReason NOT IN ('Unapproved ACA Plan','Client did not provide insurance documents to BRHPC') ";

                        string tempTables = "select SCPClientID, DateApproved INTO #temp_Suspended1 FROM view_PE_ADAP_Suspension_Full_Latest where status = 'Approved' " + tmpSuspended_ExcludeReasons + " and DateTerminated is null and SCPClientID is not null; select SCPClientID, DateTerminated INTO #temp_Suspended2 FROM view_PE_ADAP_Suspension_Full_Latest where Status = 'Terminated' " + tmpSuspended_ExcludeReasons + " and SCPClientID is not null; ";
                        string tempTables_DropTable = " DROP TABLE #temp_Suspended1; DROP TABLE #temp_Suspended2; ";

                        string tempAE_AOR = " ,ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.AE_AOR_08_30_2024 x where x.PE_ID = a.SCPClientID),'No') as AE_AOR ";

                        //Treat 123-45-6789, 000-00-0000, 111-11-1111, etc as BLANK SSN (ie, not_enrolled SSN was entered)

                        //     Add new field: DataMismatch - "SSN Invalid", "SSN Found. DOB Mismatch", "SSN Found. Name Mismatch"


                        // ************************************************* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! **************************************************************************************
                        // *************************************************                                                              **************************************************************************************
                        // *************************************************  Is ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less50_Exception being updated????  **************************************************************************************
                        // *************************************************
                        // ************************************************* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! **************************************************************************************



                        string tmpQuery = "";

                        if (validSSN)
                        {
                            //tmpQuery = tempTables + "select SCPClientFirst, SCPClientLast, SCPDateOfBirth, SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where replace(SCPSSN,'-','') = @SSN " + tempTables_DropTable;
                            //tmpQuery = tempTables + "select SCPClientID, ISNULL(SCPClientFirst,'') as SCPClientFirst, ISNULL(SCPClientLast,'') as SCPClientLast, SCPDateOfBirth, ISNULL(SCPSSN,'') as SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where replace(SCPSSN,'-','') = @SSN " + tempTables_DropTable;
                            tmpQuery = tempTables + "select SCPClientID, ISNULL(SCPClientFirst,'') as SCPClientFirst, ISNULL(SCPClientLast,'') as SCPClientLast, SCPDateOfBirth, ISNULL(SCPSSN,'') as SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less50_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + tempAE_AOR + " from view_PE_Client_Profile_Full_Latest a where replace(SCPSSN,'-','') = @SSN " + tempTables_DropTable;
                        }

                        DateTime temp;
                        if (DateTime.TryParse(dob, out temp))
                        {
                            validDOB = true;

                            if (first_name.Trim().Replace("'", "").Replace("-", "").Replace(" ", "").Length > 0 && last_name.Trim().Replace("'", "").Replace("-", "").Replace(" ", "").Length > 0)
                                proceedWithQuery = true; //Got here becayse DOB was a valid date AND There is a non-empty first and last name

                            //tempTables = "select SCPClientID, DateApproved INTO #temp_Suspended1 FROM view_PE_ADAP_Suspension_Full_Latest where status = 'Approved' and DateTerminated is null and SCPClientID is not null; select SCPClientID, DateTerminated INTO #temp_Suspended2 FROM view_PE_ADAP_Suspension_Full_Latest where Status = 'Terminated' and SCPClientID is not null; ";
                            tempTables = "select SCPClientID, DateApproved INTO #temp_Suspended1 FROM view_PE_ADAP_Suspension_Full_Latest where status = 'Approved' " + tmpSuspended_ExcludeReasons + " and DateTerminated is null and SCPClientID is not null; select SCPClientID, DateTerminated INTO #temp_Suspended2 FROM view_PE_ADAP_Suspension_Full_Latest where Status = 'Terminated' " + tmpSuspended_ExcludeReasons + " and SCPClientID is not null; ";

                            //tempTables = tempTables + " select x.SCPClientID from view_PE_Client_Profile_Full_Latest x where x.SCPHousePoverty >= 75 OR ((select MAX(CAST(y.payment_year + y.payment_month as int)) from tblPayments y where y.Active = 1 and y.SCPClientID is not null and ISNULL(y.PaymentNumber,'') <> '' and y.SCPClientID = x.SCPClientID) > CAST((CAST(DATEPART(year,getdate()) as varchar) + RIGHT('00'+ISNULL(CAST(DATEPART(month,getdate()) as varchar),''),2)) as int)) OR (DATEDIFF(month, (select MAX(CAST( y.payment_month + '/1/' + y.payment_year as date)) from tblPayments y where y.Active = 1 and y.SCPClientID is not null and ISNULL(y.PaymentNumber,'') <> '' and y.SCPClientID = x.SCPClientID), CAST((CAST(DATEPART(month,getdate()) as varchar) + '/1/' + CAST(DATEPART(year,getdate()) as varchar)) as date) ) <= 6) OR x.SCPClientID in (select y.ClientID from aMekeel_Pilot_List_for_BRHPC_AE_2022 y); ";
                            tempTables_DropTable = " DROP TABLE #temp_Suspended1; DROP TABLE #temp_Suspended2; ";
                            /*
                            if (ssn.Trim().Replace("'", "").Replace("-", "").Replace(" ", "").Length > 8)
                                tmpQuery = tempTables + "select SCPClientFirst, SCPClientLast, SCPDateOfBirth, SCPSSN, Eligible, SCPHousePoverty, (select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID) as FPL_Exception, SCPEligDateExpire, (select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc) as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where replace(SCPSSN,'-','') = @SSN OR (SCPClientFirst = @FIRST_NAME and SCPClientLast = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                            else
                                tmpQuery = tempTables + "select SCPClientFirst, SCPClientLast, SCPDateOfBirth, SCPSSN, Eligible, SCPHousePoverty, (select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID) as FPL_Exception, SCPEligDateExpire, (select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc) as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where (SCPClientFirst = @FIRST_NAME and SCPClientLast = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                            */
                            //if (ssn.Trim().Replace("'", "").Replace("-", "").Replace(" ", "").Length > 8)
                            if (validSSN)
                                //tmpQuery = tempTables + "select SCPClientID, SCPClientFirst, SCPClientLast, SCPDateOfBirth, SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where replace(SCPSSN,'-','') = @SSN OR (SCPClientFirst = @FIRST_NAME and SCPClientLast = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                                //tmpQuery = tempTables + "select SCPClientID, ISNULL(SCPClientFirst,'') as SCPClientFirst, ISNULL(SCPClientLast,'') as SCPClientLast, SCPDateOfBirth, ISNULL(SCPSSN,'') as SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where replace(SCPSSN,'-','') = @SSN OR (SCPClientFirst = @FIRST_NAME and SCPClientLast = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                                //tmpQuery = tempTables + "select SCPClientID, ISNULL(SCPClientFirst,'') as SCPClientFirst, ISNULL(SCPClientLast,'') as SCPClientLast, SCPDateOfBirth, ISNULL(SCPSSN,'') as SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where replace(SCPSSN,'-','') = @SSN OR (replace(replace(replace(SCPClientFirst,'-',''),' ',''),'''','') = @FIRST_NAME and replace(replace(replace(SCPClientLast,'-',''),' ',''),'''','') = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                                tmpQuery = tempTables + "select SCPClientID, ISNULL(SCPClientFirst,'') as SCPClientFirst, ISNULL(SCPClientLast,'') as SCPClientLast, SCPDateOfBirth, ISNULL(SCPSSN,'') as SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less50_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + tempAE_AOR + " from view_PE_Client_Profile_Full_Latest a where replace(SCPSSN,'-','') = @SSN OR (replace(replace(replace(SCPClientFirst,'-',''),' ',''),'''','') = @FIRST_NAME and replace(replace(replace(SCPClientLast,'-',''),' ',''),'''','') = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                            else
                                //tmpQuery = tempTables + "select SCPClientID, SCPClientFirst, SCPClientLast, SCPDateOfBirth, SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where (SCPClientFirst = @FIRST_NAME and SCPClientLast = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                                //tmpQuery = tempTables + "select SCPClientID, ISNULL(SCPClientFirst,'') as SCPClientFirst, ISNULL(SCPClientLast,'') as SCPClientLast, SCPDateOfBirth, ISNULL(SCPSSN,'') as SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where (SCPClientFirst = @FIRST_NAME and SCPClientLast = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                                //tmpQuery = tempTables + "select SCPClientID, ISNULL(SCPClientFirst,'') as SCPClientFirst, ISNULL(SCPClientLast,'') as SCPClientLast, SCPDateOfBirth, ISNULL(SCPSSN,'') as SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less75_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + " from view_PE_Client_Profile_Full_Latest a where (replace(replace(replace(SCPClientFirst,'-',''),' ',''),'''','') = @FIRST_NAME and replace(replace(replace(SCPClientLast,'-',''),' ',''),'''','') = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                                tmpQuery = tempTables + "select SCPClientID, ISNULL(SCPClientFirst,'') as SCPClientFirst, ISNULL(SCPClientLast,'') as SCPClientLast, SCPDateOfBirth, ISNULL(SCPSSN,'') as SCPSSN, Eligible, SCPHousePoverty, ISNULL((select TOP 1 'Yes' from ICP_Admin_Reports.dbo.tblReport_PE_Client_FPL_Less50_Exception x where x.SCPClientID = a.SCPClientID),'No') as FPL_Exception, SCPEligDateExpire, ISNULL((select TOP 1 'Yes' from #temp_Suspended1 y where y.SCPClientID = a.SCPClientID and NOT EXISTS (select 1 from #temp_Suspended2 x where x.SCPClientID = y.SCPClientID and ISNULL(x.DateTerminated,'1/1/2000') >= y.DateApproved) ORDER BY y.DateApproved desc),'No') as Suspended " + tmpMedicare + tmpMedicaid + tempAE_AOR + " from view_PE_Client_Profile_Full_Latest a where (replace(replace(replace(SCPClientFirst,'-',''),' ',''),'''','') = @FIRST_NAME and replace(replace(replace(SCPClientLast,'-',''),' ',''),'''','') = @LAST_NAME and SCPDateOfBirth = @DOB)" + tempTables_DropTable;
                        }
                        else
                        {

                        }

                        //adapter.SelectCommand = new SqlCommand(tmpQuery, conn);
                        // ********************************************************************************************************************************************
                        // ********************************************************************************************************************************************
                        // ********************************************************************************************************************************************

                        //adapter.SelectCommand = new SqlCommand("select * from AspNetUsers where Username = '" + UserName + "'", conn);
                        DataTable dt = new DataTable();
                        //conn.Open();

                        Classes.ClientStatus cStatus = new Classes.ClientStatus();
                        try
                        {
                            if (ssn.Replace("-", "") == "123456789" && first_name.ToLower() == "alfred" && last_name.ToLower() == "brhpc")
                            {
                                dt = null;
                                cStatus.CheckStatus = "Client Found";
                                cStatus.Eligible = "Yes";
                                cStatus.EligibilityExpireDate = "12/31/2023";
                                cStatus.FPL = "100";
                                cStatus.FPL_Exception = "Yes";
                                cStatus.Suspended = "No";
                                cStatus.Medicare = "Unknown";
                                cStatus.Medicaid = "Unknown";

                                cStatus.DataMismatch_FirstName = "No";
                                cStatus.DataMismatch_LastName = "No";
                                cStatus.DataMismatch_DOB = "No";
                                cStatus.DataMismatch_SSN = "No";

                                cStatus.AE_AOR = "No";

                                LogCheck_ClientFound_Test(dt, cStatus.CheckStatus, cStatus.EligibilityExpireDate, cStatus);

                                return cStatus;
                            }
                            else if (ssn.Replace("-", "") == "123456789" || ssn == "123-45-6789")
                            {
                                dt = null;
                                cStatus.CheckStatus = "Client Found";
                                cStatus.Eligible = "Yes";
                                cStatus.EligibilityExpireDate = "12/31/2023";
                                cStatus.FPL = "100";
                                cStatus.FPL_Exception = "Yes";
                                cStatus.Suspended = "No";
                                cStatus.Medicare = "Unknown";
                                cStatus.Medicaid = "Unknown";

                                cStatus.DataMismatch_FirstName = "No";
                                cStatus.DataMismatch_LastName = "No";
                                cStatus.DataMismatch_DOB = "No";
                                cStatus.DataMismatch_SSN = "No";

                                cStatus.AE_AOR = "No";

                                LogCheck_ClientFound_Test(dt, cStatus.CheckStatus, cStatus.EligibilityExpireDate, cStatus);

                                return cStatus;

                            }
                            else if (first_name.ToLower() == "alfred" && last_name.ToLower() == "brhpc")
                            {
                                dt = null;
                                cStatus.CheckStatus = "Client Found";
                                cStatus.Eligible = "Yes";
                                cStatus.EligibilityExpireDate = "12/31/2023";
                                cStatus.FPL = "50";
                                cStatus.FPL_Exception = "Yes";
                                cStatus.Suspended = "No";
                                cStatus.Medicare = "Unknown";
                                cStatus.Medicaid = "Unknown";

                                cStatus.DataMismatch_FirstName = "No";
                                cStatus.DataMismatch_LastName = "No";
                                cStatus.DataMismatch_DOB = "No";
                                cStatus.DataMismatch_SSN = "No";

                                cStatus.AE_AOR = "No";

                                LogCheck_ClientFound_Test(dt, cStatus.CheckStatus, cStatus.EligibilityExpireDate, cStatus);

                                return cStatus;

                            }


                            //adapter.Fill(dt);v

                            if (proceedWithQuery)
                            {
                                using (SqlConnection conn = new SqlConnection(ConnString))
                                {
                                    conn.Open();
                                    using (SqlCommand cmd = new SqlCommand(tmpQuery, conn))
                                    {
                                        //cmd.Parameters.Add("@Item_sysID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                                        cmd.Parameters.AddWithValue("@SSN", ssn.Trim().Replace("'", "").Replace("-", ""));
                                        cmd.Parameters.AddWithValue("@FIRST_NAME", first_name.Trim().Replace("'", "").Replace("-", "").Replace(" ", ""));
                                        cmd.Parameters.AddWithValue("@LAST_NAME", last_name.Trim().Replace("'", "").Replace("-", "").Replace(" ", ""));
                                        if (validDOB)
                                            cmd.Parameters.AddWithValue("@DOB", dob.Trim().Replace("'", ""));
                                        else
                                            cmd.Parameters.AddWithValue("@DOB", DBNull.Value);
                                        //cmd.Parameters.AddWithValue("@DOB", dob.Trim().Replace("-", "").Replace("'", "").Replace(" ", "")); //Shoudn't need the "Replace" because checking above for valid date 
                                        //cmd.Parameters.AddWithValue("@Result", cbResult.Checked ? 1 : 0);

                                        SqlDataReader results = cmd.ExecuteReader();
                                        //DataTable dt = new DataTable();
                                        dt.Load(results);

                                        cmd.Dispose();
                                    }
                                    conn.Close();
                                }

                                if (dt != null)
                                {
                                    if (dt.Rows.Count > 0)
                                    {
                                        cStatus.CheckStatus = "Client Found";
                                        cStatus.Eligible = dt.Rows[0]["Eligible"].ToString();

                                        if (DateTime.TryParse(dt.Rows[0]["SCPEligDateExpire"].ToString(), out temp))
                                            cStatus.EligibilityExpireDate = Convert.ToDateTime(dt.Rows[0]["SCPEligDateExpire"]).ToShortDateString();
                                        else
                                            cStatus.EligibilityExpireDate = "";

                                        cStatus.FPL = dt.Rows[0]["SCPHousePoverty"].ToString();

                                        cStatus.FPL_Exception = dt.Rows[0]["FPL_Exception"].ToString();
                                        cStatus.Suspended = dt.Rows[0]["Suspended"].ToString();

                                        if (dt.Rows[0]["Medicare"] == DBNull.Value)
                                            cStatus.Medicare = "Unknown";
                                        else if (dt.Rows[0]["Medicare"].ToString().Trim() != "Yes")
                                            cStatus.Medicare = "Unknown";
                                        else
                                            cStatus.Medicare = "Yes";

                                        if (dt.Rows[0]["Medicaid"] == DBNull.Value)
                                            cStatus.Medicaid = "Unknown";
                                        else if (dt.Rows[0]["Medicaid"].ToString().Trim() != "Yes")
                                            cStatus.Medicaid = "Unknown";
                                        else
                                            cStatus.Medicaid = "Yes";
                                        /*
                                        if (dt.Rows[0]["AE_AOR"] == DBNull.Value)
                                            cStatus.AE_AOR = "Unknown";
                                        else 
                                        */
                                            cStatus.AE_AOR = dt.Rows[0]["AE_AOR"].ToString();

                                        //cStatus.Medicare = dt.Rows[0]["Medicare"].ToString();
                                        //cStatus.Medicaid = dt.Rows[0]["Medicaid"].ToString();

                                        //LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, "Testing ssn", null);

                                        if (validSSN) //Client was found by EITHER the valid SSN or (First + Last + DOB)
                                        {
                                            //On 11/04/2022 added the "ToLower" because was getting false mismatch
                                            if (dt.Rows[0]["SCPClientFirst"].ToString().Trim().Replace("'", "").Replace("-", "").Replace(" ", "") != "" && first_name.Trim().Replace("'", "").Replace("-", "").Replace(" ", "") != "")
                                            {
                                                if (dt.Rows[0]["SCPClientFirst"].ToString().Trim().Replace("'", "").Replace("-", "").Replace(" ", "").ToLower() != first_name.Trim().Replace("'", "").Replace("-", "").Replace(" ", "").ToLower())
                                                    cStatus.DataMismatch_FirstName = "Yes";
                                                else
                                                    cStatus.DataMismatch_FirstName = "No";
                                            }
                                            else
                                                cStatus.DataMismatch_FirstName = "No"; //No mismatch if First Name is BLANK in PE

                                            if (dt.Rows[0]["SCPClientLast"].ToString().Trim().Replace("'", "").Replace("-", "").Replace(" ", "") != "" && last_name.Trim().Replace("'", "").Replace("-", "").Replace(" ", "") != "")
                                            {
                                                if (dt.Rows[0]["SCPClientLast"].ToString().Trim().Replace("'", "").Replace("-", "").Replace(" ", "").ToLower() != last_name.Trim().Replace("'", "").Replace("-", "").Replace(" ", "").ToLower())
                                                    cStatus.DataMismatch_LastName = "Yes";
                                                else
                                                    cStatus.DataMismatch_LastName = "No";
                                            }
                                            else
                                                cStatus.DataMismatch_LastName = "No"; //No mismatch if Last Name is BLANK in PE

                                            if (validDOB)
                                            {
                                                //if (DateTime.TryParse(dt.Rows[0]["SCPDateOfBirth"].ToString().Trim().Replace("-", "").Replace("'", "").Replace(" ", ""), out temp)) //Valid PE Birth Date (implies non-blank)
                                                if (DateTime.TryParse(dt.Rows[0]["SCPDateOfBirth"].ToString(), out temp)) //Valid PE Birth Date (implies non-blank)
                                                {
                                                    //if (Convert.ToDateTime(dt.Rows[0]["SCPDateOfBirth"].ToString().Trim().Replace("-", "").Replace("'", "").Replace(" ", "")) != Convert.ToDateTime(dob.Trim().Replace("-", "").Replace("'", "").Replace(" ", "")))
                                                    if (Convert.ToDateTime(dt.Rows[0]["SCPDateOfBirth"].ToString()) != Convert.ToDateTime(dob.Trim().Replace("'", "")))
                                                    {
                                                        cStatus.DataMismatch_DOB = "Yes";
                                                    }
                                                    else
                                                        cStatus.DataMismatch_DOB = "No";
                                                }
                                                else
                                                {
                                                    cStatus.DataMismatch_DOB = "Yes"; //Blank or Non-Valid DOB is in PE so, by default, there is a mismatch (even if blank in entered by client)
                                                                                      //LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, dt.Rows[0]["SCPDateOfBirth"].ToString().Trim().Replace("'", "").Replace(" ", ""), null);
                                                }
                                            }
                                            else if (dob.Trim().Replace("'", "") == "")
                                                cStatus.DataMismatch_DOB = "No";
                                            else
                                                cStatus.DataMismatch_DOB = "Yes"; //Blank or Non-Valid DOB was entered by client so, by default, there is a mismatch (even if blank in PE)

                                            if (dt.Rows[0]["SCPSSN"].ToString().Trim().Replace("-", "").Replace(" ", "") != "")
                                            {
                                                if (ssn.Trim().Replace("'", "").Replace("-", "") != dt.Rows[0]["SCPSSN"].ToString().Trim().Replace("-", "").Replace(" ", ""))
                                                    cStatus.DataMismatch_SSN = "Yes";
                                                else
                                                    cStatus.DataMismatch_SSN = "No";
                                            }
                                            else
                                                cStatus.DataMismatch_SSN = "No"; //if PE does not have a SSN then no mismatch (ie, only when both sides have a SSN can we have a mismatch)

                                        }
                                        else //Must have found client via (First + Last + DOB)
                                        {
                                            if (ssn.Trim().Replace("'", "").Replace("-", "") != "" && dt.Rows[0]["SCPSSN"].ToString().Trim().Replace("-", "").Replace(" ", "") != "")
                                            {
                                                if (ssn.Trim().Replace("'", "").Replace("-", "") != dt.Rows[0]["SCPSSN"].ToString().Trim().Replace("-", "").Replace(" ", ""))
                                                    cStatus.DataMismatch_SSN = "Yes";
                                                else
                                                    cStatus.DataMismatch_SSN = "No";


                                            }
                                            else
                                            {
                                                cStatus.DataMismatch_SSN = "No"; //If client did not enter SSN then no mismatch OR if PE does not have a SSN then no mismatch (ie, only when both sides have a SSN can we have a mismatch)

                                                //LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, ssn.Trim().Replace("'", "").Replace("-", "") + " - " + dt.Rows[0]["SCPSSN"].ToString().Trim().Replace("-", "").Replace(" ", ""), null);
                                            }

                                            //cStatus.DataMismatch_FirstName = "No";
                                            //cStatus.DataMismatch_LastName = "No";
                                            //cStatus.DataMismatch_DOB = "No";
                                        }

                                        LogCheck_ClientFound(dt, cStatus.CheckStatus, cStatus.EligibilityExpireDate, cStatus);

                                        if (cStatus.DataMismatch_FirstName == "Yes" || cStatus.DataMismatch_LastName == "Yes" || cStatus.DataMismatch_DOB == "Yes" || cStatus.DataMismatch_SSN == "Yes")
                                        {
                                            LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, "Client Found", null, dt.Rows[0]["SCPClientID"].ToString());
                                            InsertRecord_NotFound_Or_Error(ssn, first_name, last_name, dob, "Client Found", null, dt.Rows[0]["SCPClientID"].ToString(), validDOB);
                                        }

                                        Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities(); //
                                        /*
                                        DataTable dtHas_BOPLAT24J0108 = util.GetDataTableIBM(" select PE_ID from ICP_Admin_Reports.dbo.aCristy_Mekeel_Have_BOPlat24J0108_10_30_2024 where PE_ID = '" + dt.Rows[0]["SCPClientID"].ToString().Trim() + "' ");
                                        if (dtHas_BOPLAT24J0108 != null)
                                        {
                                            if (dtHas_BOPLAT24J0108.Rows.Count > 0)
                                            {
                                                cStatus.Has_BOPLAT24J0108 = "Yes";
                                            }
                                            else
                                                cStatus.Has_BOPLAT24J0108 = "No";

                                            dtHas_BOPLAT24J0108.Dispose();
                                        }
                                        else
                                            cStatus.Has_BOPLAT24J0108 = "No";
                                        */
                                        DataTable dtHas_Group5_Plan = util.GetDataTableIBM(" select PE_ID, PlanName from ICP_Admin_Reports.dbo.aACA_Plans_Group5_HighCost_10_31_2024 where Active = 1 and PE_ID = '" + dt.Rows[0]["SCPClientID"].ToString().Trim() + "' ");
                                        if (dtHas_Group5_Plan != null)
                                        {
                                            if (dtHas_Group5_Plan.Rows.Count > 0)
                                            {
                                                cStatus.Has_BOPLAT24J0108 = "No";
                                                cStatus.Has_BOPLAT24J0105 = "No";
                                                cStatus.Has_BOPLAT24J0121S = "No";
                                                cStatus.Has_BOSILV24J0103 = "No";
                                                cStatus.Has_BOSILV24J0119S = "No";

                                                switch (dtHas_Group5_Plan.Rows[0]["PlanName"].ToString())
                                                {
                                                    case "BOPLAT24J0108":
                                                        cStatus.Has_BOPLAT24J0108 = "Yes";
                                                        break;
                                                    case "BOPLAT24J0105":
                                                        cStatus.Has_BOPLAT24J0105 = "Yes";
                                                        break;
                                                    case "BOPLAT24J0121S":
                                                        cStatus.Has_BOPLAT24J0121S = "Yes";
                                                        break;
                                                    case "BOSILV24J0103":
                                                        cStatus.Has_BOSILV24J0103 = "Yes";
                                                        break;
                                                    case "BOSILV24J0119S":
                                                        cStatus.Has_BOSILV24J0119S = "Yes";
                                                        break;
                                                }

                                            }
                                            else
                                            {
                                                cStatus.Has_BOPLAT24J0108 = "No";
                                                cStatus.Has_BOPLAT24J0105 = "No";
                                                cStatus.Has_BOPLAT24J0121S = "No";
                                                cStatus.Has_BOSILV24J0103 = "No";
                                                cStatus.Has_BOSILV24J0119S = "No";
                                            }

                                            dtHas_Group5_Plan.Dispose();
                                        }
                                        else
                                        {
                                            cStatus.Has_BOPLAT24J0108 = "No";
                                            cStatus.Has_BOPLAT24J0105 = "No";
                                            cStatus.Has_BOPLAT24J0121S = "No";
                                            cStatus.Has_BOSILV24J0103 = "No";
                                            cStatus.Has_BOSILV24J0119S = "No";
                                        }

                                    }
                                    else
                                    {
                                        cStatus.CheckStatus = "Client Not Found";
                                        LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "");
                                        InsertRecord_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "", validDOB);
                                    }
                                }
                                else
                                {
                                    cStatus.CheckStatus = "Client Not Found";
                                    LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "");
                                    InsertRecord_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "", validDOB);
                                }
                            }
                            else
                            {
                                cStatus.CheckStatus = "Client Not Found";
                                LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "");
                                InsertRecord_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "", validDOB);
                            }
                            /*
                            try
                            {
                                //Log the Eligibility Check
                                using (SqlConnection connLog = new SqlConnection(ConnString))
                                {
                                    connLog.Open();
                                    SqlCommand myCommandLog = new SqlCommand("Insert into ICP_Admin_Reports.dbo.tblWS_Eligibility_Check (PE_ID,first_name,last_name,ssn,date_of_birth,CheckStatus,Eligible,EligibilityExpireDate,FPL,FPL_Exception,Suspended,Medicare,Medicaid,DateCreated,Active,CallerID) values " +
                                        "'','" + dt.Rows[0]["SCPClientFirst"].ToString() + "','" + dt.Rows[0]["SCPClientLast"].ToString() + "','" + dt.Rows[0]["SCPSSN"].ToString() + "','" + dt.Rows[0]["SCPDateOfBirth"].ToString() + "','" + cStatus.CheckStatus + "'," + dt.Rows[0]["Eligible"].ToString() + ",'" + cStatus.EligibilityExpireDate + "','" + dt.Rows[0]["SCPHousePoverty"].ToString() + "', " + (dt.Rows[0]["FPL_Exception"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Suspended"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicare"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicaid"].ToString() == "Yes" ? 1 : 0).ToString() + ",1,getdate(),'')", connLog);
                                    int resultLog = myCommandLog.ExecuteNonQuery();
                                    myCommandLog.Dispose();
                                    connLog.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                LogException(ex, "ws_eligibility", "LogCheck", "");
                            }
                            */
                            /*
                            //tblWS_Eligibility_Check
                            PE_ID varchar(10)
                            first_name varchar(100)
                            last_name varchar(100)
                            ssn varchar(12)
                            date_of_birth datetime
                            CheckStatus varchar(50)
                            Eligible smallint
                            EligibilityExpireDate datetime
                            FPL int
                            FPL_Exception   smallint
                            Suspended   smallint
                            Medicare    smallint
                            Medicaid    smallint
                            DateCreated datetime
                            Active  int
                            CallerID    varchar(50)
                            */
                        }
                        catch (Exception ex)
                        {
                            dt = null;
                            cStatus.CheckStatus = "Unexpected Error";
                            cStatus.Eligible = "";
                            cStatus.EligibilityExpireDate = "";
                            cStatus.FPL = "";
                            cStatus.FPL_Exception = "";
                            cStatus.Suspended = "";
                            cStatus.Medicare = "";
                            cStatus.Medicaid = "";

                            cStatus.AE_AOR = "";

                            cStatus.DataMismatch_FirstName = "";
                            cStatus.DataMismatch_LastName = "";
                            cStatus.DataMismatch_DOB = "";
                            cStatus.DataMismatch_SSN = "";

                            LogException(ex, "ws_eligibility", "GetClientStatus", "");
                            LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "");
                            InsertRecord_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "", validDOB);
                        }
                        finally
                        {
                            //conn.Close();
                            //adapter.Dispose();
                            if (dt != null)
                                dt.Dispose();
                        }
                        /*
                        Classes.ClientStatus cStatus = new Classes.ClientStatus();
                        cStatus.CheckStatus = "Client Found";
                        cStatus.Eligible = "Yes";
                        cStatus.EligibilityExpireDate = DateTime.Now;
                        cStatus.FPL = 98;
                        */
                        return cStatus;
                        //return "Hello, " + str + " - " + User.UserName;
                    }
                    else
                    {
                        //return null;
                        Classes.ClientStatus cStatus = new Classes.ClientStatus();
                        //cStatus.CheckStatus = tmpValid;// "Authentication Failed";
                        cStatus.CheckStatus = "Not Valid";
                        LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "");
                        InsertRecord_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "", false);
                        return cStatus;
                    }
                }
                else
                {
                    //return null;
                    Classes.ClientStatus cStatus = new Classes.ClientStatus();
                    //cStatus.CheckStatus = "User is null";//'"No Authentication";
                    cStatus.CheckStatus = "Not Valid";
                    LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "");
                    InsertRecord_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "", false);
                    return cStatus;
                }
            }
            catch (Exception ex)
            {
                LogException(ex, "ws_eligibility", "GetClientStatus_UserNull", "");

                Classes.ClientStatus cStatus = new Classes.ClientStatus();
                cStatus.CheckStatus = "Not Valid";
                return cStatus;

                //LogCheck_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "");
                //InsertRecord_NotFound_Or_Error(ssn, first_name, last_name, dob, cStatus.CheckStatus, null, "");
            }

        }
        /*
        public class AuthHeader : SoapHeader
        {
            public string UserName;
            public string Password;
        }
        */

        private void LogException(Exception exc, string UserName, string ErrorPage, string Client_sysID)
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
            /*
            if (!HttpContext.Current.Request.Url.AbsoluteUri.Contains("localhost"))
            {
                if (exc.Message != "Thread was being aborted." && exc.Message != "Validation of Anti - XSRF token failed." && ErrorPage != "Attempting login")
                {
                    //return;
                    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage("ibmmbm_claims@brhpc.org", "alfredp@nexsoftware.com");
                    message.Subject = "ICP - Error";
                    message.Body = "An error was generated by ICP - " + ErrorPage;
                    message.IsBodyHtml = false;

                    System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                    client.Send(message);
                }
            }
            */

            /*
            }
            catch (Exception tmpEx)
            {
                LogException(tmpEx, "inLogException", "", "");
            }
            */

        }

        private string Replace_CaseInsensitive(string input, string oldValue, string newValue)
        {
            //string result = Regex.Replace(input, "world", "csharp", RegexOptions.IgnoreCase);
            return Regex.Replace(input, oldValue, newValue, RegexOptions.IgnoreCase);
        }

        private void LogCheck_NotFound_Or_Error(string ssn, string first_name, string last_name, string dob, string cCheckStatus, string cEligibilityExpireDate, string PE_ID)
        {
            //Need FirstName, LastName, DOB, SSN to SAFELY log
            //FirstName,LastName,DOB,SSN,CheckStatus,DateCreated
            //string tmpRecord = Replace_CaseInsensitive(Replace_CaseInsensitive(first_name.Trim(), "delete", ""), "trunc", "") + "," + last_name.Trim() + "," + dob.Trim() + "," + ssn.Trim() + "," + cCheckStatus + "," + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            string tmpRecord = Replace_CaseInsensitive(Replace_CaseInsensitive(first_name.Trim(), "delete", ""), "trunc", "") + "," + last_name.Trim() + "," + dob.Trim() + "," + ssn.Trim() + "," + cCheckStatus + "," + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "," + PE_ID.Trim();

            try
            {
                File.AppendAllText(@"C:\inetpub\wwwroot\ICP\Documents\EDI\AE\ws_eligibility\LogCheck_NotFound_Or_Error.txt", tmpRecord + Environment.NewLine);
            }
            catch (Exception ex)
            {
                LogException(ex, "ws_eligibility", "LogCheck_NotFound_Or_Error - " + tmpRecord, "");
            }

        }

        private void InsertRecord_NotFound_Or_Error(string ssn, string first_name, string last_name, string dob, string cCheckStatus, string cEligibilityExpireDate, string PE_ID, bool validDOB)
        {
            string queryInsertUpdate = "";

            //SqlConnection conn = new SqlConnection(ConnString);
            try
            {
                string dateNow = DateTime.Now.ToString();

                String ConnString = ConfigurationManager.ConnectionStrings["ConnectionIBM"].ConnectionString;

                System.Text.StringBuilder values = new System.Text.StringBuilder();

                values.Append("@PE_ID,");
                values.Append("@first_name,");
                values.Append("@last_name,");
                values.Append("@ssn,");
                values.Append("@date_of_birth,");
                values.Append("@CheckStatus,");
                values.Append("@DateCreated,");
                values.Append("@Active");

                queryInsertUpdate = "INSERT INTO ICP_Admin_Reports.dbo.tblWS_Eligibility_Check_ClientNotFound (" + values.ToString().Replace("@", "") + ") VALUES(" + values.ToString() + "); SELECT CAST(SCOPE_IDENTITY() AS int)";

                int item_sysID = -1;

                using (SqlConnection conn =
                    new SqlConnection(ConnString))
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        //new SqlCommand("INSERT INTO EmployeeDetails VALUES(" + "@Id, @Name, @Address)", conn))
                        new SqlCommand(queryInsertUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@PE_ID", PE_ID);
                        cmd.Parameters.AddWithValue("@first_name", first_name);

                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@ssn", ssn);
                        if (validDOB)
                            cmd.Parameters.AddWithValue("@date_of_birth", dob);
                        else
                            cmd.Parameters.AddWithValue("@date_of_birth", DBNull.Value);

                        cmd.Parameters.AddWithValue("@CheckStatus", cCheckStatus);

                        cmd.Parameters.AddWithValue("@DateCreated", dateNow);

                        cmd.Parameters.AddWithValue("@Active", 1);

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
                LogException(ex, "ws_eligibility", "InsertRecord_NotFound_Or_Error - " + queryInsertUpdate, "");
                //return "";

            }

        }

        //private void LogCheck_ClientFound(DataTable dt, string cCheckStatus, string cEligibilityExpireDate)
        private void LogCheck_ClientFound(DataTable dt, string cCheckStatus, string cEligibilityExpireDate, Classes.ClientStatus cStatus)
        {
            //string tmpQuery = "Insert into ICP_Admin_Reports.dbo.tblWS_Eligibility_Check (PE_ID,first_name,last_name,ssn,date_of_birth,CheckStatus,Eligible,EligibilityExpireDate,FPL,FPL_Exception,Suspended,Medicare,Medicaid,DateCreated,Active,CallerID) values " +
            //"('" + dt.Rows[0]["SCPClientID"].ToString() + "','" + dt.Rows[0]["SCPClientFirst"].ToString() + "','" + dt.Rows[0]["SCPClientLast"].ToString() + "','" + dt.Rows[0]["SCPSSN"].ToString() + "','" + dt.Rows[0]["SCPDateOfBirth"].ToString() + "','" + cCheckStatus + "'," + (dt.Rows[0]["Eligible"].ToString() == "Yes" ? 1 : 0).ToString() + ",'" + cEligibilityExpireDate + "','" + dt.Rows[0]["SCPHousePoverty"].ToString() + "', " + (dt.Rows[0]["FPL_Exception"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Suspended"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicare"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicaid"].ToString() == "Yes" ? 1 : 0).ToString() + ",getdate(),1,'')";
            string tmpQuery = "Insert into ICP_Admin_Reports.dbo.tblWS_Eligibility_Check (PE_ID,first_name,last_name,ssn,date_of_birth,CheckStatus,Eligible,EligibilityExpireDate,FPL,FPL_Exception,Suspended,Medicare,Medicaid,DateCreated,Active,CallerID,DataMismatch_FirstName,DataMismatch_LastName,DataMismatch_DOB,DataMismatch_SSN) values " +
             "('" + dt.Rows[0]["SCPClientID"].ToString() + "','" + dt.Rows[0]["SCPClientFirst"].ToString().Replace("'", "") + "','" + dt.Rows[0]["SCPClientLast"].ToString().Replace("'", "") + "','" + dt.Rows[0]["SCPSSN"].ToString() + "','" + dt.Rows[0]["SCPDateOfBirth"].ToString() + "','" + cCheckStatus + "'," + (dt.Rows[0]["Eligible"].ToString() == "Yes" ? 1 : 0).ToString() + ",'" + cEligibilityExpireDate + "','" + dt.Rows[0]["SCPHousePoverty"].ToString() + "', " + (dt.Rows[0]["FPL_Exception"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Suspended"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicare"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicaid"].ToString() == "Yes" ? 1 : 0).ToString() + ",getdate(),1,''," + (cStatus.DataMismatch_FirstName == "Yes" ? 1 : 0).ToString() + "," + (cStatus.DataMismatch_LastName == "Yes" ? 1 : 0).ToString() + "," + (cStatus.DataMismatch_DOB == "Yes" ? 1 : 0).ToString() + "," + (cStatus.DataMismatch_SSN == "Yes" ? 1 : 0).ToString() + ")";

            string dateNow = DateTime.Now.ToString();

            System.Text.StringBuilder values = new System.Text.StringBuilder();

            values.Append("@PE_ID,");
            values.Append("@first_name,");
            values.Append("@last_name,");
            values.Append("@ssn,");
            values.Append("@date_of_birth,");
            values.Append("@CheckStatus,");

            values.Append("@Eligible,");
            values.Append("@EligibilityExpireDate,");
            values.Append("@FPL,");
            values.Append("@FPL_Exception,");
            values.Append("@Suspended,");
            values.Append("@Medicare,");
            values.Append("@Medicaid,");
            values.Append("@DateCreated,");
            values.Append("@Active,");
            values.Append("@CallerID,");
            values.Append("@DataMismatch_FirstName,");
            values.Append("@DataMismatch_LastName,");
            values.Append("@DataMismatch_DOB,");
            values.Append("@DataMismatch_SSN");
            //Eligible,EligibilityExpireDate,FPL,FPL_Exception,Suspended,Medicare,Medicaid,DateCreated,Active,CallerID,DataMismatch_FirstName,DataMismatch_LastName,DataMismatch_DOB,DataMismatch_SSN
            string queryInsertUpdate = "INSERT INTO ICP_Admin_Reports.dbo.tblWS_Eligibility_Check (" + values.ToString().Replace("@", "") + ") VALUES(" + values.ToString() + "); SELECT CAST(SCOPE_IDENTITY() AS int)";
            int item_sysID = -1;

            try
            {
                //Log the Eligibility Check
                String ConnString = ConfigurationManager.ConnectionStrings["ConnectionIBM"].ConnectionString;

                using (SqlConnection conn =
                    new SqlConnection(ConnString))
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        //new SqlCommand("INSERT INTO EmployeeDetails VALUES(" + "@Id, @Name, @Address)", conn))
                        new SqlCommand(queryInsertUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@PE_ID", dt.Rows[0]["SCPClientID"].ToString());
                        cmd.Parameters.AddWithValue("@first_name", dt.Rows[0]["SCPClientFirst"].ToString().Replace("'", ""));
                        cmd.Parameters.AddWithValue("@last_name", dt.Rows[0]["SCPClientLast"].ToString().Replace("'", ""));
                        cmd.Parameters.AddWithValue("@ssn", dt.Rows[0]["SCPSSN"].ToString());
                        cmd.Parameters.AddWithValue("@date_of_birth", dt.Rows[0]["SCPDateOfBirth"].ToString());
                        cmd.Parameters.AddWithValue("@CheckStatus", cCheckStatus);

                        cmd.Parameters.AddWithValue("@Eligible", (dt.Rows[0]["Eligible"].ToString() == "Yes" ? 1 : 0).ToString());
                        cmd.Parameters.AddWithValue("@EligibilityExpireDate", cEligibilityExpireDate);
                        cmd.Parameters.AddWithValue("@FPL", dt.Rows[0]["SCPHousePoverty"].ToString());
                        cmd.Parameters.AddWithValue("@FPL_Exception", (dt.Rows[0]["FPL_Exception"].ToString() == "Yes" ? 1 : 0).ToString());
                        cmd.Parameters.AddWithValue("@Suspended", (dt.Rows[0]["Suspended"].ToString() == "Yes" ? 1 : 0).ToString());
                        cmd.Parameters.AddWithValue("@Medicare", (dt.Rows[0]["Medicare"].ToString() == "Yes" ? 1 : 0).ToString());
                        cmd.Parameters.AddWithValue("@Medicaid", (dt.Rows[0]["Medicaid"].ToString() == "Yes" ? 1 : 0).ToString());
                        cmd.Parameters.AddWithValue("@DateCreated", dateNow);
                        cmd.Parameters.AddWithValue("@Active", 1);
                        cmd.Parameters.AddWithValue("@CallerID", "");
                        cmd.Parameters.AddWithValue("@DataMismatch_FirstName", (cStatus.DataMismatch_FirstName == "Yes" ? 1 : 0).ToString());
                        cmd.Parameters.AddWithValue("@DataMismatch_LastName", (cStatus.DataMismatch_LastName == "Yes" ? 1 : 0).ToString());
                        cmd.Parameters.AddWithValue("@DataMismatch_DOB", (cStatus.DataMismatch_DOB == "Yes" ? 1 : 0).ToString());
                        cmd.Parameters.AddWithValue("@DataMismatch_SSN", (cStatus.DataMismatch_SSN == "Yes" ? 1 : 0).ToString());


                        //int rows = cmd.ExecuteNonQuery();
                        int modified = (int)cmd.ExecuteScalar();
                        item_sysID = modified;
                        cmd.Dispose();
                    }
                    //return "";

                    conn.Close();

                }
                /*
                using (SqlConnection connLog = new SqlConnection(ConnString))
                {


                    cmd.Parameters.AddWithValue("@PE_ID", PE_ID);
                    cmd.Parameters.AddWithValue("@first_name", first_name);

                    cmd.Parameters.AddWithValue("@last_name", last_name);
                    cmd.Parameters.AddWithValue("@ssn", ssn);
                    cmd.Parameters.AddWithValue("@date_of_birth", dob);

                    cmd.Parameters.AddWithValue("@CheckStatus", cCheckStatus);

                    cmd.Parameters.AddWithValue("@DateCreated", dateNow);

                    cmd.Parameters.AddWithValue("@Active", 1);

                    //int rows = cmd.ExecuteNonQuery();
                    int modified = (int)cmd.ExecuteScalar();
                    item_sysID = modified;
                    cmd.Dispose();

                    connLog.Open();
                    //SqlCommand myCommandLog = new SqlCommand("Insert into ICP_Admin_Reports.dbo.tblWS_Eligibility_Check (PE_ID,first_name,last_name,ssn,date_of_birth,CheckStatus,Eligible,EligibilityExpireDate,FPL,FPL_Exception,Suspended,Medicare,Medicaid,DateCreated,Active,CallerID) values " +
                    //    "('" + dt.Rows[0]["SCPClientID"].ToString() + "','" + dt.Rows[0]["SCPClientFirst"].ToString() + "','" + dt.Rows[0]["SCPClientLast"].ToString() + "','" + dt.Rows[0]["SCPSSN"].ToString() + "','" + dt.Rows[0]["SCPDateOfBirth"].ToString() + "','" + cCheckStatus + "'," + (dt.Rows[0]["Eligible"].ToString() == "Yes" ? 1 : 0).ToString() + ",'" + cEligibilityExpireDate + "','" + dt.Rows[0]["SCPHousePoverty"].ToString() + "', " + (dt.Rows[0]["FPL_Exception"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Suspended"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicare"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicaid"].ToString() == "Yes" ? 1 : 0).ToString() + ",getdate(),1,'')", connLog);
                    SqlCommand myCommandLog = new SqlCommand("Insert into ICP_Admin_Reports.dbo.tblWS_Eligibility_Check (PE_ID,first_name,last_name,ssn,date_of_birth,CheckStatus,Eligible,EligibilityExpireDate,FPL,FPL_Exception,Suspended,Medicare,Medicaid,DateCreated,Active,CallerID,DataMismatch_FirstName,DataMismatch_LastName,DataMismatch_DOB,DataMismatch_SSN) values " +
                        "('" + dt.Rows[0]["SCPClientID"].ToString() + "','" + dt.Rows[0]["SCPClientFirst"].ToString().Replace("'", "") + "','" + dt.Rows[0]["SCPClientLast"].ToString().Replace("'", "") + "','" + dt.Rows[0]["SCPSSN"].ToString() + "','" + dt.Rows[0]["SCPDateOfBirth"].ToString() + "','" + cCheckStatus + "'," + (dt.Rows[0]["Eligible"].ToString() == "Yes" ? 1 : 0).ToString() + ",'" + cEligibilityExpireDate + "','" + dt.Rows[0]["SCPHousePoverty"].ToString() + "', " + (dt.Rows[0]["FPL_Exception"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Suspended"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicare"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicaid"].ToString() == "Yes" ? 1 : 0).ToString() + ",getdate(),1,''," + (cStatus.DataMismatch_FirstName == "Yes" ? 1 : 0).ToString() + "," + (cStatus.DataMismatch_LastName == "Yes" ? 1 : 0).ToString() + "," + (cStatus.DataMismatch_DOB == "Yes" ? 1 : 0).ToString() + "," + (cStatus.DataMismatch_SSN == "Yes" ? 1 : 0).ToString() + ")", connLog);
                    int resultLog = myCommandLog.ExecuteNonQuery();
                    myCommandLog.Dispose();
                    connLog.Close();
                }
                */
            }
            catch (Exception ex)
            {
                //LogException(ex, "ws_eligibility", "LogCheck_ClientFound - " + tmpQuery, "");
                LogException(ex, "ws_eligibility", "LogCheck_ClientFound - ", "");

            }
        }

        private void LogCheck_ClientFound_Test(DataTable dt, string cCheckStatus, string cEligibilityExpireDate, Classes.ClientStatus cStatus)
        {
            //string tmpQuery = "Insert into ICP_Admin_Reports.dbo.tblWS_Eligibility_Check (PE_ID,first_name,last_name,ssn,date_of_birth,CheckStatus,Eligible,EligibilityExpireDate,FPL,FPL_Exception,Suspended,Medicare,Medicaid,DateCreated,Active,CallerID) values " +
            //"('" + dt.Rows[0]["SCPClientID"].ToString() + "','" + dt.Rows[0]["SCPClientFirst"].ToString() + "','" + dt.Rows[0]["SCPClientLast"].ToString() + "','" + dt.Rows[0]["SCPSSN"].ToString() + "','" + dt.Rows[0]["SCPDateOfBirth"].ToString() + "','" + cCheckStatus + "'," + (dt.Rows[0]["Eligible"].ToString() == "Yes" ? 1 : 0).ToString() + ",'" + cEligibilityExpireDate + "','" + dt.Rows[0]["SCPHousePoverty"].ToString() + "', " + (dt.Rows[0]["FPL_Exception"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Suspended"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicare"].ToString() == "Yes" ? 1 : 0).ToString() + "," + (dt.Rows[0]["Medicaid"].ToString() == "Yes" ? 1 : 0).ToString() + ",getdate(),1,'')";
            string tmpQuery = "Insert into ICP_Admin_Reports.dbo.tblWS_Eligibility_Check (PE_ID,first_name,last_name,ssn,date_of_birth,CheckStatus,Eligible,EligibilityExpireDate,FPL,FPL_Exception,Suspended,Medicare,Medicaid,DateCreated,Active,CallerID,DataMismatch_FirstName,DataMismatch_LastName,DataMismatch_DOB,DataMismatch_SSN) values " +
             "('0000000','alfred','brhpc','123456789','1/1/1990','" + cCheckStatus + "',1,'" + cEligibilityExpireDate + "','12/31/2023',1,0,0,0,getdate(),1,'',0,0,0,0)";

            string dateNow = DateTime.Now.ToString();

            System.Text.StringBuilder values = new System.Text.StringBuilder();

            values.Append("@PE_ID,");
            values.Append("@first_name,");
            values.Append("@last_name,");
            values.Append("@ssn,");
            values.Append("@date_of_birth,");
            values.Append("@CheckStatus,");

            values.Append("@Eligible,");
            values.Append("@EligibilityExpireDate,");
            values.Append("@FPL,");
            values.Append("@FPL_Exception,");
            values.Append("@Suspended,");
            values.Append("@Medicare,");
            values.Append("@Medicaid,");
            values.Append("@DateCreated,");
            values.Append("@Active,");
            values.Append("@CallerID,");
            values.Append("@DataMismatch_FirstName,");
            values.Append("@DataMismatch_LastName,");
            values.Append("@DataMismatch_DOB,");
            values.Append("@DataMismatch_SSN");
            //Eligible,EligibilityExpireDate,FPL,FPL_Exception,Suspended,Medicare,Medicaid,DateCreated,Active,CallerID,DataMismatch_FirstName,DataMismatch_LastName,DataMismatch_DOB,DataMismatch_SSN
            string queryInsertUpdate = "INSERT INTO ICP_Admin_Reports.dbo.tblWS_Eligibility_Check (" + values.ToString().Replace("@", "") + ") VALUES(" + values.ToString() + "); SELECT CAST(SCOPE_IDENTITY() AS int)";
            int item_sysID = -1;

            try
            {
                //Log the Eligibility Check
                String ConnString = ConfigurationManager.ConnectionStrings["ConnectionIBM"].ConnectionString;

                using (SqlConnection conn =
                    new SqlConnection(ConnString))
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        //new SqlCommand("INSERT INTO EmployeeDetails VALUES(" + "@Id, @Name, @Address)", conn))
                        new SqlCommand(queryInsertUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@PE_ID", "0000000");
                        cmd.Parameters.AddWithValue("@first_name", "alfred");
                        cmd.Parameters.AddWithValue("@last_name", "brhpc");
                        cmd.Parameters.AddWithValue("@ssn", "123456789");
                        cmd.Parameters.AddWithValue("@date_of_birth", "1/1/1990");
                        cmd.Parameters.AddWithValue("@CheckStatus", cCheckStatus);

                        cmd.Parameters.AddWithValue("@Eligible", "1");
                        cmd.Parameters.AddWithValue("@EligibilityExpireDate", cEligibilityExpireDate);
                        cmd.Parameters.AddWithValue("@FPL", "100");
                        cmd.Parameters.AddWithValue("@FPL_Exception", "1");
                        cmd.Parameters.AddWithValue("@Suspended", "0");
                        cmd.Parameters.AddWithValue("@Medicare", "0");
                        cmd.Parameters.AddWithValue("@Medicaid", "0");
                        cmd.Parameters.AddWithValue("@DateCreated", dateNow);
                        cmd.Parameters.AddWithValue("@Active", 1);
                        cmd.Parameters.AddWithValue("@CallerID", "");
                        cmd.Parameters.AddWithValue("@DataMismatch_FirstName", "0");
                        cmd.Parameters.AddWithValue("@DataMismatch_LastName", "0");
                        cmd.Parameters.AddWithValue("@DataMismatch_DOB", "0");
                        cmd.Parameters.AddWithValue("@DataMismatch_SSN", "0");


                        //int rows = cmd.ExecuteNonQuery();
                        int modified = (int)cmd.ExecuteScalar();
                        item_sysID = modified;
                        cmd.Dispose();
                    }
                    //return "";

                    conn.Close();

                }

            }
            catch (Exception ex)
            {
                //LogException(ex, "ws_eligibility", "LogCheck_ClientFound - " + tmpQuery, "");
                LogException(ex, "ws_eligibility", "LogCheck_ClientFound - ", "");

            }
        }

        private bool ValidSSN(string stringToCheck)
        {
            string[] stringArray = { "123456789", "987654321", "000000000", "111111111", "222222222", "333333333", "444444444", "555555555", "666666666", "777777777", "888888888", "999999999", "000000000" };
            foreach (string x in stringArray)
            {
                if (stringToCheck.Contains(x))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
