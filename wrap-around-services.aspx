<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wrap-around-services.aspx.cs" Inherits="Insurance_Enrollment_2024.wrap_around_services" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="padding:10px 20px; text-align:center; background-color:#EA5276; font-size:130%">
<a runat="server" id="aProgramRequirements1" style="color:#fff !important">** Important Changes ** Before completing the form, please <u>READ</u> before enrolling.</a>
<a runat="server" visible="false" id="a1" style="color:#fff !important">** Important Changes starting 2024 ** Before completing the form, please <u>READ</u> before enrolling.</a>
</div>	
	
    <div class="container-fluid py-5" style="min-height:40em">
        <div class="container">
            <div class="row gx-5">
               
			   <div class="col-lg-8">
                    <div class="mb-4" style="margin-bottom:20px">
                        <h5 runat="server" id="topMessage1" class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5"></h5>
                        <h2 runat="server" id="topMessage2" class="display-6X"></h2>
                    </div>

                   <div>
                        By completing this application, you are requesting assistance for State Based Premium Assistance and also for Copay Wrap Around Assistance provided by Miami Dade County. To get Wrap Around Services you may have to comply with local requirements for eligibility.                     </div>

                    <div class="pt-2" style="margin-top:15px">
                        <div style="margin-bottom:10px">
                            <b class="nex-text-secondary" style="font-size:110%">Are you requesting Part A Wrap Around Services?</b>                    
                        </div>
                        <a runat="server" id="aYes" href="ae-forms.aspx?form=miamidade" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color:#f2c879 !important; border-color: #f2c879 !important; font-size:110%; margin-left:0px !important">
                            Yes
                        </a>			
                        <a runat="server" id="aNo" href="ao-counties.aspx?cty=" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color:#f2c879 !important; border-color: #f2c879 !important; font-size:110%; margin-left:0px !important">
                            No
                        </a>			


                        <span class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
                    </div>




                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
