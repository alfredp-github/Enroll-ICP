<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="program-requirements.aspx.cs" Inherits="Insurance_Enrollment_2024.program_requirements" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid py-5" style="min-height:40em">
        <div class="container">
            <div classX="row gx-5">	
	
	
				<div class="mb-4" style="float:left; margin-right:70px">
					<h5 runat="server" visible="false" class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">NEW Florida Administrative Code Requirements</h5>
                    <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">Florida Administrative Code Requirements</h5>

					<h1 runat="server" visible="false" class="display-6">Premium Plus Insurance Program<br />New Requirements<br />Effective 11/1/23 for Coverage in 2024</h1>
					<h1 runat="server" visible="false" class="display-6">Premium Plus Insurance Program<br />New Requirements<br />Effective 11/1/2023</h1>
					<h1 runat="server" visible="false" class="display-6">Insurance Premium Assistance Program<br />New Requirements<br />Effective 11/1/2023</h1>
					<h1 class="display-6">Premium Assistance Program Requirements</h1>
                   
				</div>

				
            </div>
            <div style="clear:both"></div>

                To receive Premium Plus Insurance Program benefits including payments of monthly health insurance premiums and medications copayments participants must comply with the following requirements:

                <ol>
                <li>
                    <b>Participants MUST Enroll In Premium Assistance Annually</b><br />
                    Enroll online at https://enroll.brhpc.org, over the telephone by calling 1-844-441-4422 or <span> <a style="text-decoration:underline" target="_blank" href="Content/docs/CountyHealthDepartmentContactList.pdf">calling your County Health Department</a></span>. This is REQUIRED even if you enrolled with an agent/broker, navigator, case manager, etc.
                    <ul>
                    <li>
                        Enrollment and reenrollment in the premium assistance program is required prior to each calendar year regardless of the type of insurance enrolled in including marketplace/Affordable Care Act (ACA), employer sponsored insurance, or COBRA.
                    </li>
                    <li>
                        Program eligibility MUST completed every 12 months. If you need help with this, please call the Eligibility Assistance line at 1-844-381-2327 or <span> <a style="text-decoration:underline" target="_blank" href="Content/docs/CountyHealthDepartmentContactList.pdf">calling your County Health Department</a></span>.
                    </li>
                    </ul>
                </li>
                <li>
                    <b>Medications MUST be Filled at a Participating Pharmacy</b><br />
                    Clients with insurance must pick up medications from participating pharmacies
                </li>
                </ol>


                <div><b>Addition Requirements For Marketplace / ACA Insurance Plans</b></div>

                <ol>
                <li>
                <b>Determine Eligibility for Subsidies (Reduced Costs)</b><br />
                When applying for coverage in the Health Insurance Marketplace, participants must find out if they qualify for a "premium tax credit" and “cost sharing reductions” that lower the monthly premium — the amount paid each month for insurance and the out-of-pocket costs for doctor visits, labs, and medications. If the participant qualifies, they must select the advanced premium tax credit that is paid directly to the insurance company.
                </li>
                <li>
                <b>Enroll in an Approved Plan</b><br />
                Only approved insurance plans are eligible for assistance. The list of approved ACA plans is updated each year in November for the following calendar year. 
                </li>
                <li>
                <b>Submit Supporting Documentation to the State or Local Program Office</b><br />
                All supporting documentation submitted to the Marketplace as part of the application and/or enrollment process must also be submitted to state or local eligibility office. If BRHPC or American Exchange complete your enrollment, the documentation submission is automatic.
                <br /><br />
                ALL changes to income, address, or living situation, i.e., marriage, divorce, adoption or tax filing status MUST be reported to Healthcare.gov or  https://enroll.brhpc.org in addition to the program.

                </li>
                </ol>

                <div><b>Additional Requirements For COBRA and Employer Sponsored Insurance</b></div>
                COBRA or Employer Sponsored insurance policy coverage information and all policy documentation MUST be submitted @ https://enroll.brhpc.org. Required information includes:
                <ul>
                <li>
                Who to make checks payable to / Where to send payments.
                </li>
                <li>
                Policy start date / Policy end date.
                </li>
                <li>
                Monthly premium payment / Any pro-rated amount.
                </li>
                <li>
                Identifiers that need to be printed on the check (account #, ID#, SSN, etc.).
                </li>
                </ul>
                All changes and policy renewal information MUST be submitted @ https://enroll.brhpc.org.
                <br /><br />
                <span runat="server" visible="false">For questions or clarification, contact Matthew Anthony at Manthony@BRHPC.org.</span>
	            For questions or clarification, contact Cristy Kozla at ckozla@BRHPC.org. 
	
                <div style="margin-top:30px">
					<h5 style="margin-bottom: 20px;" class="d-inline-blockX text-primary nex-text-secondary text-uppercase border-bottom border-5">I have read the new requirements and need to enroll on this site</h5>
                        
                    <div runat="server" visible="false" style="display:flex; ">
                        <a runat="server" id="aPreRegistration" visible="false" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; background-color: #ff4d0d; border-color: #ff4d0d; color:#fff;  width:39.1em; flex-shrink: 1; margin-bottom:20px; margin-left:0px !important">I want to PRE-REGISTER for a 2024 Marketplace / ACA Plan</a>
                        <a runat="server" id="aEnrollmentAssistance" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; background-color: #ff4d0d; border-color: #ff4d0d; color:#fff;  width:41.6em; flex-shrink: 1; margin-bottom:20px; margin-left:0px !important">OPEN ENROLLMENT: I need an Insurance Policy for 2024</a>

                    </div>

                    <a runat="server" visible="false" id="aEnrollmentAssistanceCY" class="btn btn-lightXX nex-btn-light rounded-pill py-md-3 px-md-5X mx-2" style="font-size:110%; margin-left:0px !important">I need an Insurance Policy for 2024</a>
						
                    <a runat="server" visible="false" id="aExistingPolicy" class="btn btn-outline-lightXX nex-btn-light rounded-pill py-md-3 px-md-5X mx-2" style="font-size:110%; margin-left:0px !important">I already have an Insurance Policy</a>
						
                    <a runat="server" id="a1" class="btn btn-outline-lightXX nex-btn-light rounded-pill py-md-3 px-md-5X mx-2" style="font-size:110%; margin-left:0px !important" href="premium-insurance-enrollment.aspx">I need or already have an Insurance Policy</a>


                    <span style="margin-left:0px !important" class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
				</div>
	
			
			

				
        </div>
		

    </div>

</asp:Content>
