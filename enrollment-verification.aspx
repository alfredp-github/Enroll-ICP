<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="enrollment-verification.aspx.cs" Inherits="Insurance_Enrollment_2024.enrollment_verification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="padding:10px 20px; text-align:center; background-color:#EA5276; font-size:130%">
<a runat="server" id="aProgramRequirements1" style="color:#fff !important">** Important Changes ** Before completing the form, please <u>READ</u> before enrolling.</a>
<a runat="server" visible="false" id="a2" style="color:#fff !important">** Important Changes starting 2024 ** Before completing the form, please <u>READ</u> before enrolling.</a>
</div>	
	
    <div class="container-fluid py-5" style="min-height:40em">
        <div class="container">
            <div class="row gx-5">
               
			   <div class="col-lg-8">
                    <div class="mb-4">
                        <h5 runat="server" visible="false" class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">I need to verify my coverage</h5>
                        <h1 runat="server" visible="false" class="display-6">I have recently renewed my program eligibility</h1>
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">I have recently renewed my program eligibility</h5>
                        <h1 class="display-6">Premium Assistance Re-enrollment</h1>
                    </div>

                    <div style="background-color: #fcd7e3; color:#000; font-size:120%; border-radius: 10px; padding:10px 20px; margin-bottom:20px">
                           *If are already enrolled in Premium Assistance and you renewed your program eligibility after your eligibility expired or your account was suspended, you are required to complete this form to request Re-enrollment.
                    </div>

                   <div runat="server" visible="false">Please answer based on changes to my income, household size, primary residence, County of residence or Tax Filing Status.</div>

                        <b runat="server" visible="false" class="nex-text-secondary">You will be asked to verify any changes (or none) to the following:</b>
                        <b class="nex-text-secondary">You will be asked to verify any changes to the following:</b>
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

                   <div runat="server" visible="false" style="font-size:20px">
                       Does it make sense to ask "If your policy has been cancelled do you wish us to attempt to reinstate your policy"<br />
                       or are we doing the same emails to CHD?
                   </div>
                    

                    <div class="pt-2">
                        <a runat="server" visible="false" id="a1" href="ae-forms.aspx?form=reenroll" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color:#f2c879 !important; border-color: #f2c879 !important; font-size:110%; margin-left:0px !important">
                            Verify My Coverage
                        </a>
                        <a runat="server" id="aReenrollment" href="ae-forms.aspx?form=reenroll" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color:#f2c879 !important; border-color: #f2c879 !important; font-size:110%; margin-left:0px !important">
                            Premium Assistance Re-Enrollment
                        </a>			
                        <span class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
                    </div>

                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
