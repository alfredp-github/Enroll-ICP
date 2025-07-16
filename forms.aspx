<%@ Page Title="" Language="C#" MasterPageFile="~/Site-Forms.Master" AutoEventWireup="true" CodeBehind="forms.aspx.cs" Inherits="Insurance_Enrollment_2024.forms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script lang="JavaScript">

        window.onload = function () {
            autoResize();
        };

        window.addEventListener('resize', () => { autoResize(); });

        function autoResize() {
               
            //var div_iframeElement = parent.document.getElementById('divIframe2');
            var div_iframeElement = document.getElementById('<%:divIframe2.ClientID%>');

            //var div_height = document.documentElement.clientHeight - 180;
            var div_height = document.documentElement.clientHeight - 251;
            div_iframeElement.style.height = div_height + "px";

            //var iframeElement = parent.document.getElementById('iframe2');
            var iframeElement = document.getElementById('<%:iframe2.ClientID%>');

            //var height = document.documentElement.clientHeight - 200;
            var height = document.documentElement.clientHeight - 230;
            iframeElement.style.height = height + "px";
        }
    </script>

    <div runat="server" id="divIframe2" class="container-fluid py-5X" style="min-heightX:40em; width: 80em; max-width:80%; margin-bottom:50px; padding-top:0px; border:lightgray 1px solid; border-bottom:0px; border-top:0px; border-right:0px">
        
        <iframe runat="server" name="iframe2" id="iframe2"  frameborder="0"  width="100%" height="500px" src="" ></iframe>   
        

    </div>

</asp:Content>
