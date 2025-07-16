<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test-default.aspx.cs" Inherits="Insurance_Enrollment_2024.test_default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblIP_Address" runat="server" Text="" ClientIDMode="Static" style="display:none"></asp:Label>

    <div style="display:none; padding:5px 20px; text-align:center; background-color:#eb576f; color:#fff">
<a>** Important Changes for 2024 ** Before completing the form, please <u>read</u> before enrolling.</a>
</div>

    <!-- Hero Start -->
    <div class="container-fluid bg-primary py-5 mb-5 nex-mb-5 hero-header">
        <div class="container py-5">
            <div class="row justify-content-start">
                <div class="col-lg-9 text-center text-lg-start">
                    <h5 class="d-inline-block text-primaryXX nex-text-primary text-uppercase border-bottom border-2" style="display:none !important; border-color: rgba(256, 256, 256, .3) !important; font-size:1.8em">Welcome To The Premium Assistance Program</h5>
					<h5 class="d-inline-block text-primaryXX nex-text-primary text-uppercase border-bottom border-2" style="border-color: rgba(256, 256, 256, .3) !important; font-size:1.8em">Welcome To The Premium Plus Insurance Program</h5>					
                    <h1 runat="server" visible="false" class="display-1 text-white mb-md-4">To receive benefits including payments of monthly health insurance premiums and medications copayments participants must comply with the following requirements</h1>
					<h1 class="display-1 text-white mb-md-4" style="font-sizeX:3em; text-shadowX: -1px 0 #606162, 0 1px #606162, 1px 0 #606162, 0 -1px #606162;">To receive <span class="iconscontainer" style="text-decoration:underline; cursor:help"><a runat="server" id="aProgramRequirements1" style="color:inherit">benefits</a><span class="spanToolTip spanToolTipWidth">Benefits include payments of monthly health insurance premiums and medication copayments.<br /><span style="color:orangered">Click to view the new requirements</span></span></span>, participants must<br />comply with the program <span class="iconscontainer" style="text-decoration:underline; cursor:pointer"><a runat="server" id="aProgramRequirements2" style="color:inherit">requirements</a><span class="spanToolTip " style="color:orangered">Click to view the new requirements</span></span></h1>
                    <div class="pt-2">
                        <div style="display:none; ">
                            <a runat="server" id="aPreRegistration" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; background-color: #ff4d0d; border-color: #ff4d0d; color:#fff;  width:41.0em; flex-shrink: 1; margin-bottom:20px; margin-left:0px !important">I want to PRE-REGISTER for a 2024 Federally Facilitated Marketplace ACA Plan</a>
                        </div>
                        <a runat="server" id="aEnrollmentAssistanceCY" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">I need assistance with Enrollment</a>
                        <a runat="server" id="aExistingPolicy" class="btn btn-outline-lightXX nex-btn-light rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">I already have an Insurance Policy</a>
                    </div>
                    
                </div>
                <div class="col-lg-3 col-md-6 media-col-lg-9 nex-text-primary" style="display:none; margin-top:40px; font-size:1.2em; font-weight:bold; color:#000">
                    Need Insurance Coverage?<br /><a href="">Check if you qualify for the Special Enrollment Period (SEP)</a>
                </div>
            </div>
        </div>
    </div>
    <!-- Hero End -->
<div style="padding:10px 20px; text-align:center; background-color:#eb576f; color:#fff;">
    ALL changes to income, address, or living situation, (i.e. marriage, divorce, adoption or tax filing status) MUST be reported to https://enroll.brhpc.org in addition to the program.
