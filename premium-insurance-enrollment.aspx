<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="premium-insurance-enrollment.aspx.cs" Inherits="Insurance_Enrollment_2024.premium_insurance_enrollment" %>
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

                </script>

    <style type="text/css">

            .sep_verb1 {
                width:90%; 
                font-size:75%;
            }

    </style>

<div style="padding:10px 20px; text-align:center; background-color:#EA5276; font-size:130%">
<a runat="server" id="aProgramRequirements1" style="color:#fff !important">** Important Changes ** Before completing the form, please <u>READ</u> before enrolling.</a>
<a runat="server" visible="false" id="a1" style="color:#fff !important">** Important Changes starting 2024 ** Before completing the form, please <u>READ</u> before enrolling.</a>
</div>	
	
    <div class="container-fluid py-5" style="min-height:40em">
        <div class="container">
            <div class="row gx-5">
               
			   <div class="col-lg-8">
                    <div class="mb-4">
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">I want Insurance Premium Assistance</h5>
                        <h1 runat="server" visible="false" class="display-6">Select Year and County of Residence below:</h1>
                        <h1 runat="server" visible="true" class="display-6">Select County of Residence below:</h1>
                    </div>

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
                                <span style="float:left; margin-right:10px; margin-top:-4px; font-weight:bold; font-size:1.2em; color:#000; borderX:red 1px solid; padding:0px !important">&#10112;</span>
                                <span runat="server" visible="false" style="float:left; margin-right:10px; color:#4a4a4a"><span style="color:#1871c9">Select Year:</span></span>
                                    <asp:RadioButtonList ID="rblAreYouAnAgent" runat="server" Visible="false" RepeatLayout="Flow" RepeatDirection="Horizontal" style="floatX:left; colorX:#217CB8; font-weight:bold; color:orangered; cursor:pointer">
                                       <asp:ListItem Value="2025">&nbsp;2025&nbsp;&nbsp;</asp:ListItem>
                                       <asp:ListItem Value="2024">&nbsp;2024</asp:ListItem>
                                   </asp:RadioButtonList>
                                <span runat="server" visible="false" style="float:left; border:#1871c9 1px solid; border-radius:4px; padding:3px 8px; margin-top:-5px; color:#4a4a4a">
                                    <asp:CheckBox ID="cb2025" runat="server" CssClass="BigCheck1" style="float:left; margin-top:1px; cursor:pointer !important" onchange="ToggleCheckedYears('cb2025')" Text="&nbsp;2025&nbsp;&nbsp;&nbsp;" />
                                    <asp:CheckBox ID="cb2024" runat="server" Visible="true" CssClass="BigCheck2" style="float:left; margin-top:1px; cursor:pointer" onchange="ToggleCheckedYears('cb2024')" Text="&nbsp;2024" />
                                </span>
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
                                <span style="float:left; width:2%" class="res-small-noXX">*</span><span style="float:left; width:98%">Select <b>2025</b> to access the <b>2025 Open Enrollment</b> form <i>(for a January 1st, 2025 policy)</i> which will be available through December 15, 2024.</span>
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


                        </div>                   




                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
