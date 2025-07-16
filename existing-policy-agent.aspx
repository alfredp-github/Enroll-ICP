<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="existing-policy-agent.aspx.cs" Inherits="Insurance_Enrollment_2024.existing_policy_agent" %>
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
                        <h1 runat="server" visible="false" class="display-6">Participant has a health insurance policy through one of the following:</h1>
                        <h1 class="display-6">Participant has a health insurance policy through the following:</h1>
                    </div>
                    <div runat="server" id="divApprovedPlans">
                        
                        <div class="nex-title-2">Marketplace / ACA</div>
               
                        <ul class="ou-list-1">
                            <li>
                                Please confirm that your insurance plan is a <a runat="server" id="aApprovedPlans1" class="nex-link-bg-bold" target="_blank" >Program Approved Plan</a> in the county the participant lives in.<span runat="server" visible="false"> for <b>2024</b>. </span> 
                                <br />If not, you may need to select a different plan.
                                <ul class="nex-list-sub">
                                    <li>
                                        <a runat="server" id="aApprovedPlans2" class="nex-link-bg-bold" target="_blank" >View the Program Approved Plan list by County</a>	
                                    </li>
                                </ul>
                            </li>

                        </ul>

                        <div runat="server" visible="false">

                            <div class="nex-title-2">Employer-Sponsored</div>

                            <ol class="ou-list-1">
                                <li>
                                    Please be sure to <a target="_blank" href="docs/employer-letter-1.docx">download</a> the third-party letter template and have it completed by your employer prior to enrolling. 
                                    <br />You will need to attach this document on the enrollment form. <a class="nex-link-bg-bold" target="_blank" href="docs/employer-letter-1.docx">Download third-party letter template</a>.
                                </li>
                                <li>
                                    Have your benefit packet available for upload to check on premium affordability.
                                </li>
                            </ol>

                            <div class="nex-title-2">COBRA</div>
 
                            <ol class="ou-list-1">
                                <li>
                                    Please be sure to have your entire COBRA package ready. 
                                    <br />You will need to attach these documents on the enrollment form.
                                </li>
                                <li>
                                    Make sure the package includes a signed and dated election form.
                                </li>
                            </ol>

                        </div>
		                        
					</div>

                    <div class="pt-2" style="margin-top:40px">
                        <a runat="server" id="aExistingPolicy_Agent1"  class="btn btn-lightXX nex-btn-light rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">Take me to the Enrollment Form</a>
						<span class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
                    </div>			
					

                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
