<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ao-counties.aspx.cs" Inherits="Insurance_Enrollment_2024.ao_counties" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="padding:10px 20px; text-align:center; background-color:#EA5276; font-size:130%">
<a runat="server" id="aProgramRequirements1" style="color:#fff !important">** Important Changes ** Before completing the form, please <u>READ</u> before enrolling.</a>
<a runat="server" visible="false" id="a1" style="color:#fff !important">** Important Changes starting 2024 ** Before completing the form, please <u>READ</u> before enrolling.</a>
</div>	
	
    <div class="container-fluid py-5" style="min-height:40em">
        <div class="container">
            <div class="row gx-5">
               
			   <div class="col-lg-8">
                    <div class="mb-4" style="margin-bottom:20px">
                        <h5 runat="server" id="topMessage1" class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">I need to verify my coverage</h5>
                        <h2 runat="server" id="topMessage2" class="display-6X">I have recently renewed my program eligibility</h2>
                    </div>

                   
                    <b class="nex-text-secondary" style="font-size:110%">Need an insurance policy for <asp:Label ID="lblYear1" runat="server" Text="" style="color:#EA5276"></asp:Label>:</b>                    

                    <div class="pt-2" style="margin-bottom:35px">
                        <a runat="server" id="aDoorA" href="ae-forms.aspx?form=reenroll" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color:#f2c879 !important; border-color: #f2c879 !important; font-size:110%; margin-left:0px !important">
                            I need insurance for <asp:Label ID="lblYear2" runat="server" Text=""></asp:Label>
                        </a>			
                        <span class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
                    </div>

                    <b class="nex-text-secondary" style="font-size:110%">Already enrolled in an ACA, COBRA or Employer plan for <asp:Label ID="lblYear3" runat="server" Text="" style="color:#EA5276"></asp:Label>:</b>                    

                    <div class="pt-2">
                        <a runat="server" id="aDoorB" href="ae-forms.aspx?form=reenroll" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color:#f2c879 !important; border-color: #f2c879 !important; font-size:110%; margin-left:0px !important">
                            I already have insurance for <asp:Label ID="lblYear4" runat="server" Text=""></asp:Label>
                        </a>			
                        <span class="btn btn-lightXX nex-btn-goback rounded-pill py-md-3 px-md-5 mx-2" onclick="history.back()">Go Back</span>
                    </div>

                    <div runat="server" id="divBrowardCounty" visible="false" class="pt-2" style="margin-top:25px">
                        <b class="nex-text-secondary" style="font-size:120%; margin-right:5px; ">*For <span style="color:#EA5276 !important">Broward</span> County Health Department Only</b> <a runat="server" id="aBrowardDOH" href="ae-forms.aspx?form=browarddoh" class="btn btn-lightXX nex-btn-bright rounded-pill py-md-3 px-md-5 mx-2" style="background-color:#f2c879 !important; border-color: #f2c879 !important; font-size:100%; padding:6px 20px !important; margin-left:0px !important">
                            Go Here 
                        </a>	
                    </div>

                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
