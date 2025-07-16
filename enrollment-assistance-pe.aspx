<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="enrollment-assistance-pe.aspx.cs" Inherits="Insurance_Enrollment_2024.enrollment_assistance_pe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="padding:10px 20px; text-align:center; background-color:#eb576f; font-size:130%">
<a runat="server" id="aProgramRequirements1" style="color:#fff !important">** Important Changes ** Before completing the form, please <u>READ</u> before enrolling.</a>
<a runat="server" visible="false" id="a1" style="color:#fff !important">** Important Changes starting 2024 ** Before completing the form, please <u>READ</u> before enrolling.</a>
</div>	
	
    <div class="container-fluid py-5" style="min-height:40em">
        <div class="container">
            <div class="row gx-5">
               
			   <div class="col-lg-8">
                    <div class="mb-4">
                        <h5 runat="server" id="topMessage1" class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">I need an Insurance Policy</h5>
                        <h1 class="display-6">I have NOT enrolled in a Marketplace/ACA Plan for 2025 and have (or had) a 2024 policy.</h1>
                    </div>
                    <div style="background-color: #faf5be; color:#000; font-size:120%; border-radius: 10px; padding:10px 20px; margin-bottom:10px">
                        
                        <b>Pre-Open Enrollment Easy Renewal:</b> October 1, 2024 - October 31, 2024.<br />Help maintain your existing insurance plan or to enroll in a new one for 2025.

                    </div>
                    <p>
                        Do not complete this form if you have already completed an enrollment in a Marketplace / ACA Health Insurance Plan for 2025 through either:
                        <ul style="float:left; margin-bottom: 0px; margin-right:70px">
                            <li>The Marketplace / ACA.</li>
                            <li>An Agent/Broker.</li>
                        </ul>	
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
                   <div style="margin-bottom:10px; color:maroon">
                       <span style="font-size:110%">*</span>If you live in Miami-Dade County, go to <a href="ae-forms.aspx?form=miamidade" style="text-decoration:underline">Miami-Dade Form</a>
                   </div>

                    <div class="pt-2">

                        <a runat="server" id="aPreRegistration" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color: #ffff52 !important; border-color: #ffff52 !important; font-size:110%; margin-left:0px !important">
                          Pre-Open Enrollment Easy Renewal for 2025
                        </a>
		
                        <span class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
                    </div>

                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
