<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default_test3.aspx.cs" Inherits="Insurance_Enrollment_2024.default_test3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <script language="javascript" type="text/javascript">

            function ToggleCheckedYears(obj) {
                //alert(obj.id);
                //alert(obj.checked);

                var dd1 = document.getElementById('<%: cb2024.ClientID %>');
                var dd2 = document.getElementById('<%: cb2025.ClientID %>');

                $(dd1).parent().css("color", "#4a4a4a");
                $(dd2).parent().css("color", "#4a4a4a");

                if (obj == 'cb2024') {
                    if (dd1.checked) {
                        dd2.checked = false;
                        $(dd1).parent().css("color", "#f26202");
                    }
                    else {
                        dd1.checked = true;
                        $(dd1).parent().css("color", "#f26202");
                    }
                }
                else if (obj == 'cb2025') {
                    if (dd2.checked) {
                        dd1.checked = false;
                        $(dd2).parent().css("color", "#f26202");
                    }
                    else {
                        dd2.checked = true;
                        $(dd2).parent().css("color", "#f26202");
                    }
                }

                //dd1.checked = false;
                //dd2.checked = false;


            }

            function closeMessage() {

                var messageBox = document.getElementById('<%: divMessage.ClientID %>');
                        messageBox.style.display = 'none';
            }


        </script>

    <style type="text/css">

        .nex-text-center {
          text-align: center;
        }

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

        .rounded {
            border-radius: 10px !important;
        }

        @media (max-width: 767.98px) {

            .nex-res-small-100 { width: 100% !important; }

            .nex-text-center {
              text-align: left;
            }

            .nex-left-side {
                float:none !important;
                margin-right:0px !important;

                 width:100% !important;

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

            .sep_verb1{
                width:90% !important; 
                font-size:75%;
            }
        }

        @media (max-width: 590px) {

            .res-small-no{
                display:none;
            }
            .nex-recertify {
                width:94% !important;
            }
            .nex-left-sideXX a {
                width:94% !important;
                padding-left:20px !important;
                padding-right:20px !important;

            }
            .nex-left-side  {
                width:100% !important;
                padding-left:20px !important;
                padding-right:20px !important;


            }

            .miamidade2
            {
                width:94% !important;
            }

            .sep_verb1{
                width:90% !important; 
                font-size:75%;
            }
        }

        @media (min-width: 767.99px) and (max-width: 991.98px) {

            .nex-res-small-100 { width: 100% !important; }

            .nex-text-center {
              text-align: left;
            }
            .nex-left-side {
                float:none !important;
                 width:100% !important;
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

            .sep_verb1{
                width:90% !important; 
                font-size:75%;
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


            .sep_verb1{
                width:95% !important; 
                font-size:75%;
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

            .sep_verb1{
                width:95% !important; 
                font-size:75%;
            }
        }

        .mb-md-4 {
            margin-bottom:2.7rem !important;
        }


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
        .back-rgba-opacity-3:hover {
            background: rgba(255, 255, 255, 1) !important;
        }
        .back-rgba-opacity-3:hover a {
            color:#fffc96 !important;
        }
        .back-rgba-opacity-4:hover {
            background: rgba(225, 236, 245, 1) !important;
            border-bottom:darkgrey 2px solid !important;
            border-right:darkgrey 2px solid !important;
        }

        .aLightGreen:hover{
            color:#e4f5f0 !important;
        }
        .aLightYellow:hover, .aLightYellow > a:hover, .aLightYellow > span:hover {
            color:#fff399 !important;
            opacity:1.0 !important;
            text-shadowX: 0px 0px;

        }
        

        /* Tabs - Begin */

* {
  box-sizing: border-box;
}





mainXXX {
  max-width: 801px;
  margin: auto;
}


.tabs {
    width: 53em;

  display: flex;
  flex-wrap: wrap;
  marginX: 0 auto 20px;
  border-radius: 10px 10px 0 0;


}

.radiotab {
  position: absolute;
  opacity: 0;
        

}

.label {
  widthX: 100%;
  paddingX: 12px 10px;
  padding: 8px 10px 3px 10px;
  backgroundX: #e5e5e5;
        background: rgba(229, 229, 229, .80);

  cursor: pointer;
  font-weight: bold;
  font-size: 23px;
  color: #7f7f7f;
  transition: background .3s, color .3s;
  border: none;
  border-radius: 0;
  text-align: center;
}

.label:hover {
  background: #d8d8d8;
}



.radiotab:checked + .label {
  backgroundX: #fff;
        background: rgba(255, 255, 255, .80);

  color: #000;
  border-topX: solid 2px #000;
  border-leftX: solid 2px #000;
  border-right: solid 1px #000;
  border-bottom: none;
}

.panel {
  display: none;
  padding: 15px 15px 15px 15px;
  backgroundX: #fff;
      background: rgba(255, 255, 255, .80);

  widthX: 100%;
  border-leftX: solid 2px #000;
  border-bottomX: solid 2px #000;
  border-rightX: solid 2px #000;

  border-bottom-left-radius:10px;
    border-bottom-right-radius:10px;
    border-top-right-radius:0px;

    width:100%;
}


.radiotab:checked + .label + .panel {
  display: block;

}

@media (min-width: 600px) {
  .panel {
    order: 99;
  }

  .label {
    widthX: 33.33%;
    width: 50%;
    border-radius: 10px 10px 0 0;
    border-bottom: solid 1px #000;
  }

}

        /* Tabs - End */



.BigCheck1 label, .BigCheck2 label
{
    cursor:pointer;
}

.BigCheck1 input, .BigCheck2 input
{
    display: inline;
    padding:0;
    margin:0px;
    padding-right:5px;
    height: 0.75em;
    width: 0.75em;   

        cursor:pointer;

}

.BigCheck1x {
    color:#1871c9;
}
.BigCheck2x {
    color:#1871c9;
}

.nex-go:hover {
    background-color:#edba5a !important; 
    border-right:black 1px solid !important; 
    border-bottom:black 1px solid !important;
}

            .sep_verb1 {
                width:95%; 
                font-size:75%;
            }

    </style>

    <asp:Label ID="lblIP_Address" runat="server" Text="" ClientIDMode="Static" style="display:none"></asp:Label>


        <div runat="server" id="divMessage" visible="false" style="z-index:9999; position:fixed; top:50%; left: 50%; transform: translate(-50%, -50%); background-color:#fffcde; box-shadowX: inset 0 3px 5px rgba(0, 0, 0, 0.125); box-shadow: 6px 6px rgba(74, 74, 74, 0.5); border-radius:10px; color:#000; width:400px; padding:20px 30px">
            <div style="position:relative; font-size:115%">
                <asp:Image ID="Image2" onclick="closeMessage()" runat="server" ImageUrl="~/img/close3.png" style="position:absolute; top:-30px; right:-42px; z-index:999999; opacity:0.9; cursor:pointer" />
                <div style="color:orangered; font-weight:bold; margin-bottom:5px; font-size:110%">Attention:</div>
                <div runat="server" id="divMessageContent"></div>
            </div>
        </div>

    <div style="display:none; padding:5px 20px; text-align:center; background-color:#eb576f; color:#fff">
<a>** Important Changes for 2024 ** Before completing the form, please <u>read</u> before enrolling.</a>
</div>



    <!-- Hero Start -->
    <div class="container-fluid bg-primary py-5 mb-5 nex-mb-5 hero-header" style="borderX:red 1px solid; padding-bottom:0px !important; padding-left:0px; padding-right:0px">
        <div class="container py-5X"  style="borderX:green 1px solid; padding-bottom:0px !important; padding-top:20px; padding-bottom:40px !important; max-widthX:1450px !important">
            <div class="row justify-content-start" style="borderX:red 1px solid; padding-bottom:0px !important">
                <div class="col-lg-10 nex-text-center text-lg-start " style="width:100%">
                    <div style="floatX:left">



                        <h5 class="d-inline-block text-primaryXX nex-text-primary text-uppercase border-bottom border-2" style="display:none !important; border-color: rgba(256, 256, 256, .3) !important; font-size:1.8em">Welcome To The Premium Assistance Program</h5>
					    <h5 runat="server" visible="false" class="d-inline-block text-primaryXX nex-text-primary text-uppercase border-bottom border-2" style="border-color: rgba(256, 256, 256, .3) !important; font-size:1.8em">Welcome To The Premium Plus Insurance Program</h5>					
					    <h5 class="d-inline-block text-primaryXX nex-text-primary text-uppercase border-bottom border-2" style="border-color: rgba(256, 256, 256, .3) !important; font-size:1.75em">Welcome To The Insurance Premium Assistance Program</h5>					
                        
                        <h1 runat="server" visible="false" class="display-1 text-white mb-md-4">To receive benefits including payments of monthly health insurance premiums and medications copayments participants must comply with the following requirements</h1>
					    <h1 runat="server" visible="false" class="display-1 text-white mb-md-4" style="font-sizeX:3em; text-shadowX: -1px 0 #606162, 0 1px #606162, 1px 0 #606162, 0 -1px #606162; ">To receive <span class="iconscontainer" style="text-decoration:underline; cursor:help"><a runat="server" id="aProgramRequirements1" style="color:inherit">benefits</a><span class="spanToolTip spanToolTipWidth">Benefits include payments of monthly health insurance premiums and medication copayments.<br /><span style="color:orangered">Click to view the new requirements</span></span></span>, participants must<br />comply with the program <span class="iconscontainer" style="text-decoration:underline; cursor:pointer"><a runat="server" id="aProgramRequirements2" style="color:inherit">requirements</a><span class="spanToolTip " style="color:orangered">Click to view the new requirements</span></span></h1>
                        <h1 class="display-1 text-white mb-md-4" style="font-sizeX:3em; text-shadowX: -1px 0 #606162, 0 1px #606162, 1px 0 #606162, 0 -1px #606162; line-height:110% ">To receive benefits, please carefully<br />read all the <span class="aLightYellow"><a  href="program-requirements.aspx" style="colorX:#e8faf6; color:#fff; text-decoration:underline; margin-right:8px; ">program requirements</a><span style="opacity:0.5; font-size:80%">&#10095;&#10095;</span></span></h1>

                    <div runat="server" id="divPreRegistration" visible="false" class="back-rgba-opacity nex-recertify display-2" style="font-size:1.4em; font-weight:bold; color:#fff; borderX:red 1px solid; border-radius:15px; margin-top:0px; padding:13px 20px; margin-bottom:20px; background: rgba(0, 0, 0, .08); widthX: 46.6em; width: 43.2em; text-align:center">
                        <a runat="server" id="aPreRegistration" visible="true" class="" style="font-sizeX:113%; background-colorX: #ff4d0d; border-colorX: #ff4d0d; color:#fff;  widthX:37.7em; flex-shrink: 1; margin-bottomX:20px; margin-left:0px !important">I want to <span style="color:yellow">PRE-REGISTER for a 2025</span> Marketplace / ACA Plan</a>
                    </div>



                    <div class="pt-2 nex-left-side" style="float:left; margin-bottom:5px; margin-right:0px; width:54em">
                        <div class="back-rgba-opacity-3xx" style="displayX:flex; background-color:#fff; border-radius:10px; padding:17px 30px 15px 25px; font-sizeX:1.4em; background: rgba(255, 255, 255, .80); backgroundX: rgba(250, 270, 70, .60);  ">

                            <h4 style="margin-bottom:20px; padding-bottom:10px; border-bottom:lightgrey 1px solid">
                                <span style="float:left"><span style="color:#f26202; margin-right:20px">Insurance Premium Assistance Enrollment: </span></span>

                                <span runat="server" id="spanMessage1" visible="false" style="float:right; margin-top:5px; color:red; font-size:70%; font-weight:normal; positionX:relative">
                                    <asp:Label ID="lblSpanMessage1" runat="server" Text=""></asp:Label>
                                </span>
                                <div style="clear:both"></div>
                            </h4>
                            <div style="clear:both"></div>
                            <h4 style="float:left; margin-right:20px">
                                <span style="float:left; displayX:block;  margin-right:10px; margin-top:-4px; font-weight:bold; font-size:1.2em; color:#000; borderX:red 1px solid; padding:0px !important">&#10112;</span>
                                <span runat="server" visible="false" style="float:left; margin-right:10px; color:#4a4a4a"><span style="color:#1871c9">Select Year:</span></span>
                                    <asp:RadioButtonList ID="rblAreYouAnAgent" runat="server" Visible="false" RepeatLayout="Flow" RepeatDirection="Horizontal" style="floatX:left; colorX:#217CB8; font-weight:bold; color:orangered; cursor:pointer">
                                       <asp:ListItem Value="2025">&nbsp;2025&nbsp;&nbsp;</asp:ListItem>
                                       <asp:ListItem Value="2024">&nbsp;2024</asp:ListItem>
                                   </asp:RadioButtonList>
                                <span runat="server" visible="false" style="float:left; border:#1871c9 1px solid; border-radius:4px; padding:3px 8px; margin-top:-5px; color:#4a4a4a">
                                    <asp:CheckBox ID="cb2025" runat="server" CssClass="BigCheck1" style="float:left; margin-top:1px; cursor:pointer !important" onchange="ToggleCheckedYears('cb2025')" Text="&nbsp;2025&nbsp;&nbsp;&nbsp;" />
                                    <asp:CheckBox ID="cb2024" runat="server" CssClass="BigCheck2" style="float:left; margin-top:1px; cursor:pointer" onchange="ToggleCheckedYears('cb2024')" Text="&nbsp;2024" />
                                </span>
                                <span runat="server" visible="false" style="float:left; font-size:90%; font-weight:normal">If you need new insurance or already have insurance select your county to proceed.</span>
                                <span runat="server" visible="false" style="float:left; font-size:90%; font-weight:normal">Do you need new insurance or already have insurance? Select your county to proceed.</span>
                                <span runat="server" visible="true" style="float:left; displayX:block; borderX:red 1px solid;  font-weight:normal" class="sep_verb1">Do you need new insurance or already have insurance and have not yet submitted the policy information to the premium assistance program?</span>

                                <div style="clear:both"></div>
                            </h4>
                            <div runat="server" visible="false" style="font-sizeX:60%; float:left; margin-top:2px; padding-top:0px; color:black">
                                To help guide you, please select the year and county below.
                            </div>
                            <div runat="server" id="divPreEnroll_Or_OpenEnroll_PreEnroll" visible="false" style="font-sizeX:60%; float:left; margin-top:-6px; padding-top:0px; color:black; font-size:88%; line-height:140%; color:#525252; width:55%" class="nex-res-small-100">
                                <span style="float:left; width:2%" class="res-small-noXX">*</span><span style="float:left; width:98%">Select <b>2025</b> to access the <b>Pre-Open Enrollment Easy Renewal</b> form, which will be available through October 31, 2024.</span>
                                <div style="clear:both"></div>
                            </div>
                            <div runat="server" id="divPreEnroll_Or_OpenEnroll_DelayOpenEnroll" visible="false" style="font-sizeX:60%; float:left; margin-top:-6px; padding-top:0px; color:black; font-size:88%; line-height:140%; color:#525252; width:55%" class="nex-res-small-100">
                                <span style="float:left; width:2%" class="res-small-noXX">*</span><span style="float:left; width:98%">Select <b>2025</b> to access the <b>Pre-Open Enrollment Easy Renewal</b> form, which will be available through November 3, 2024. <span style="font-weight:bold; color:red">** Due to required updates/maintenance, the 2025 Open Enrollment form will be available on November 4, 2024 **</span></span>
                                <div style="clear:both"></div>
                            </div>
                            <div runat="server" id="divPreEnroll_Or_OpenEnroll_OpenEnroll" visible="false" style="font-sizeX:60%; float:left; margin-top:-6px; padding-top:0px; color:black; font-size:88%; line-height:140%; color:#525252; width:55%" class="nex-res-small-100">
                                <span style="float:left; width:2%" class="res-small-noXX">*</span><span style="float:left; width:98%">Select <b>2025</b> to access the <b>2025 Open Enrollment</b> form <i>(for a January 1st, 2025 policy)</i> which will be available through December 15, 2024. <span style="display:none; font-style:italic">If you have Employer or COBRA coverage select either year.</span></span>
                                <div style="clear:both"></div>
                            </div>
                            <div runat="server" id="divSpecialEnrollment" visible="false" style="font-sizeX:60%; float:left; margin-top:-6px; padding-top:0px; color:black; font-size:88%; line-height:140%; color:#525252; width:55%" class="nex-res-small-100">
                                <span style="float:left; width:2%" class="res-small-noXX">*</span><span style="float:left; width:98%">Select <b>2025</b> to access the <b>2025 Open Enrollment</b> form <i>(for a January 1st, 2025 policy)</i> which will be available through December 15, 2024. <span style="display:none; font-style:italic">If you have Employer or COBRA coverage select either year.</span></span>
                                <div style="clear:both"></div>
                            </div>
                            <div style="clear:both"></div>

                            <h4 class="mb-3" style="margin-bottom:0px !important; padding-bottom:0px; margin-top:10px">
                                <span style="float:left; margin-right:10px; margin-top:2px; font-weight:bold; font-size:1.2em; color:#000; borderX:red 1px solid; padding:0px !important">&#10113;</span>
                                <span style="float:left; margin-right:10px; margin-top:5px; color:#4a4a4a"><span style="color:#1871c9">Select County of Residence:</span></span>
                                <span runat="server" visible="false" style="opacity:0.3; float:left; margin-right:10px; margin-top:5px">&#10095;&#10095;</span>
                                <span style="float:left">
                                    <asp:DropDownList ID="ddCounty1" runat="server" style="float:left; cursor:pointer; border:#1871c9 1px solid; padding:6px 8px; border-radius: 4px; width:14em; font-size:85%; widthX: 100%; margin-bottom: 10px; margin-right:10px">
                                        </asp:DropDownList>

                                    <asp:LinkButton ID="lbtnPremAssistGo" runat="server" CssClass="nex-go"  style="float:left; margin-top:0px; background-color:#f2c879; padding: 5px 20px; border-right:darkgrey 1px solid; border-bottom:darkgrey 1px solid; border-radius:4px; text-decoration:none !important" onclick="lbtnPremAssistGo_Click">
                                        <span style="floatX:left">GO </span><span style="opacity:0.3; floatX:left; margin-rightX:10px; margin-topX:0px">&#10095;&#10095;</span>
                                    </asp:LinkButton>

                                    <div style="clear:both"></div>
                                </span>
                                <div style="clear:both"></div>

                            </h4>




                            <div style="clear:both"></div>
                            <h4 runat="server" id="H1" visible="false" class="mb-3">
                                Are you requesting Part A Wrap Around Services?
                            </h4>
                            <div style="display:none; font-sizeX:60%; margin-top:0px; padding-top:0px; color:black">
                                If you are happy with your current plan, here we explain the benefits of preregistering and what they should expect...
                            </div>
                            <div style="clear:both"></div>

                        </div>

                    </div>

                    <div class="pt-2 nex-left-side" style="float:left; margin-bottom:15px; margin-rightX:13px; width:54em">
                        <div class="back-rgba-opacity-3" style="displayX:flex; background-color:#fff;  border-radius:10px; padding:20px 30px; font-sizeX:1.4em; background: rgba(255, 255, 255, .60); backgroundX: rgba(250, 270, 70, .60); ">
                            <a href="enrollment-verification.aspx" style="text-decoration:none">
                                <h4 class="mb-3" style="margin-bottom:0px !important; padding-bottom:0px">Recently renewed your <span style="color:#f26202">Program Eligibility?</span> Premium Assistance Re-enrollment <span style="opacity:0.3">&#10095;&#10095;</span></h4>
                                <h4 runat="server" visible="false"  class="mb-3" style="margin-bottom:0px !important; padding-bottom:0px">Have you recently renewed your <span style="color:#f26202">Program Eligibility?</span> Verify your coverage now <span style="opacity:0.3">&#10095;&#10095;</span></h4>
                                <div runat="server" visible="false" style="font-sizeX:60%; margin-top:0px; padding-top:0px; color:black">
                                    When you renew your program eligibility you need to confirm that you want to continue with premium assistance.
                                </div>
                                <div runat="server" visible="false" style="font-sizeX:60%; margin-top:0px; padding-top:0px; color:black">
                                    If your eligibility expired or suspended you need to confirm that you want to continue with premium assistance.
                                </div>
                                <div style="font-sizeX:60%; margin-top:0px; padding-top:0px; color:black">
                                    If your eligibility expired or was suspended you must confirm that you want to continue with premium assistance.
                                </div>
                            </a>


                        </div>

                    </div>
                    <div style="clear:both"></div>



                    <div style="clear:both"></div>


<div class="tabs" runat="server" visible="false">
    <input class="radiotab" name="tabs" tabindex="1" type="radio" id="tabone" checked="checked">
    <label class="label" for="tabone">Insurance for <span style="color:#d45328">2025</span></label>
    <div class="panel" tabindex="1">

        <div class="pt-2 nex-left-side" style="float:left; padding-top:0px !important; margin-bottomX:15px; margin-rightX:13px; width:100%">
            <div class="back-rgba-opacity-3" style="displayX:flex; background-color:#fff; border-radius:10px; padding:20px 30px 10px 30px; border:lightgray 1px solid; font-sizeX:1.4em; background: rgba(255, 255, 255, .60); backgroundX: rgba(250, 270, 70, .60); ">
                <h4 class="mb-3" style="margin-bottom:0px !important; padding-bottom:0px">
                    <span style="float:left; margin-right:10px; margin-top:5px; color:#b8431c">To begin, select your County of Residence</span>
                    <span style="opacity:0.3; float:left; margin-right:10px; margin-top:5px">&#10095;&#10095;</span>
                        <asp:DropDownList ID="ddCounty1_Orig" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddCounty1_SelectedIndexChanged" style="float:left; border:#d45328 1px solid; padding:6px 8px; border-radius: 4px; width:14em; font-size:85%; widthX: 100%; margin-bottom: 10px;">
                        </asp:DropDownList>
                </h4>
                <div style="clear:both"></div>
                <h4 runat="server" id="divCount1_MiamiDade" visible="false" class="mb-3">
                    Are you requesting Part A Wrap Around Services?
                </h4>
                <div style="display:none; font-sizeX:60%; margin-top:0px; padding-top:0px; color:black">
                    If you are happy with your current plan, here we explain the benefits of preregistering and what they should expect...
                </div>
                <div style="clear:both"></div>
            </div>

        </div>
            <div style="clear:both"></div>

    </div>
    <input class="radiotab" tabindex="1" name="tabs" type="radio" id="tabtwo">
    <label class="label" for="tabtwo">Insurance for <span style="color:dodgerblue">2024</span></label>
    <div class="panel" tabindex="2">

		<div class="pt-2 nex-left-side" style="float:left; padding-top:0px !important; margin-bottomX:15px; margin-rightX:13px; ">
            <div class="back-rgba-opacity-3" style="displayX:flex; background-color:#fff; border-radius:10px; padding:20px 30px 10px 30px; border:lightgray 1px solid; font-sizeX:1.4em; background: rgba(255, 255, 255, .60); backgroundX: rgba(250, 270, 70, .60); ">
                <h4 class="mb-3" style="margin-bottom:0px !important; padding-bottom:0px">
                    <span style="float:left; margin-right:10px; margin-top:5px; color: #1c77b8">To begin, select your County of Residence</span>
                    <span style="opacity:0.3; float:left; margin-right:10px; margin-top:5px">&#10095;&#10095;</span>
                        <asp:DropDownList ID="ddCounty2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddCounty2_SelectedIndexChanged"  style="float:left; border:dodgerblue 1px solid; padding:6px 8px; border-radius: 4px; width:14em; font-size:85%; widthX: 100%; margin-bottom: 10px;">
                        </asp:DropDownList>
                </h4>
                 <div runat="server" id="divCount2_MiamiDade" visible="false">
                    Are you requesting Part A Wrap Around Services?
                </div>              
                <div style="display:none; font-sizeX:60%; margin-top:0px; padding-top:0px; color:black">
                    If you are happy with your current plan, here we explain the benefits of preregistering and what they should expect...
                </div>
                <div style="clear:both"></div>
            </div>

        </div>
            <div style="clear:both"></div>
        
    </div>

  </div>




                    <div runat="server" visible="false">

                        <div runat="server" visible="true" class="back-rgba-opacity nex-recertify display-2" style="font-size:1.4em; font-weight:bold; color:#fff; borderX:red 1px solid; border-radius:15px; margin-top:0px; padding:16px 20px; margin-bottom:12px; background: rgba(0, 0, 0, .10); width: 43.2em; text-align:center">
                             <span runat="server" visible="false" style="right:5px; color:#fff; font-size:1.2em">&#187;</span>
                            <a  runat="server" id="aRecertified" href="enrollment-verification.aspx" style="color:#fff; text-decorationX:underline">Have you recently renewed your <span style="color:yellow">Program Eligibility?</span> Verify your coverage for 2024</a>
                        </div>
                        
                            <div class="pt-2 nex-left-side" style="float:left; margin-right:13px">
                                <div style="display:flex; ">
                                    <a runat="server" id="aPreRegistration_Orig" visible="false" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; background-color: #ff4d0d; border-color: #ff4d0d; color:#fff;  width:37.7em; flex-shrink: 1; margin-bottom:20px; margin-left:0px !important">I want to PRE-REGISTER for a 2024 Marketplace / ACA Plan</a>
                                    <a runat="server" id="aEnrollmentAssistance" visible="false" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; background-color: #ff4d0d; border-color: #ff4d0d; color:#fff;  width:41.6em; flex-shrink: 1; margin-bottom:20px; margin-left:0px !important">OPEN ENROLLMENT: I need an Insurance Policy for 2024</a>
                                    <a runat="server" id="aEnrollmentAssistanceCY" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; background-color: #ff4d0d; border-color: #ff4d0d; color:#fff;  width:41.6em; flex-shrink: 1; margin-bottom:20px; margin-left:0px !important">SPECIAL ENROLLMENT: I need an Insurance Policy for 2024</a>

                                </div>
                                <div style="display:flex; ">
                                <a runat="server" visible="false" id="aEnrollmentAssistanceCY_Orig" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">I need an Insurance Policy for 2023</a>
                                <a runat="server" visible="false" id="a1" class="btn btn-outline-lightXX nex-btn-light rounded-pill py-md-3 px-md-5 mx-2" style="font-size:110%; margin-left:0px !important">I already have an Insurance Policy</a>
                                <a runat="server" id="aExistingPolicy" class="btn btn-lightXX nex-btn-light nex-btn-light-left rounded-pill py-md-3 px-md-5 mx-2" style="font-size:113%; margin-left:0px !important;width:41.6em; flex-shrink: 1; ">I already have Insurance for 2024 (ACA/Employer/COBRA)</a>
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
                        <img runat="server" visible="false" class="position-absoluteXX w-100XX h-100xx rounded" src="img/office4.png" style="object-fitXX: cover; width:240px">

                        <div class="back-rgba-opacity-4" style="displayX:flex; width:fit-content; margin-left:auto; margin-right:auto; background-color:rgba(225, 235, 242,0.7); margin-top:0px; margin-bottom:40px; border-bottom:darkgrey 1px solid; border-right:darkgrey 1px solid; border-radius:10px; padding:20px 30px; font-sizeX:1.4em; backgroundX: rgba(255, 255, 255, .60); backgroundX: rgba(250, 270, 70, .60); ">
                            <a runat="server" id="aMedicare3" style="text-decoration:none">
                                <h4 class="mb-3" style="margin-bottom:0px !important; padding-bottom:0px">Need help with <span style="color:#378274">Medicare?</span><br />Go to Medicare & Enrollment <span style="opacity:0.3">&#10095;&#10095;</span></h4>
                                <div style="font-sizeX:60%; margin-top:0px; padding-top:0px; color:black">
                                    Medicare Assessment Form 2024
                                </div>
                            </a>
                        </div>
                        <img class="position-absoluteXX w-100XX h-100xx rounded" src="img/office4.png" style="object-fitXX: cover; width:240px">

                        <a runat="server" visible="false" id="a3" class="nex-bigicon-link" target="_blank" >               
                            <div class="service-item bg-light rounded d-flex flex-column align-items-center justify-content-center text-center" style="background-colorX:#EFF5F9 !important;  background-color:rgba(230, 236, 240,1.0) !important">
                                <div runat="server" visible="false" class="service-icon mb-4">
                                    <i class="fa fa-2x icon-medicare text-white"></i>
                                </div>
                                <h4 class="mb-3">Medicare and Enrollment</h4>
                                <p class="m-0" style="display:none">Call American Exchange: 1-833-243-0496 or call your Agent/Broker</p>
                                <p class="m-0" style="displayX:none">Medicare Assessment Form 2024</p>
                                <a runat="server" id="a4" class="btn btn-lg btn-primary rounded-pill" target="_blank">
                                    <i class="bi bi-arrow-right"></i>
                                </a>
                            </div>                
                        </a>


                    </div>
                </div>
                <div class="col-lg-7">
                    <div class="mb-4">
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">About The Program</h5>
                        <h1 runat="server" visible="false" class="display-6">Insurance Benefit Management Services</h1>
                        <h1 class="display-6">Insurance Premium Assistance Services</h1>
                    </div>
                    <p>

						<b>Participants MUST Enroll In Premium Assistance Annually.</b> Enroll online at https://enroll.brhpc.org, over the telephone by calling 1-844-441-4422 or <span> <a style="text-decoration:underline" target="_blank" href="Content/docs/CountyHealthDepartmentContactList.pdf">calling your County Health Department</a></span>. This is REQUIRED even if you enrolled with an agent/broker, navigator, case manager, etc.
						<div style="margin-top:10px;">Enrollment and reenrollment in the premium assistance program is required prior to each calendar year regardless of the type of insurance enrolled in, including marketplace/Affordable Care Act (ACA), employer sponsored insurance, or COBRA.</div>
						<div style="margin-top:10px; margin-bottom:15px; font-size:120%; color:#2681bd">Insurance Enrollment Assistance is provided by our partner <b>American Exchange</b></div>

                        <div style="margin-bottom:0px; font-size:115%; line-height:120% !important; color:#fc752b">For Agents, Brokers, Navigators, Certified Application Counselors, Assisters and Case Managers you can <b><a href="register.aspx" style="text-decoration:underline; color:#fc752b">Register Now</a></b> for resource access.</div>

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
                            <div class="nex-service-item bg-light text-center rounded-circleXX rounded py-4" style="padding:20px 40px 25px 40px !important">
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
                <h1 class="display-6XX" style="widthX:1000px !important; font-size:2.0rem">If you have any questions not addressed below, please <a class="nex-link-greyish" style="text-decoration:underline" href="#footer">contact us</a>.</h1>
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
