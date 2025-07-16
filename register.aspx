<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Insurance_Enrollment_2024.register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript">
            function NumOnly(evt) {

            //***********************************
            // Need to allow backspace
            //***********************************

            //Only allow numbers
            var theEvent = evt || window.event;
            var key = theEvent.keyCode || theEvent.which;
            key = String.fromCharCode(key);
            //var regex = /[0-9]|\./;
            var regex = /^[+-]?\d*\.?\d{0,9}$/;
            if (!regex.test(key)) {
                theEvent.returnValue = false;
                if (theEvent.preventDefault) theEvent.preventDefault();
            }
        }


    </script>

    <style type="text/css">

        ul {
          list-style-image: url('img/ins2.png') !important;
        }

        li {
            margin-bottom:15px !important;
            padding-left:5px;
        }




        .reg-form {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            /*box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);*/
            box-shadow: 0 1px 10px rgb(0 0 0 / 0.3);
            width: 300px;

            font-size: 1em !important;
            position: relative;

        }
        h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        label {
            display: block;
            margin-bottom: 5px;
        }
        input[type="text"],
        input[type="email"],
        input[type="tel"],
        input[type="password"] {
            width: 100%;
            padding: 5px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        input[type="submit"] {
            width: 100%;
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #45a049;
        }

        .btnGreen{
            width: 100%;
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .btnGreen:hover {
            background-color: #45a049;
        }


        .reg-form .tooltiptext {
            visibility: hidden;
            width: 220px;
            background-color: #ffffff;
            text-align: center;
            border-radius: 6px;
            border: 1px;
            padding: 5px 0;
            position: absolute;
            z-index: 1;
            bottom: 125%;
            left: 50%;
            margin-left: -60px;
            opacity: 0;
            transition: opacity 0.3s;
        }
    </style>


<div style="padding:10px 20px; text-align:center; background-color:#EA5276; font-size:130%">
<span runat="server" id="aProgramRequirements1" style="color:#fff !important"><b>Welcome</b> Agents, Brokers, Navigators, Counselors, Assisters and Case Managers</span>
</div>	

   <div class="container-fluid py-5" style="min-height:40em">
        <div class="container">
            <div class="row gx-5">
               
			   <div  class="col-lg-8">
                    <div class="mb-4" style="borderX:green 1px solid; margin-bottom:0px !important">
                        <h5 class="d-inline-block text-primary nex-text-secondary text-uppercase border-bottom border-5">Registration</h5>
                        <h1 class="display-6">Register to access resources</h1>
                    </div>
                   <div>
                       This site is for the Registration of Agents, Brokers, Navigators, Certified Application Counselors, Assisters and Case Managers. Registering will  provide you with important information regarding client’s Marketplace notices, client eligibility information, and programmatic notifications.
                   </div>
                    <div runat="server" id="divForm" style="float:left; margin-top:20px; margin-right:20px; font-size:130%" class="reg-form">

                        <div id="autotooltip">
                        <label for="fname">*Name:</label>
                        <input runat="server" type="text" id="fname" name="name" required>

                        <label for="ddRole">*Role:</label>
                        <asp:DropDownList ID="ddRole" runat="server" style="float:left; border:#ccc 1px solid; padding:6px 8px; border-radius: 4px; width: 100%; margin-bottom: 10px;">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem Value="1">Agent</asp:ListItem>
                            <asp:ListItem Value="2">Broker</asp:ListItem>
                            <asp:ListItem Value="3">Navigator</asp:ListItem>
                            <asp:ListItem Value="4">Certified Application Counselors</asp:ListItem>

                            <asp:ListItem Value="5">Assister</asp:ListItem>
                            <asp:ListItem Value="6">Case Manager</asp:ListItem>

                            <asp:ListItem Value="10">Dept. of Health</asp:ListItem>

                        </asp:DropDownList>
    
                        <label for="fname">Organization <i>(Optional)</i>:</label>
                        <input runat="server"  type="text" id="organization" name="name">

                        <label for="email">*Email:</label>
                        <input runat="server"  type="email" id="email" name="email" onfocus="javascript:document.getElementById('validate_email').style.display = 'none';" onblur="Validate_Email(this.value)" required>
                        <span class="tooltiptextX" id="validate_email" style="display:none; margin-top:-14px; margin-bottom:10px; padding:7px 9px 1px 9px; background-color:lightpink; color:#000; border-radius: 0 0 4px 4px; font-size:85%">Please enter a valid email address.</span>

                        <label for="phone">*Phone Number:</label>
                        <input runat="server"  type="tel" id="phone" name="phone" onfocus="javascript:document.getElementById('validate_phone').style.display = 'none';" onblur="Validate_Phone(this.value)"  required>
                        <span class="tooltiptextX" id="validate_phone" style="display:none; margin-top:-14px; margin-bottom:10px; padding:7px 9px 1px 9px; background-color:lightpink; color:#000; border-radius: 0 0 4px 4px; font-size:85%">Please enter a valid phone number.</span>

                        </div>
                        <div style="margin-top:10px">
                            <input type="submit" value="Register" runat="server" visible="false">
                            <asp:Button ID="btnSubmit" runat="server" CssClass="btnGreen" ValidationGroup="Group"  UseSubmitBehavior="false" OnClientClick="this.disabled='true'; this.value='Please Wait..';"
                                        ForeColor="White" onclick="btnSubmit_Click"  Text="Register" />                                            
                        </div>

                    </div>
                    <div runat="server" id="divFormMessage" visible="false" class="reg-form" style="float:left; color:red; margin-top:20px; font-size:130%; width: 250px; box-shadow: 0 1px 10px #fcaeb5" >

                    </div>
                   <div class="clearfix"></div>

                    <div runat="server" id="divFormSubmitted" visible="false" class="reg-form" style="margin-top:20px; font-size:1.2em !important; width: 430px; " >

                    </div>

                </div>
			   
            </div>
        </div>
    </div>

        <script type="text/javascript">

            function Validate_Email(obj) {
                //alert(obj);
                if (!isValidEmail(obj)) {
                    //e.preventDefault();
                    //alert('Please enter a valid email address.');
                    document.getElementById('validate_email').style.display = 'block';
                    //alert(valid.style.display);
                    //valid.style.display = 'block';
                    //alert(valid.style.display);
                    //return false;
                }
            }
            function Validate_Phone(obj) {
                if (!isValidPhone(obj)) {
                    document.getElementById('validate_phone').style.display = 'block';
                }
            }

            function isValidEmail(email) {
                // Use a regular expression to validate the email address
                const emailRegex = /^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/;
                return emailRegex.test(email);
            }
            function isValidPhone(email) {
                // Use a regular expression to validate the email address
                //alert(email);
                const emailRegex = /^(?:\+1)?\s?\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$/;
                //const emailRegex = /^(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$/;
                return emailRegex.test(email);
            }

        </script>

</asp:Content>
