<%@ Page Title="" Language="C#" MasterPageFile="~/Site-Forms.Master" AutoEventWireup="true" CodeBehind="ae-forms.aspx.cs" Inherits="Insurance_Enrollment_2024.ae_forms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script lang="JavaScript">

        /*
        window.onload = Set_FormValues;

        function Set_FormValues() {
            const queryParams = new URLSearchParams(window.location.search);
            const containsParam = queryParams.has('form');
            if (containsParam)
            {
                var menuFormName = document.getElementById('menu_FormName');
                var formLink = document.getElementById('iframe2');
                switch (queryParams.get('form')){
                    case "prereg":
                    menuFormName.innerHTML = "ACA Marketplace Health Insurance - Pre-Registration";
                    //formLink.src = "https://amex.surefyre.co/app/public/t/florida-adap-aca-assessment/";
                    formLink.src = "https://amex.surefyre.co/app/public/195/";
                    break;

                    case "na_aca":
                    menuFormName.innerHTML = "ACA Marketplace Health Insurance Enrollment Application - 2024";
                    //formLink.src = "https://amex.surefyre.co/app/public/t/florida-adap-aca-assessment/";
                    formLink.src = "https://uat-amex.surefyre.co/app/public/t/florida-adap-aca-assessment/";
                    break;

                    case "na_aca_se":
                    menuFormName.innerHTML = "ACA Marketplace Health Insurance Enrollment Application - 2023";                    
                    //formLink.src = "https://amex.surefyre.co/app/public/169/"; //Special Enrollment Period - No plan finder//
                    formLink.src = "https://amex.surefyre.co/app/public/169/";
                    break;

                    case "tax":
                    menuFormName.innerHTML = "ACA Marketplace Health Insurance - Required Tax Forms";
                    formLink.src = "https://amex.surefyre.co/app/public/t/brhpc-form-upload/";
                    break;

                    case "ep_aca":
                    menuFormName.innerHTML = "ACA Marketplace Health Insurance Enrollment";
                    formLink.src = "https://amex.surefyre.co/app/public/t/florida-adap-aca-enrollment/";                    
                    break;
                    case "ep_emp":
                    menuFormName.innerHTML = "Employer Coverage Enrollment";
                    formLink.src = "https://amex.surefyre.co/app/public/t/fl-adap-employer-coverage-enrollment/";
                    break;
                    case "ep_cob":
                    menuFormName.innerHTML = "2023 COBRA Enrollment Form";
                    formLink.src = "https://amex.surefyre.co/app/public/t/fl-adap-cobra-enrollment/";
                    break;
                    case "ep_agen":
                    menuFormName.innerHTML = "Agents/Brokers - ACA Marketplace Health Insurance Enrollment";
                    formLink.src = "https://amex.surefyre.co/app/public/t/fl-adap-agentbrokerassister-aca-enrollment/";
                    break;


                }

            }
        }
        */

    </script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
       <script lang="JavaScript">

           window.onload = function () {
               autoResize();
           };

           window.addEventListener('resize', () => { autoResize(); });

           function autoResize() {
               
               //var div_iframeElement = parent.document.getElementById('divIframe2');
               var div_iframeElement = document.getElementById('<%:divIframe2.ClientID%>');

                //var div_height = document.documentElement.clientHeight - 180;
                var div_height = document.documentElement.clientHeight - 251;
                div_iframeElement.style.height = div_height + "px";

                //var iframeElement = parent.document.getElementById('iframe2');
                var iframeElement = document.getElementById('<%:iframe2.ClientID%>');

               //var height = document.documentElement.clientHeight - 200;
               var height = document.documentElement.clientHeight - 230;
               iframeElement.style.height = height + "px";
           }
       </script>

    <div runat="server" id="divIframe2" class="container-fluid py-5X" style="min-heightX:40em; width: 80em; max-width:80%; margin-bottom:50px; padding-top:0px; border:lightgray 1px solid; border-bottom:0px; border-top:0px; border-right:0px">
        
        <iframe style="display:none" frameborder="0"  width="100%" height="500px" src="https://amex.surefyre.co/app/public/t/florida-adap-aca-assessment/" ></iframe>   
        <iframe runat="server" name="iframe2" id="iframe2"  frameborder="0"  width="100%" height="500px" src="" ></iframe>   
        

    </div>

</asp:Content>
