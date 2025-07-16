<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="eligible-plans.aspx.cs" Inherits="Insurance_Enrollment_2024.eligible_plans" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">

        ul {
          list-style-image: url('img/ins2.png') !important;
        }

        li {
            margin-bottom:15px !important;
            padding-left:5px;
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
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">Eligible ACA Plans</h5>
                        <h1 style="display:none" "class="display-6">Select the appropriate year below to view the Eligible ACA Plans (by County)</h1>
                        <h1 class="display-6">Select the link below to view the Eligible ACA Plans (by County)</h1>
                    </div>

                    <div style="margin-top:40px; font-size:130%">
                        <ul style="margin-bottom: 0px; ">
                            <li>
                                <a target="_blank" href='Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2025.pdf?id='>Eligible ACA Health Insurance Plans for <b>2025</b></a>
                            </li>
                            <li>
                                <span runat="server" visible="false">For those that need insurance for 2024:</span>
                                <span runat="server" visible="true">For 2024 plans reference:</span>
                                <br />
                                <a target="_blank" href='Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2024.pdf?id='>Eligible ACA Health Insurance Plans for <b>2024</b></a>
                            </li>
                            <li style="display:none; font-style:italic">
                                For those that need insurance for 2023:<br />
                                <a target="_blank" href='Content/docs/Program_Approved_Plans_ACA_Marketplace_by_County_for_2023.pdf?id='>Eligible ACA Health Insurance Plans for <b>2023</b></a>
                            </li>
                        </ul>	

                                            

                    </div>

                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
