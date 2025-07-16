<%@ Page Title="" Language="C#" MasterPageFile="~/Site_Original.Master" AutoEventWireup="true" CodeBehind="original.aspx.cs" Inherits="Insurance_Enrollment_2024.original" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript">  



    </script>  
    <asp:Label ID="lblIP_Address" runat="server" Text="" ClientIDMode="Static" style="display:none"></asp:Label>

<div runat="server" visible="false" class="row" style="padding:30px 40px; font-size:150%; border:orangered 1px solid; border-radius:10px; margin-top:20px; margin-bottom:70px">
    <div runat="server" visible="false" style="margin-bottom:30px">
        <b>The option to enroll through this site is no longer available.</b> If you have not enrolled, you have until Midnight Pacific time in order to complete your enrollment. Please go to <a href="https://www.healthcare.gov/">https://www.healthcare.gov/</a> to complete your enrollment.
    </div>
    <div style="margin-bottom:30px">
        Open enrollment has closed but if you have a special circustance please go to <a href="https://www.healthcare.gov/">https://www.healthcare.gov/</a> to complete your enrollment.
    </div>
    <div>
        You may qualify for a Special Enrollment Period (SEP) if you've had certain life events, including losing health coverage, moving, getting married, having a baby, or adopting a child. If you qualify for an SEP, you usually have up to 60 days following the event to enroll in a plan.
    </div>