</div>

    <!-- About Start -->
    <div class="container-fluid py-5">
        <div class="container">
            <div class="row gx-5">
                <div class="col-lg-5 mb-5 mb-lg-0" style="min-height: 250px">
                    <div class="position-relative h-100" style="text-align:center">
                        <img class="position-absoluteXX w-100XX h-100 rounded" src="img/office4.png" style="object-fitXX: cover; width:300px">
                    </div>
                </div>
                <div class="col-lg-7">
                    <div class="mb-4">
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">About The Program</h5>
                        <h1 class="display-6">Insurance Benefit Management Services</h1>
                    </div>
                    <p>
						<b>Participants MUST Enroll In Premium Assistance Annually.</b> Enroll online at https://enroll.brhpc.org, over the telephone by calling 1-844-441-4422 or <span> <a style="text-decoration:underline" target="_blank" href="Content/docs/CountyHealthDepartmentContactList.pdf">calling your County Health Department</a></span>. This is REQUIRED even if you enrolled with an agent/broker, navigator, case manager, etc.
						<div style="margin-top:10px;">Enrollment and reenrollment in the premium assistance program is required prior to each calendar year regardless of the type of insurance enrolled in, including marketplace/Affordable Care Act (ACA), employer sponsored insurance, or COBRA.</div>
						<div style="margin-top:10px; font-size:120%; color:#2681bd">Insurance Enrollment Assistance is provided by our partner <b>American Exchange</b></div>
					</p>
                </div>
            </div>
        </div>
    </div>
    <!-- About End -->
	
    <div class="container-fluid py-5">
        <div class="container" style="widthX:80%; margin-leftX:auto; margin-rightX:auto">
			<div class="row g-5">
			
						<div class="col-md-6 col-md-6">
						<span>
                            <div class="nex-service-itemX bg-light text-center rounded-circleXX rounded py-4" style="padding:20px 40px 25px 40px !important">
                                <div class="fa fa-3x fa-user-mdX text-primary nex-dadecounty mb-3X"></div>
                                <h4 classX="mb-0" style="color:#DB2100">Miami-Dade County<span class="d-block text-primaryX" style="color:#43454a; font-weight:normal; font-size:80%">If you live in Miami-Dade County there is a different enrollment process. Go to American Exchange or call 1-844-367-6535</span>
								
								</h4>
								<a style="display:none !important" class="btn btn-lg btn-primary rounded-pill" href="#">
									<i class="bi bi-arrow-right"></i>
								</a>
                            </div>
						</span>
                        </div>
						
						<div class="col-md-6 col-md-6">
						<a runat="server" id="aRequiredTaxForms1">
                            <div class="nex-service-item bg-light text-center rounded-circleXX rounded py-4" style="padding:20px 40px 25px 40px !important">
                                <div class="fa fa-3x fa-user-mdX text-primary nex-taxforms mb-3X"></div>
                                <h4 classX="mb-0" style="color:#0C822C">Required Tax forms<span class="d-block text-primaryX" style="color:#43454a; font-weight:normal; font-size:80%">For Marketplace policies with Premium Tax Credits.<br />Upload your required tax forms for 2023 no later than May 31 2024.</span>
								
								</h4>
								<a runat="server" id="aRequiredTaxForms2" class="btn btn-lg btn-primary rounded-pill">
									<i class="bi bi-arrow-right"></i>
								</a>								
                            </div>
						</a>
                        </div>
			
				
			</div>
		</div>		
	</div>
    

    <!-- Services Start -->
    <div class="container-fluid py-5">
        <div class="container">
            <div class="text-center mx-auto mb-5" style="max-width: 500px;">
                <h4 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">Links & Information</h4>
                <h1 class="display-6XX" style="widthX:1000px !important; font-size:2.0rem">If you have any questions not addressed below, please <a class="nex-link-greyish" href="#footer">contact us</a></h1>
            </div>
            <div class="row g-5">
			
<a runat="server" id="aParticipatingPharmacies1" class="nex-bigicon-link" target="_blank" >

                <div class="col-lg-4 col-md-6 ">				
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x icon-medication text-white"></i>
                        </div>
                        <h4 class="mb-3">Participating Pharmacies</h4>
                        <p class="m-0" style="display:none">Document of CVS and Participating Network Pharmacies In Florida.</p>
                        <a runat="server" id="aParticipatingPharmacies2" class="btn btn-lg btn-primary rounded-pill" target="_blank">
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
					
                </div>
