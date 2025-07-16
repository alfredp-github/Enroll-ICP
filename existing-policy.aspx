<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="existing-policy.aspx.cs" Inherits="Insurance_Enrollment_2024.existing_policy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="padding:10px 20px; text-align:center; background-color:#eb576f; font-size:130%">
<a runat="server" id="aProgramRequirements1" style="color:#fff !important">** Important Changes ** Before completing the form, please <u>READ</u> before enrolling.</a>
<a runat="server" visible="false" id="a1" style="color:#fff !important">** Important Changes starting 2024 ** Before completing the form, please <u>READ</u> before enrolling.</a>
</div>		
	
    <div class="container-fluid py-5" style="min-height:40em">
        <div class="container">
            <div classX="row gx-5">
               
			   <div class="col-lg-10">
                    <div class="mb-4">
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">I already have an Insurance Policy</h5>
                        <h1 class="display-6">I have Already enrolled in an Insurance Plan for 2024</h1>
                    </div>
                    <div>
						<div style="margin-bottom:10px; ">Please only continue here if you have already successfully enrolled in (or have) one of the following:</div>
                        <ul style="float:left; margin-bottom: 0px; margin-right:70px">
                            <li>A <b>Marketplace / ACA</b> Plan for 2024. </li>
                            <li>Insurance through your <b>Employer</b></li>
                            <li>Continued health coverage through a <b>COBRA</b> plan.</li>
                        </ul>	
						<a style="display:none; float:left; font-size:90%" href="enrollment-assistance.aspx">*<i>If you do not have any of these,<br />then <u>Get Assitance with Enrollment</u></i>.</a>	
                        <div style="clear:both"></div>					
					</div>

                    <div class="pt-2" style="display:none">
                        <a href="#" class="btn btn-lightXX nex-btn-light rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">Take me to the Enrollment Form</a>
                    </div>
					
				<div class="row g-0 g-9">
                    <a runat="server" id="aExistingPolicy_ACA1" class="nex-bigicon-link" target="_self">
					<div class="col-lg-3 col-md-6">
						<div class="service-item bg-lightX rounded d-flex flex-column align-items-center justify-content-center text-center">
							<div class="service-icon mb-4">
								<i class="fa fa-2x icon-insurance text-white"></i>
							</div>
							<h4 class="mb-3" style="colorX:#2681bd">ACA Marketplace</h4>
							<p class="m-0" style="displayX:none">You have enrolled in an insurance policy through the Marketplace / ACA (Health Insurance Marketplace)</p>
                            <p class="m-0" style="display:none">You will select the insurance company and the plan name for the plan you have selected</p>
							<a runat="server" id="aExistingPolicy_ACA2" class="btn btn-lg btn-primary rounded-pill">
								<i class="bi bi-arrow-right"></i>
							</a>
						</div>
					</div>
                    </a>
                    <a runat="server" id="aExistingPolicy_Employer1" class="nex-bigicon-link" target="_self">
					<div class="col-lg-3 col-md-6">
						<div class="service-item bg-lightX rounded d-flex flex-column align-items-center justify-content-center text-center">
							<div class="service-icon mb-4">
								<i class="fa fa-2x icon-insurance-employer text-white"></i>
							</div>
							<h4 class="mb-3" style="colorX:#2681bd">Employer-Sponsored</h4>
                            <p class="m-0" style="displayX:none">You have a health insurance policy selected by your Employer. (Often referred to as a group plan)</p>
							<p class="m-0" style="display:none">Ensure that you have your employer complete the attached letter to accept premium payments (third party letter on website)</p>
							<a runat="server" id="aExistingPolicy_Employer2" class="btn btn-lg btn-primary rounded-pill">
								<i class="bi bi-arrow-right"></i>
							</a>
						</div>
					</div>	
                    </a>		
                    <a runat="server" id="aExistingPolicy_Cobra1" class="nex-bigicon-link" target="_self">		
					<div class="col-lg-3 col-md-6">
						<div class="service-item bg-lightX rounded d-flex flex-column align-items-center justify-content-center text-center">
							<div class="service-icon mb-4">
								<i class="fa fa-2x icon-bridge text-white"></i>
							</div>
							<h4 class="mb-3" style="colorX:#2681bd">COBRA</h4>
							<p class="m-0" style="displayX:none">You have continued health coverage after you left a job or due to another event that qualified you.</p>
                            <p class="m-0" style="display:none">Ensure that you attach the entire COBRA election document</p>
							<a runat="server" id="aExistingPolicy_Cobra2" class="btn btn-lg btn-primary rounded-pill">
								<i class="bi bi-arrow-right"></i>
							</a>
						</div>
					</div>	
                    </a>
                    <a runat="server" id="aExistingPolicy_Agent1" class="nex-bigicon-link" target="_self">
					<div class="col-lg-3 col-md-6">
						<div class="service-item bg-lightX rounded d-flex flex-column align-items-center justify-content-center text-center">
							<div class="service-icon mb-4">
								<i class="fa fa-2x icon-representative text-white"></i>
							</div>
							<h4 class="mb-3" style="colorX:#2681bd">Agent / Broker<br />Navigator / CAC</h4>
							<p class="m-0" style="displayX:none">You want to enroll a client that has enrolled through the Marketplace / ACA (Health Insurance Marketplace)</p>
                            <p class="m-0" style="display:none">You will select the insurance company and the plan name for the plan you have selected</p>
							<a runat="server" id="aExistingPolicy_Agent2" class="btn btn-lg btn-primary rounded-pill">
								<i class="bi bi-arrow-right"></i>
							</a>
						</div>
					</div>						
                   </a>
					
					
				</div>
					
					
					

                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
