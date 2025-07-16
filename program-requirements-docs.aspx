<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="program-requirements-docs.aspx.cs" Inherits="Insurance_Enrollment_2024.program_requirements_docs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">

        ul {
          list-style-image: url('img/document-1.png') !important;
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
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">Program Requirements</h5>
                        <h1 class="display-6">Insurance Premium Assistance Program Help Documentation</h1>
                    </div>
                    <div style="background-color: #b1d9e0; color:#000; font-size:120%; border-radius: 10px; padding:10px 20px; margin-bottom:20px">
                        
                        <span class="iconscontainer">
                            Click on the links below to view the documentation:
                        </span>
                    </div>
                    <div style="font-size:120%">

                        <ul runat="server" visible="true">
                            <li>
                                <a target="_blank" href="Content\docs\ACA_OpenEnrollment_2025_Flyer_English.pdf">Required Steps for Premium Assistance <i>(English)</i></a>
                            </li>
                            <li>
                                <a target="_blank" href="Content\docs\ACA_OpenEnrollment_2025_Flyer_Spanish.pdf">Required Steps for Premium Assistance <i>(Spanish)</i></a>
                            </li>
                            <li>
                                <a target="_blank" href="Content\docs\ACA_OpenEnrollment_2025_Flyer_Creole.pdf">Required Steps for Premium Assistance <i>(Creole)</i></a>
                            </li>


                        </ul>	


                    </div>


                </div>
			   
            </div>
        </div>
    </div>

</asp:Content>
