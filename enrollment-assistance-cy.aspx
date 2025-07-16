<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="enrollment-assistance-cy.aspx.cs" Inherits="Insurance_Enrollment_2024.enrollment_assistance_cy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<script type = "text/javascript">

    function showListOfEvents() {
        if (document.getElementById("spanListOfEvents").style.display == "none") {
            document.getElementById("spanListOfEvents").style.display = "block";
            document.getElementById("spanViewListOfEvents").innerHTML = "Hide list of events.";
        }
        else {
            document.getElementById("spanListOfEvents").style.display = "none";
            document.getElementById("spanViewListOfEvents").innerHTML = "View list of events.";
        }
    }

</script>

<div style="padding:10px 20px; text-align:center; background-color:#EA5276; font-size:130%">
<a runat="server" id="aProgramRequirements1" style="color:#fff !important">** Important Changes ** Before completing the form, please <u>READ</u> before enrolling.</a>
<a runat="server" visible="false" id="a1" style="color:#fff !important">** Important Changes starting 2024 ** Before completing the form, please <u>READ</u> before enrolling.</a>
</div>	
	
    <div class="container-fluid py-5" style="min-height:40em">
        <div class="container">
            <div class="row gx-5">
               
			   <div class="col-lg-8">
                    <div class="mb-4">
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">I need an Insurance Policy</h5>
                        <h1 class="display-6">I have NOT enrolled in a Marketplace/ACA Plan for 2024</h1>
                    </div>
                    <div style="background-color: #fcd7e3; color:#000; font-size:120%; border-radius: 10px; padding:10px 20px; margin-bottom:10px">
                        
                        <span class="iconscontainerX">
                            <b>Special Enrollment Period (SEP) 2024:</b> You can enroll if you have certain life events or income change.
                            <span id="spanViewListOfEvents" class="nex-text-primary" style="font-weight:bold; cursor:help; color:#056db0 !important" onclick="showListOfEvents()">View list of events.</span>
                            <span id="spanListOfEvents" class="spanToolTipX spanToolTipWidthX" style="display:none; background-color:#ffe8ef; border-radius:10px; padding:10px 10px 4px 5px; margin-bottom:7px">
                                <ol style="margin-bottom:8px; font-size:90%">
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
                        <a runat="server" id="aSpecialEnrollmentPeriod_Orig" visible="false" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color:#FAB7CD !important; border-color: #FAB7CD !important; font-size:110%; margin-left:0px !important">
                            Special Enrollment 2024
                        </a>		
                        <a runat="server" id="aSpecialEnrollmentPeriod" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color:#f2c879 !important; border-color: #f2c879 !important; font-size:110%; margin-left:0px !important">
                            I need insurance for 2024
                        </a>	
                        <span class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
                    </div>

                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