</div>

    <div style="font-size:150%; margin-bottom:20px; padding:0px 40px; color:red; text-align:center">
        <span style="font-size:150%">**</span> If you live in <u><b>Miami-Dade County</b></u> there is a different enrollment process <span style="font-size:150%">**</span><br />For the required enrollment process contact your case manager.
    </div>

    <div runat="server" visible="true" class="rowX" style="padding-left:10px; padding-right:10px; padding-top:10px; width:98.5%">
        <div class="col-md-6X nex-box-1" style="border:lightgray 1px solid; border-radius:7px; min-heightX:380px; padding:5px 30px 25px 30px">
            <div style="float:left; margin-right:40px">
                <h2 style="color:#1488ae">
                    <span style="color:orangered">2021</span> Open Enrollment Pre-Registration
                </h2>
                <div style="font-size:140%">To pre-register for open enrollment for a 2021 ACA Plan</div>
            </div>
            <a class="btn btn-primary btn-lg" style="float:left;margin-top:32px" href="preopen-enrollment-assessment.aspx" onclick="AnaInsert('PreOpenEnrollAssessment')" style="">Click Here &raquo;</a>
            <div style="clear:both"></div>
        </div>
    </div>



    <div runat="server" visible="true" class="rowX" style="padding-left:10px; padding-right:10px; padding-top:10px; ">
        <div class="col-md-6 nex-box-1" style="border:lightgray 1px solid; border-radius:7px; min-height:380px; padding:5px 30px 13px 30px">
            <h3 runat="server" visible="false" style="color:#1488ae">
                I have <span style="color:orangered">NOT</span> enrolled in a Federally Facilitated Marketplace Plan for 2020:
            </h3>
            <h3 style="color:#1488ae">
                I have <span style="color:orangered">NOT</span> enrolled in an Insurance Plan for 2020:
            </h3>
            <p style="margin-top:15px">

                <div runat="server" visible="true" style="color:maroon; margin-top:10px; margin-bottom:30px">
                    **Do not complete this form if you have already completed an enrollment in a Federally Facilitated Marketplace Health Insurance Plan for 2020 through the Federally Facilitated Marketplace or through an Agent/Broker. 
                    Only complete this form if you need assistance with Federally Facilitated Marketplace enrollment from BRHPC/American Exchange. 
                    American Exchange is a CMS Certified Federally Facilitated Marketplace Agent/Broker in the State of Florida and will act as your Agent of Record upon completing this form.**
                </div>

                <div runat="server" visible="false" style="">
                    <div style="margin-bottom:20px">
                        <b>The option to enroll through this site is no longer available.</b> If you have not enrolled, you have until 3:00 AM eastern time (EST) in order to complete your enrollment. Please go to <a href="https://www.healthcare.gov/">https://www.healthcare.gov/</a> to complete your enrollment.
                    </div>
                    <div>
                        You may qualify for a Special Enrollment Period (SEP) if you've had certain life events, including losing health coverage, moving, getting married, having a baby, or adopting a child. If you qualify for an SEP, you usually have up to 60 days following the event to enroll in a plan.
                    </div>
                </div>

            </p>
            <p runat="server" visible="true" class="nex-box-1-area-button" style="text-align:center; position:absolute; width:100%; bottom:20px; left:0px">
                <a class="btn btn-primary btn-lg" href="not-enrolled.aspx" onclick="AnaInsert('Not Enrolled')" style="">Click Here &raquo;</a>

                <span style="display:none; width:65%; float:left; font-size:105%; font-style:italic; borderX:red 1px solid">
                    If you need assistance completing<br />this form call 1-844-441-4422
                </span>
            </p>
        </div>
        <div class="col-md-6 nex-box-2-wrap" style="padding-left:15px">
            <div class="nex-box-2" style="border:lightgray 1px solid; border-radius:7px; min-height:380px; padding:5px 20px 13px 30px">

                <h3 style="color:#1488ae">
                    I have <span style="color:orangered">Already</span> enrolled in an Insurance Plan for 2020:
                </h3>
                <p style="margin-top:15px">
                    Complete this form if you have already enrolled in a Federally Facilitated Marketplace Plan, Employer Sponsored Plan or COBRA for 2020. 
                    <div style="display:none; color:maroon; margin-bottom:20px">
                        **Please only complete this form if you have already successfully enrolled in a Federally Facilitated Marketplace Plan for 2020.**
                    </div>
                </p>
                <p class="nex-box-1-area-button" style="text-align:center; position:absolute; width:100%; bottom:20px; left:0px">
                    <a class="btn btn-primary btn-lg" href="enrolled.aspx" onclick="AnaInsert('Already Enrolled')" style="">Click Here &raquo;</a>

                    <span style="display:none; width:62%; float:left; font-size:105%; font-style:italic; borderX:red 1px solid">
                        If you need assistance completing<br />this form call 1-844-441-4422
                    </span>
                </p>
            </div>
        </div>
        <div class="col-md-6 nex-box-2-wrap" style="display:none; padding-left:15px">
            <div class="nex-box-2" style="border:lightgray 1px solid; border-radius:7px; min-height:380px; padding:5px 20px 13px 30px">

                <h3 style="color:#1488ae">
                    I have <span style="color:orangered">Already</span> enrolled in an Insurance Plan for 2020:
                </h3>
                <p style="margin-top:15px">
                    Complete this form if you have already enrolled in a Federally Facilitated Marketplace Plan for 2020 and want to keep your current Agent/Broker. 
                    You will have to rely on your current Agent/Broker for customer service and any premium payment issues.
                    <div style="color:maroon; margin-bottom:20px">
                        **Please only complete this form if you have already successfully enrolled in a Federally Facilitated Marketplace Plan for 2020.**
                    </div>
                </p>
                <p class="nex-box-1-area-button" style="text-align:center; position:absolute; width:100%; bottom:20px; left:0px">
                    <a class="btn btn-primary btn-lg" href="enrolled.aspx" onclick="AnaInsert('Already Enrolled')" style="">Click Here &raquo;</a>

                    <span style="display:none; width:62%; float:left; font-size:105%; font-style:italic; borderX:red 1px solid">
                        If you need assistance completing<br />this form call 1-844-441-4422
                    </span>
                </p>
            </div>
        </div>
    </div>
    <div style="clear:both"></div>

    <div runat="server" visible="true" class="nex-mobile-100-perc" style="margin-top:40px; font-size:1.7em; width:30em; margin-left:auto; margin-right:auto; border:red 0px solid">
        <div class="nex-mobile-100-perc" style="float:left; width:17em; font-weight:bold">Program Enrollment Assistance:</div>
        <div style="float:left; ">1-844-441-4422</div>
        <div style="clear:both"></div>
        <span class="nex-mobile-100-perc" style="float:left; width:17em; font-weight:bold">Eligibility Assistance:</span>
        <span style="float:left; ">1-844-381-2327</span>
        <div style="clear:both"></div>
    </div>
<div runat="server" visible="true" class="" style="margin-top:25px; font-size:1.2em; color:maroon; text-align:center">
        <div runat="server" visible="false" style="margin-bottom:15px">
            Si necesita ayuda en español, llamen a 1-844-441-4422. Presione 2 para español.
        </div>
        <div runat="server" visible="false">
            Si ou bezwen palέ ak yon moun an Kreyòl Ayisyen relέ nimewo sa: 1-844-441-4422. Pέzέ 3 pou  Kreyòl Ayisyen.
        </div>
</div>
<div runat="server" visible="true" style="margin-top:40px; margin-bottom:0px; border-top:lightgray 1px solid; padding:20px 20px; font-size:1.55em; width:100%; text-align:center; color:#f24500">
    <span style="margin-right:10px">To file your required tax forms for 2021:</span><a class="btn btn-primary btn-default" style="background-color:#428bca; border:0px" onclick="AnaInsert('PreRegistration')" href="pre-registration.aspx">Click Here &raquo;</a>
