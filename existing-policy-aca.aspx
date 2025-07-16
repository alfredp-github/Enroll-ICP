<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="existing-policy-aca.aspx.cs" Inherits="Insurance_Enrollment_2024.existing_policy_aca" %>
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
                        <h1 class="display-6">I have Already Enrolled in an ACA Health Insurance Marketplace Plan for 2024</h1>
                    </div>

                    <div style="display:none; background-color: #fff1cc; color:#000; font-size:100%; border-radius: 10px; padding:10px 20px; margin-bottom:25px">
                        
                        <span class="iconscontainer">
                            <b><span style="font-size:120%">*</span>If you need to enroll your <u>2023</u> ACA policy:</b><br />Call 1-844-441-4422 for assistance or use the <a runat="server" id="aExistingPolicy_2023_ACA1" href="#" style="color:#255866; text-decoration:underline">2023 enrollment form</a> <span style="font-style:italic; font-size:90%">(Note: 2023 enrollment form will be available through 11/30/2023)</span>

                        </span>
                    </div>

                    <div>
                        
                        <ul class="ou-list-1">
                            <li>
                                Please confirm that your insurance plan is a <a  runat="server" id="aEligiblePlans1" class="nex-link-bg-bold" target="_blank" >2024 Program Approved Plan</a> in the county you live in for <b>2024</b>. 
                                <br />If not, you may need to select a different plan.
                                <ul class="nex-list-sub">
                                    <li>
                                        <a runat="server" id="aEligiblePlans2" class="nex-link-bg-bold" target="_blank" >View the 2024 Program Approved Plan list by County</a>	
                                    </li>
                                </ul>
                            </li>

                        </ul>
		                        
					</div>

                    <div class="pt-2" style="margin-top:40px">
                        <a runat="server" id="aExistingPolicy_ACA1" class="btn btn-lightXX nex-btn-light rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">Take me to the 2024 Enrollment Form</a>
						<span class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
                    </div>			
					

                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>