<%@ Page Title="Change Password" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LoginChange.aspx.cs" Inherits="sample.LoginChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 142px;
        }
        .auto-style2 {
            width: 180px;
        }
        .auto-style3 {
            width: 172px;
        }
        .auto-style4 {
            font-size: 26pt;
        }
         .auto-style5 {
            width: 118px;
            font-size: medium;
            height: 51px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainbar">
        <div class="article"><center>
          <h1><span><strong class="auto-style4">Change Password </strong></span></h1>
            <div class="clr">
                <br />
            </div>
            <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2"><asp:Label CssClass="auto-style5" ID="Label3" runat="server" Text="Old Password"></asp:Label></td>
            <td class="auto-style3"><asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Height="23px"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label CssClass="auto-style5" ID="Label1" runat="server" Text="New Password"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" Height="23px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label CssClass="auto-style5" ID="Label2" runat="server" Text="Confirm New Password"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Height="23px"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" ErrorMessage="Password doesn't match" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Height="30px" Width="77px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</center><br />
</div></div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <ul>
          <li><a href="Home.aspx">Home</a></li>
          <li class="active"><a href="LoginChange.aspx">Change Password </a></li>
        </ul>  
</asp:Content>
