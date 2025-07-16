using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Insurance_Enrollment_2024.Classes
{
    public class ClientStatus
    {
        public string CheckStatus { get; set; }
        public string Eligible { get; set; }
        public string EligibilityExpireDate { get; set; }
        public string FPL { get; set; }
        public string FPL_Exception { get; set; }
        public string Suspended { get; set; }
        public string Medicare { get; set; }
        public string Medicaid { get; set; }
        public string DataMismatch_SSN { get; set; }
        public string DataMismatch_FirstName { get; set; }
        public string DataMismatch_LastName { get; set; }
        public string DataMismatch_DOB { get; set; }
        public string AE_AOR { get; set; }
        public string Has_BOPLAT24J0108 { get; set; }
        public string Has_BOPLAT24J0105 { get; set; }
        public string Has_BOPLAT24J0121S { get; set; }

        public string Has_BOSILV24J0103 { get; set; }
        public string Has_BOSILV24J0119S { get; set; }

        //string Eligible;
        //DateTime EligibilityExpireDate;
        //int FPL;

    }
}