</div>
<div runat="server" visible="true" style="margin-top:0px; margin-bottom:30px; border-top:lightgray 1px solid; border-bottom:lightgray 1px solid; padding:20px 20px; font-size:1.6em; width:100%; text-align:center; color:#1488ae">
    *Insurance Enrollment Assistance is provided by our partner <b>American Exchange</b>
</div>
<div style="font-size:1.3em; width:100%; text-align:left; margin-bottom:50px">
    <div style="margin-right:10px; margin-bottom:22px">    
        <span style="margin-right:10px">&raquo; Tutorial: How to complete the questionnaire:</span><a id="aVideoTutorial" onclick="AnaInsert('VideoTutorial')" class="btn btn-primary btn-default" style="background-color:orange; border:0px" target="_blank" href="https://youtu.be/S6Y3JiJvKRU">Click Here &raquo;</a>
    </div>
    
    <div style="margin-right:10px; margin-bottom:22px">
        <span style="margin-right:10px">&raquo; Eligible Health Insurance Plans:</span>
        <div runat="server" visible="false">
            <asp:DropDownList ID="ddCounty_Of_Residence" runat="server" style="border:orange 1px solid; padding:4px 7px; font-size:0.8em; border-radius:5px; margin-right:2px">
            </asp:DropDownList>
            <asp:LinkButton ID="lbtnViewPlans" runat="server" CssClass="btn btn-primary btn-default" style="background-color:orange; border:0px" OnClientClick="AnaInsert('Eligible Plans')" OnClick="lbtnViewPlans_Click">View County &raquo;</asp:LinkButton>
            <asp:Label ID="lblViewPlans" runat="server" Text="" style="font-size:0.9em; color:orangered" Visible="false"></asp:Label>   
            <span style="margin-left:5px; margin-right:5px">OR</span>
        </div>
        <a class="btn btn-primary btn-default" style="background-color:orange; border:0px" onclick="AnaInsert('Eligible Plans')" target="_blank" href="Content/Florida_Eligible_Plans_By_County.pdf">Click Here &raquo;</a>

        <a class="btn btn-primary btn-default" style="display:none; background-color:orange; border:0px" onclick="AnaInsert('Eligible Plans')" target="_blank" href="eligibleplans.aspx">View Plans &raquo;</a>
    </div>
    
    <div style="margin-right:10px; margin-bottom:22px">
        <span style="margin-right:10px">&raquo; Information regarding Medicare and Enrollment:</span>
        <a class="btn btn-primary btn-default" style="background-color:orange; border:0px" onclick="AnaInsert('Medicare')" target="_blank" href="https://www.medicare.gov/">Click Here &raquo;</a>
    </div>
    <div style="margin-right:10px; margin-bottom:22px">
        <span style="margin-right:10px">&raquo; Insurance Enrollment Outreach, Education and Technical Assistance Educational Materials:</span>
        <a class="btn btn-primary btn-default" style="background-color:orange; border:0px" onclick="AnaInsert('Educational Materials')" target="_blank" href="https://marketplace.cms.gov/outreach-and-education/already-enrolled.html">Click Here &raquo;</a>
    </div>
    <div style="margin-right:10px; margin-bottom:22px; display:none">
        <span style="margin-right:10px">&raquo; Assistance with understanding the “Explanation of Benefits”:</span><a class="btn btn-primary btn-default" onclick="AnaInsert('Explanation of Benefits')" style="background-color:orange; border:0px" target="_blank" href="https://marketplace.cms.gov/outreach-and-education/downloads/c2c-sample-explanation-of-benefits.pdf">Click Here &raquo;</a>
    </div>
    <div style="margin-right:10px; margin-bottom:22px">
        <span style="margin-right:10px">&raquo; Assistance with understanding the “Explanation of Benefits”:</span><a class="btn btn-primary btn-default" onclick="AnaInsert('Explanation of Benefits')" style="background-color:orange; border:0px" target="_blank" href="https://marketplace.cms.gov/technical-assistance-resources/summary-of-benefits-fast-facts.pdf">Click Here &raquo;</a>
    </div>
    <div style="margin-right:10px; margin-bottom:0px">    
        <span style="margin-right:10px">&raquo; Glossary of Terms:</span><a id="aGossaryOfTerms" onclick="AnaInsert('Glossary of Terms')" class="btn btn-primary btn-default" style="background-color:orange; border:0px" target="_blank" href="https://targethiv.org/sites/default/files/file-upload/resources/ACE_Plain_Language_Glossary_082018.pdf">Click Here &raquo;</a>
    </div>
    <asp:HyperLink ID="HyperLink1" runat="server" Visible="false" ClientIDMode="Static" onclick="AnaInsert('gggg')">HyperLink</asp:HyperLink>
</div>

</asp:Content>
