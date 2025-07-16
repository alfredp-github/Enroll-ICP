<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test-enrollment-assistance.aspx.cs" Inherits="Insurance_Enrollment_2024.test_enrollment_assistance" %>
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
               
			   <div class="col-lg-8" style="width:100% !important">
                    <div class="mb-4" style="float:left; width:630px; margin-right: 50px">
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">I need assistance with Enrollment</h5>
                        <h1 class="display-6">I have NOT enrolled in a Marketplace/ACA Plan for 2024</h1>
                    </div>
                    <div class="mb-4" style="float:left; width:500px; ">
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">I already have an Insurance Policy</h5>
                        <h1 class="display-6">I have Already enrolled in<br />an Insurance Plan for 2024</h1>
                    </div>
                   <div style="clear:both"></div>

                    <div style="display:none; background-color: #fcd7e3; color:#000; font-size:120%; border-radius: 10px; padding:10px 20px; margin-bottom:10px">
                        
                        <span class="iconscontainer">
                            <b>Special Enrollment Period (SEP) 2023:</b> You can enroll if you have certain life events or income change.
                            <span class="nex-text-primary" style="font-weight:bold">View list of events.</span>
                            <span class="spanToolTip spanToolTipWidthWide">
                                <ol style="margin-bottom:8px">
                                    <li>Low-Income Special Enrollment Period for people with an income between 100-150% of the Federal Poverty Level (FPL).</li>
                                    <li>Involuntary Loss of Employer (Cobra) or Public (Medicare/Medicaid) Insurance Coverage.</li>
                                    <li>Gained Eligible Immigration Status.</li>
                                    <li>Released from incarceration.</li>
                                    <li>Change in household size because of marriage, divorce, adoption, dependent removed, legal separation, etc.</li>
                                    <li>Change in Residence/Moved to a New Zip Code. (Must have had active insurance for at least 1 day in the 60 days prior to the move)</li>
                                    <li>Recently denied Medicaid or CHIP Coverage</li>
                                </ol>
                            </span>
                        </span>
                    </div>
                    <p>
                        Do not complete this form if you have already completed an enrollment in a Marketplace / ACA Health Insurance Plan for 2024 through either:
                        <ul style="float:left; margin-bottom: 0px; margin-right:70px">
                            <li>The Marketplace / ACA.</li>
                            <li>An Agent/Broker.</li>
                        </ul>	
                        <a style="display:none; float:left; font-size:90%" href="existing-policy.aspx">*<i>If you already have an Insurance Policy,<br />then <u>select insurance type</u></i>.</a>	
                        <div style="clear:both"></div>	
                                            
                        <p class="nex-p-para">
                        Only complete this form if you need assistance with Marketplace / ACA enrollment from BRHPC/American Exchange. American Exchange is a CMS Certified Federally Facilitated Marketplace Agent/Broker in the State of Florida and will act as your Agent of Record upon completing this form.
                        </p>	
                    </p>
                    <p>

                        <b class="nex-text-secondary">Before continuing, please ensure you have the required information to enroll:</b>
                        <ul>
                            <li>Tax Household Information (for all individuals in your Tax Household):
                                <ul>
                                    <li>Legal Name (include hyphens, spaces, etc)</li>
                                    <li>Date of Birth</li>
                                    <li>Social Security Number</li>
                                    <li>Income</li>
                                    
                                </ul>
                            </li>
                            <li>Household size</li>
                            <li>Citizenship or Proof of legal residency (Immigration status indicating lawful presence)</li>
                            <li>Address and preferred contact information</li>

                        </ul>	


                    </p>

                    <div class="pt-2">
                        <a runat="server" id="aSpecialEnrollmentPeriod" class="btn btn-lightXX nex-btn-light rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">
                            Open Enrollment 2024
                        </a>			
                        <span class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
                    </div>

                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