</a>
<a runat="server" id="aVideoTutorial1" class="nex-bigicon-link" target="_blank" >

                <div class="col-lg-4 col-md-6">
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x fa-stethoscopeX icon-questionaire text-white"></i>
                        </div>
                        <h4 class="mb-3">Tutorial: How to complete the questionnaire</h4>
                        <p class="m-0" style="display:none">Kasd dolor no lorem nonumy sit labore tempor at justo rebum rebum stet, justo elitr dolor amet sit</p>
                        <a runat="server" id="aVideoTutorial2" class="btn btn-lg btn-primary rounded-pill" target="_blank" >
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>
</a>				
<a runat="server" id="aEligiblePlans1" class="nex-bigicon-link" target="_blank" >
                <div class="col-lg-4 col-md-6">
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x icon-checklist text-white"></i>
                        </div>
                        <h4 class="mb-3">Eligible ACA Health Insurance Plans for 2023</h4>
                        <a runat="server" id="aEligiblePlans2" class="btn btn-lg btn-primary rounded-pill" target="_blank">
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>
</a>				
<a runat="server" id="aInsuranceCard1" class="nex-bigicon-link" target="_blank" >
                <div class="col-lg-4 col-md-6">
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x icon-idcard text-white"></i>
                        </div>
                        <h4 class="mb-3">Read an Insurance ID Card</h4>
                        <p class="m-0" style="displayX:none">How to Read an Insurance ID Card and Information on Doctors, Pharmacies & Hospitals.</p>
                        <a runat="server" id="aInsuranceCard2" class="btn btn-lg btn-primary rounded-pill" target="_blank" >
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>
</a>
<a runat="server" id="aEOB_and_HealthInsBill1" class="nex-bigicon-link" >
                <div class="col-lg-4 col-md-6">
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x icon-bills text-white"></i>
                        </div>
                        <h4 class="mb-3">Health Insurance Bills</h4>
                        <p class="m-0" style="displayX:none">Examples of "Explanation of Benefits (EOB)" & "Health Insurance Bill".</p>
                        <a runat="server" id="aEOB_and_HealthInsBill2" target="_blank" class="btn btn-lg btn-primary rounded-pill" >
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>
</a>				
<a runat="server" id="aMedicare1" class="nex-bigicon-link" target="_blank" >
                <div class="col-lg-4 col-md-6">
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x icon-medicare text-white"></i>
                        </div>
                        <h4 class="mb-3">Medicare and Enrollment</h4>
                        <p class="m-0" style="displayX:none">Call American Exchange: 1-833-243-0496 or call your Agent/Broker</p>
                        <a runat="server" id="aMedicare2" class="btn btn-lg btn-primary rounded-pill" target="_blank">
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>
</a>
<a runat="server" id="aEducationalMaterials1" class="nex-bigicon-link" target="_blank">
                <div class="col-lg-4 col-md-6">
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x icon-education text-white"></i>
                        </div>
                        <h4 class="mb-3">Educational Materials</h4>
                        <p class="m-0" style="displayX:none">Insurance Enrollment Outreach, Education and Technical Assistance Educational Materials.</p>
                        <a runat="server" id="aEducationalMaterials2" class="btn btn-lg btn-primary rounded-pill" target="_blank">
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>
</a>   
<a runat="server" id="aExplanationOfBenefits1" class="nex-bigicon-link" target="_blank">
                <div class="col-lg-4 col-md-6">
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x icon-benefits text-white"></i>
                        </div>
                        <h4 class="mb-3">Explanation of Benefits</h4>
                        <p class="m-0" style="displayX:none">Assistance with understanding the “Explanation of Benefits”.</p>
                        <a runat="server" id="aExplanationOfBenefits2" class="btn btn-lg btn-primary rounded-pill" target="_blank" >
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>				
</a>      
<a style="display:contents !important; display:none" target="_blank" href="#">
                <div style="display:none" class="col-lg-4 col-md-6">
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x icon-glossary text-white"></i>
                        </div>
                        <h4 class="mb-3">Glossary of Terms</h4>
                        <p class="m-0" style="display:none">Information regarding Medicare and Enrollment.</p>
                        <a class="btn btn-lg btn-primary rounded-pill" target="_blank">
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>
</a>
<a runat="server" id="aGrievanceProcess1" class="nex-bigicon-link" target="_blank" >
                <div class="col-lg-4 col-md-6">
                    <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center">
                        <div class="service-icon mb-4">
                            <i class="fa fa-2x icon-complaint text-white"></i>
                        </div>
                        <h4 class="mb-3">Premium Assistance Internal Client Complaint Procedure Grievance Process</h4>
                        <p class="m-0" style="display:none">Complete the required sections on the form and mail or fax to the responsible party as noted on Page 6 of the document.</p>
                        <a runat="server" id="aGrievanceProcess2" class="btn btn-lg btn-primary rounded-pill" target="_blank">
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>						
</a>		
				
            </div>
        </div>
    </div>
    <!-- Services End -->


</asp:Content>
