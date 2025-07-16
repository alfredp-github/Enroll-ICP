<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default_test2.aspx.cs" Inherits="Insurance_Enrollment_2024._default_test2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">

        .nex-block-inline-1 {
            line-height:100% !important;
        }
        .nex-block-inline-2 {
            display:block;
            line-height:100% !important;
            margin-top:5px;
        }

        .display-2 {
            text-shadow:1px 1px #606162;
        }

        @media (max-width: 767.98px) {
            .nex-left-side {
                float:none !important;
                margin-right:0px !important;
            }
            .miamidade1
            {
                float:none !important;
                display:block !important;
                widthX:31.0em !important;
                margin-top:20px !important;
                margin-leftX:auto !important;
                margin-righXt:auto !important;
                borderX:orange 3px dashed;
            }
            .miamidade2
            {
                



                margin-top:-18px !important;
                borderX:red 5px dashed;
                width:20.5em !important;
                padding:10px 0px !important;
                                background-color:#fffdab !important;
                                text-align:center !important;
                                                margin-left:auto !important;
                margin-right:auto !important;

            }
            .miamidade2 a, .miamidade2 span {
                color:#383838 !important;
                
            }

            .nex-recertify {
                width:24.4em !important;
            }
            .miamidade2x a {
                color:orangered !important;

            }
            .nex-block-inline-1 {
                                borderX:red 5px dashed;
                                                                text-align:center !important;

            }
            .nex-block-inline-2 {
                display:block !important;
                borderX:green 5px solid;
                widthX:18.0em !important;
                                                text-align:center !important;

            }
                                                .spanToolTipWidth{
                width:100% !important;
                text-align:left;
            }
        }

        @media (max-width: 590px) {

            .nex-recertify {
                width:94% !important;
            }
            .nex-left-side a {
                width:94% !important;
                padding-left:20px !important;
                padding-right:20px !important;
            }
            .miamidade2
            {
                width:94% !important;
            }

        }

        @media (min-width: 767.99px) and (max-width: 991.98px) {

            .nex-left-side {
                float:none !important;
            }
            .miamidade1
            {
                float:none !important;
                display:block !important;
                width:41.6em !important;
                borderX:green 5px solid;
            }
            .miamidade2 
            {
                                margin-top:20px !important;
                display:block !important;
                width:28.0em !important;
                font-size:1.5em !important;

                                background-color:#fffdab !important;
                                text-align:center !important;
            }
            .miamidade2 a, .miamidade2 span {
                color:#383838 !important;
                
            }
            .nex-recertify {
                width:32.4em !important;
            }

            .nex-block-inline-2 {
                display:inline;
                line-height:100% !important;
                margin-top:0px;
            }

            .spanToolTipWidth{
                width:100% !important;
                text-align:left;
            }

                                    .spanToolTipWidth{
                width:100% !important;
                text-align:left;
            }
        }

        @media (min-width: 1199.99px) and (max-width: 1299.98px) {
            .miamidade1
            {

                borderX:red 1px solid;
            }
            .miamidade2 {
                margin-top:10px !important;
                font-size:1.5em !important;
                                width:31.6em !important;
                                                text-align:center !important;
                background: rgba(0, 0, 0, .20) !important;
                border-right:#000 1px solid !important; 
                border-bottom:#000 1px solid !important; 

            }

            .nex-recertify {
                width:36.1em !important;
            }

            .nex-block-inline-2 {
                display:inline-block;
                line-height:100% !important;
                margin-top:5px !important;
                                
                borderX:blue 5px solid;
            }
                                    .spanToolTipWidth{
                width:100% !important;
                text-align:left;
            }

        }

        @media (min-width: 991.99px) and (max-width: 1199.98px) {

            .nex-left-side {
                float:none !important;
            }
            .nex-right-side {
                float:none !important;
            }
            .miamidade1
            {
                display:block !important;
                widthX:41.6em !important;
                borderX:blue 5px solid;
            }
            .miamidade2 
            {
                margin-top:20px !important;
                display:block !important;
                width:31.6em !important;
                font-size:1.5em !important;
                                                text-align:center !important;

                borderX:yellow 5px solid;

                background: rgba(0, 0, 0, .20) !important;
                border-right:#000 1px solid !important; 
                border-bottom:#000 1px solid !important; 
            }

            .nex-recertify {
                width:36.1em !important;
            }

            .nex-block-inline-2 {
                display:inline;
                line-height:100% !important;
                margin-top:0px;
                borderX:purple 1px solid !important;
            }

                                    .spanToolTipWidth{
                width:100% !important;
                text-align:left;
            }

        }

        .mb-md-4 {
            margin-bottom:2.7rem !important;
        }

    </style>

    <asp:Label ID="lblIP_Address" runat="server" Text="" ClientIDMode="Static" style="display:none"></asp:Label>

    <div style="display:none; padding:5px 20px; text-align:center; background-color:#eb576f; color:#fff">
