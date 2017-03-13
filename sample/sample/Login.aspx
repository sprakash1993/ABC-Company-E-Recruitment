<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" Theme="Theme2" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="sample.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type = "text/javascript" >
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
   </script>
    <style type="text/css">
        .auto-style1 {
            width: 48%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 118px;
            font-size: medium;
            height: 47px;
        }
        .auto-style4 {
            font-size: 26pt;
        }
        .auto-style5 {
            width: 118px;
            font-size: medium;
            height: 51px;
        }
        .auto-style6 {
            height: 51px;
            width: 174px;
        }
        .auto-style7 {
            height: 47px;
            width: 174px;
        }
        .auto-style8 {
            width: 174px;
        }
        .auto-style9 {
            font-size: x-large;
        }
    </style>
    <title>Login Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainbar">
        <div class="article"><center>
          <h1><span><strong class="auto-style4">Login Page</strong></span></h1>
            <div class="clr">
                <br />
            </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style5"><strong>UserName</strong></td>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox1" runat="server" MaxLength="20"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="Enter Username"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td class="auto-style3"><strong>Password</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"  alt="" ToolTip="Please Enter The password"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2" runat="server" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                
                
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;
            </td>
            <td class="auto-style8">
               
            </td>
        </tr>
    </table>
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Height="35px" Width="77px" />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="text-align: left" Text="Cancel" Height="35px" Width="74px" />
                             </center><br />
</div></div>
    <div class="sidebar">
        <div class="gadget">
          <h1 class="auto-style9"><span style="font-size:24pt">Users</span></h1>
          <div class="clr"></div>
          <ul class="sb_menu" style="font-size: medium">
            <li><a href="#">HR Recruitment Officer</a></li>
            <li><a href="#">BGC Administrator</a></li>
            <li><a href="#">Unit Head</a></li>
            <li><a href="#">Employees</a></li>
          </ul><br />
        </div>
       
      </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <ul>
          <li><a href="Home.aspx">Home</a></li>
          <li class="active"><a href="Login.aspx">Login</a></li>
        </ul>  
</asp:Content>
