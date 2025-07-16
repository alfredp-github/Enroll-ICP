using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insurance_Enrollment_2024
{
    public partial class forms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Insurance_Enrollment_2024.App_Code.Utilities util = new Insurance_Enrollment_2024.App_Code.Utilities();
                HttpRequestWrapper wrapper = new HttpRequestWrapper(Request);

                iframe2.Src = "https://amex.surefyre.co/app/public/t/brhpc-form-upload/";

                util.InsertRecord_Analytics(util.GetIpAddress(wrapper), "Load-MiamiDade", HttpContext.Current.Session.SessionID, 1);
            }
        }
    }
}