<a>** Important Changes for 2024 ** Before completing the form, please <u>read</u> before enrolling.</a>
</div>

    <style>
        .back-rgba-opacity:hover, .back-rgba-opacity-2:hover {
            background: rgba(0, 0, 0, .50) !important;
        }
        .back-rgba-opacity:hover a {
            color:#fffc96 !important;
        }
        .back-rgba-opacity-2:hover a, .back-rgba-opacity-2:hover .callout-2 {
            color:#fff !important;
            text-shadow: 0px;
        }
    </style>

    <!-- Hero Start -->
    <div class="container-fluid bg-primary py-5 mb-5 nex-mb-5 hero-header" style="borderX:red 1px solid; padding-bottom:0px !important; padding-left:0px; padding-right:0px">
        <div class="container py-5X"  style="borderX:green 1px solid; padding-bottom:0px !important; padding-top:30px; padding-bottom:40px !important">
            <div class="row justify-content-start" style="borderX:red 1px solid; padding-bottom:0px !important">
                <div class="col-lg-9 text-center text-lg-start" style="width:100%">
                    <div style="floatX:left">
                        <h5 class="d-inline-block text-primaryXX nex-text-primary text-uppercase border-bottom border-2" style="display:none !important; border-color: rgba(256, 256, 256, .3) !important; font-size:1.8em">Welcome To The Premium Assistance Program</h5>
					    <h5 class="d-inline-block text-primaryXX nex-text-primary text-uppercase border-bottom border-2" style="border-color: rgba(256, 256, 256, .3) !important; font-size:1.8em">Welcome To The Premium Plus Insurance Program</h5>					
                        <h1 runat="server" visible="false" class="display-1 text-white mb-md-4">To receive benefits including payments of monthly health insurance premiums and medications copayments participants must comply with the following requirements</h1>
					    <h1 class="display-1 text-white mb-md-4" style="font-sizeX:3em; text-shadowX: -1px 0 #606162, 0 1px #606162, 1px 0 #606162, 0 -1px #606162; ">To receive <span class="iconscontainer" style="text-decoration:underline; cursor:help"><a runat="server" id="aProgramRequirements1" style="color:inherit">benefits</a><span class="spanToolTip spanToolTipWidth">Benefits include payments of monthly health insurance premiums and medication copayments.<br /><span style="color:orangered">Click to view the new requirements</span></span></span>, participants must<br />comply with the program <span class="iconscontainer" style="text-decoration:underline; cursor:pointer"><a runat="server" id="aProgramRequirements2" style="color:inherit">requirements</a><span class="spanToolTip " style="color:orangered">Click to view the new requirements</span></span></h1>
                        
                    <div runat="server" visible="true" class="back-rgba-opacity nex-recertify" style="font-size:1.3em; font-weight:bold; color:#fff; borderX:red 1px solid; border-radius:15px; margin-top:0px; padding:16px 20px; margin-bottom:12px; background: rgba(0, 0, 0, .25); width: 46.6em; text-align:center">
                         <span runat="server" visible="false" style="right:5px; color:#fff; font-size:1.2em">&#187;</span>
                        <a  runat="server" id="aRecertified" href="enrollment-verification.aspx" style="color:#fff; text-decorationX:underline">Have you recently renewed your <span style="color:yellow">Program Eligibility?</span> Verify your coverage for 2024</a>
                    </div>
                        
                        <div class="pt-2 nex-left-side" style="float:left; margin-right:13px">
                            <div style="display:flex; ">
                                <a runat="server" id="aPreRegistration" visible="false" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; background-color: #ff4d0d; border-color: #ff4d0d; color:#fff;  width:37.7em; flex-shrink: 1; margin-bottom:20px; margin-left:0px !important">I want to PRE-REGISTER for a 2024 Marketplace / ACA Plan</a>
                                <a runat="server" id="aEnrollmentAssistance" visible="false" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; background-color: #ff4d0d; border-color: #ff4d0d; color:#fff;  width:41.6em; flex-shrink: 1; margin-bottom:20px; margin-left:0px !important">OPEN ENROLLMENT: I need an Insurance Policy for 2024</a>
                                <a runat="server" id="aEnrollmentAssistanceCY" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; background-color: #ff4d0d; border-color: #ff4d0d; color:#fff;  width:41.6em; flex-shrink: 1; margin-bottom:20px; margin-left:0px !important">SPECIAL ENROLLMENT: I need an Insurance Policy for 2024</a>

                            </div>
                            <div style="display:flex; ">
                            <a runat="server" visible="false" id="aEnrollmentAssistanceCY_Orig" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">I need an Insurance Policy for 2023</a>
                            <a runat="server" visible="false" id="a1" class="btn btn-outline-lightXX nex-btn-light rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">I already have an Insurance Policy</a>
                            <a runat="server" id="aExistingPolicy"           class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; margin-left:0px !important;width:41.6em; flex-shrink: 1; ">I already have Insurance for 2024 (ACA/Employer/COBRA)</a>
                            </div>
                        </div>

                        <div class="miamidade1 nex-right-side" style="float:left; margin-top:7px">
                            <div runat="server" visible="true" class="back-rgba-opacity-2x iconscontainer display-2x miamidade2" style="font-size:1.4em; font-weight:bold; line-height:124%; color:#fff; border-topX:yellow 5px solid; border-right:#737373 1px solid; border-bottom:#737373 1px solid; border-radiusX:20px 0px 20px 0px; border-radius:1rem; margin-top:0px; padding:13px 20px 14px 20px; background: rgba(0,0,0, .10) url(img/md-logo-2X.png) no-repeat right bottom; background-sizeX:50px 25px; background-imageX:url(img/md-logo.png) no-repeat right bottom;  width:8.80em; text-align:left">
                                <span class="callout-2" style="display:none; float:left; font-size:195%; color:yellow; text-shadowX: 1px 1px 0px white; margin-right:0px; width:14%">*</span>
                                <a runat="server" id="aMiamiDade3" href="#" style="floatX:left; widthX:100%; borderX:pink 3px solid; color:yellow; text-shadowX: 0px 0px 6px white; -webkit-text-strokeX: 1px white; text-decorationX:underline">
                                    <span style="color:yellow; text-shadowX: 2px 2px 0px #12566b !important; text-decorationX:underline; text-transform: uppercase;">Miami-Dade Assessment</span>
                                    <span class="nex-block-inline-2" style="font-size:0.8em; font-weight:normal;  ">There is a different enrollment process for residents</span>
                                </a>
                                <div style="clear:both"></div>
                                <span class="spanToolTip spanToolTipWidth" style="line-height:125%">If the Primary Applicant lives in Miami-Dade County there is a different enrollment process<br /><b style="color:orangered">(click to proceed)</b><br />or call 1-844-367-6535</span>

                            </div>
                            <div runat="server" visible="false" class="back-rgba-opacity-2x iconscontainer display-2 miamidade2" style="font-size:1.6em; font-weight:bold; line-height:125%; color:#fff; border-topX:yellow 5px solid; border-right:#737373 1px solid; border-bottom:#737373 1px solid; border-radiusX:20px 0px 20px 0px; border-radius:1rem; margin-top:0px; padding:16px 22px 20px 22px; background: rgba(255, 255, 255, .20) url(img/md-logo-2X.png) no-repeat right bottom; background-size:50px 25px; background-imageX:url(img/md-logo.png) no-repeat right bottom;  width:8.40em; text-align:left">
                                <span class="callout-2" style="display:none; float:left; font-size:195%; color:yellow; text-shadowX: 1px 1px 0px white; margin-right:0px; width:14%">*</span>
                                <a runat="server" id="a2" href="#" style="floatX:left; widthX:100%; borderX:pink 3px solid; color:#fcf886; text-shadowX: 0px 0px 6px white; -webkit-text-strokeX: 1px white; text-decorationX:underline">
                                    <span class="nex-block-inline-1" style="font-size:95%; text-shadowX: 2px 2px 0px #267a20 !important;">Do you live in</span> <span style="color:#fcf753; text-shadowX: 2px 2px 0px #12566b !important; text-decorationX:underline; text-transform: uppercase;">Miami-Dade</span>?
                                    <span class="nex-block-inline-2" style="font-size:0.7em;  ">There is a different enrollment process.</span>
                                </a>
                                <div style="clear:both"></div>
                                <span class="spanToolTip spanToolTipWidth" style="line-height:125%">If you live in Miami-Dade County there is a different enrollment process <b style="color:orangered">(click to proceed)</b><br />or call 1-844-367-6535</span>

                            </div>

                            <div runat="server" visible="false" class="back-rgba-opacity-2 iconscontainer display-1" style="font-size:1.4em; borderX:white 1px solid; font-weight:bold; line-height:125%; color:#fff; borderX:red 1px solid; border-radius:12px 0px 12px 0px; margin-top:20px; padding:16px 22px 25px 15px; background: rgba(255, 255, 255, .15) url(img/md-logo-2.png) no-repeat right bottom; background-size:50px 25px; background-imageX:url(img/md-logo.png) no-repeat right bottom;  width:9.55em; text-align:left">
                                <span class="callout-2" style="float:left; font-size:195%; color:yellow; text-shadowX: 1px 1px 0px white; margin-right:0px; width:14%">*</span>
                                <a runat="server" id="aaa" href="#" style="float:left; width:86%; color:#fff; text-shadowX: 0px 0px 6px white; -webkit-text-strokeX: 1px white; text-decorationX:underline">
                                    <span class="" style="font-size:95%">Do you live in</span> <span style="color:#fff; text-decoration:underline; text-transform: uppercase;">Miami-Dade</span>?
                                </a>
                                <div style="clear:both"></div>
                                <span class="spanToolTip spanToolTipWidth">If you live in Miami-Dade County there is a different enrollment process <b style="color:orangered">(click to proceed)</b><br />or call 1-844-367-6535</span>
                            </div>
                            <div runat="server" visible="false" class="back-rgba-opacity" style="font-size:1.5em; borderX:white 1px solid; font-weight:bold; line-height:130%; color:#fff; borderX:red 1px solid; border-radius:15px; margin-top:20px; padding:16px 20px 16px 15px; background: rgba(255, 255, 255, .55) url(img/md-logo-color-3.png) no-repeat right bottom; background-size:70px 30px; background-imageX:url(img/md-logo.png) no-repeat right bottom;  width: 8.8em; text-align:left">
                                <span style="float:left; font-size:125%; color:#0b83ba; margin-right:0px; width:10%">*</span>
                                <a href="enrollment-verification.aspx" style="float:left; width:90%; color:#ff8b45; text-shadowX: 0px 0px 6px white; -webkit-text-strokeX: 1px white; text-decorationX:underline">
                                    Do you live in <span style="color:#ff721c">Miami-Dade</span> County?
                                </a>
                                <div style="clear:both"></div>
                            </div>
                            <div runat="server" visible="false" class="back-rgba-opacity" style="font-size:1.5em; borderX:white 1px solid; font-weight:bold; line-height:140%; color:#fff; borderX:red 1px solid; border-radius:15px; margin-top:10px; padding:16px 20px; background: rgba(255, 255, 255, .45) url(img/md-logo.png) no-repeat right bottom; background-size:80px 36px; background-imageX:url(img/md-logo.png) no-repeat right bottom;  width: 8.5em; text-align:left">
                                <span style="float:left; font-size:125%; color:#0b83ba; margin-right:0px; width:10%">*</span>
                                <a href="enrollment-verification.aspx" style="float:left; width:90%; color:#428724; text-shadowX: 0px 0px 6px white; -webkit-text-strokeX: 1px white; text-decorationX:underline">
                                    Do you live in <span style="color:#ff8b45">Miami-Dade</span> County?
                                </a>
                                <div style="clear:both"></div>
                            </div>
                        </div>
                        <div style="clear:both"></div>

                    </div>
                    <div style="display:none; float:left">
                        <div runat="server" visible="true" class="back-rgba-opacity" style="font-size:1.5em; borderX:white 1px solid; font-weight:bold; color:#fff; borderX:red 1px solid; border-radius:40px; margin-top:40px; padding:16px 20px; background: rgba(255, 255, 255, .35); width: 10em; text-align:center">
                            <img src="img/md-logo.png" style="width:60px"/>
                                <a href="enrollment-verification.aspx" style="color:#428724; text-shadowX: 1px 1px 0px white; -webkit-text-strokeX: 1px white; text-decorationX:underline">
                                Do you live in <span style="color:#0b83ba">Miami-Dade</span> County?
                            </a>
                        </div>
                    </div>

                </div>
                <div runat="server" visible="false" style="margin-top:40px; position:relative; border:red 1px solid">
                    <span style="position:absolute; top:0.2em; left:0.9em; z-index:9999; font-size:1.6em; font-weight:bold; color:#fff;">Have you recently renewed your program eligibility? <a href="#" style="color:#fff">Verify your coverage for 2024</a>.</span>
                    <div runat="server" visible="true" style="font-size:1.6em; font-weight:bold; color:red; borderX:red 1px solid; border-radius:10px; background-color:grey; opacity:50%; width: max-content; padding:6px 12px">
                        Have you recently renewed your program eligibility? Verify your coverage for 2024
                    </div>
                </div>
                <div runat="server" visible="false" style="padding-top:20px; font-size:2em">
                    I recently renewed my program eligibility and want to verify my coverage for 2024
                </div>

                <div class="col-lg-3 col-md-6 media-col-lg-9 nex-text-primary" style="display:none; margin-top:40px; font-size:1.2em; font-weight:bold; color:#000">
                    Need Insurance Coverage?<br /><a href="#">Check if you qualify for the Special Enrollment Period (SEP)</a>
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
						<a runat="server" id="aMiamiDade">
                            <div class="nex-service-itemX bg-light text-center rounded-circleXX rounded py-4" style="padding:20px 40px 25px 40px !important">
                                <div class="fa fa-3x fa-user-mdX text-primary nex-dadecounty mb-3X"></div>
                                <h4 classX="mb-0" style="color:#DB2100">Miami-Dade County<span class="d-block text-primaryX" style="color:#43454a; font-weight:normal; font-size:80%">If you live in Miami-Dade County there is a different enrollment process. Go to American Exchange or call 1-844-367-6535</span>
								
								</h4>
								<a runat="server" id="aMiamiDade2" class="btn btn-lg btn-primary rounded-pill" href="#">
									<i class="bi bi-arrow-right"></i>
								</a>
                            </div>
						</a>
                        </div>
						
						<div class="col-md-6 col-md-6">
						<a runat="server" id="aRequiredTaxForms1">
                            <div class="nex-service-item bg-light text-center rounded-circleXX rounded py-4" style="padding:20px 40px 25px 40px !important">
                                <div class="fa fa-3x fa-user-mdX text-primary nex-forms mb-3X"></div>
                                <h4 classX="mb-0" style="color:#0C822C">Upload Forms<span class="d-block text-primaryX" style="color:#43454a; font-weight:normal; font-size:80%">For required Tax forms, Marketplace requested forms and any other program forms</span>
								
								</h4>
								<a runat="server" id="aRequiredTaxForms2" class="btn btn-lg btn-primary rounded-pill">
									<i class="bi bi-arrow-right"></i>
								</a>								
                            </div>
						</a>
                        </div>
                		<div runat="server" visible="false" class="col-md-6 col-md-6">
						<a runat="server" id="aRequiredTaxForms1_Orig">
                            <div class="nex-service-item bg-light text-center rounded-circleXX rounded py-4" style="padding:20px 40px 25px 40px !important">
                                <div class="fa fa-3x fa-user-mdX text-primary nex-taxforms mb-3X"></div>
                                <h4 classX="mb-0" style="color:#0C822C">Required Tax forms<span class="d-block text-primaryX" style="color:#43454a; font-weight:normal; font-size:80%">For Marketplace policies with Premium Tax Credits.<br />Upload your required tax forms for 2023 no later than May 31 2024.</span>
								
								</h4>
								<a runat="server" id="aRequiredTaxForms2_Orig" class="btn btn-lg btn-primary rounded-pill">
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
                            <i class="fa fa-2x fa-stethoscopeX icon-questionaire-2 text-white"></i>
                        </div>
                        <h4 class="mb-3">Tutorials: How to complete the questionnaire</h4>
                        
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
                        <h4 class="mb-3">Eligible ACA Health Insurance Plans</h4>
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
                        <p class="m-0" style="display:none">Call American Exchange: 1-833-243-0496 or call your Agent/Broker</p>
                        <p class="m-0" style="displayX:none">Medicare Assessment Form 2024</p>
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
