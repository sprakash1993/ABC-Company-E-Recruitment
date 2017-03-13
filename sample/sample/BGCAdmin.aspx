<%@ Page Title="BGC Administrator" Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="BGCAdmin.aspx.cs" Inherits="sample.BGCAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 57px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><center>
     <div class="mainbar">
        <div class="article">
    <h1><span><strong style="font-size: x-large" >Add BGC Test Administrator</strong></span></h1>
    <br />
    <table>
        <tr>
            <td class="auto-style1">
    Select EmployeeID&nbsp;&nbsp;&nbsp;</td>
            <td class="auto-style1">
    <asp:DropDownList ID="DropDownList1" runat="server">
      
    </asp:DropDownList>
    &nbsp;</td>
            <td class="auto-style1">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Administrator" ControlToValidate="DropDownList1" ForeColor="Red" InitialValue="Select"></asp:RequiredFieldValidator>
            </td>
            </tr>
    <tr>
        <td colspan="3" style="text-align: left">
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Height="31px" Width="86px" />
            </td>
        </tr>
    </table>
</div><br /><br /><br /></div></center>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <ul>
          <li ><a href="Home_HR.aspx">Home</a></li>
          <li><a href="#">BGC Admin Details</a><div class="submenu"><ul>
                <li><a href="BGCAdmin.aspx"><small>Add BGC Admin</small></a><a href="BGCAdmin_View.aspx"><small>Display all BGC Admin</small></a></li>
                
            </ul></div>

          </li>          
          
        <li><a href="#">BGC Schedule Details</a>
            <div class="submenu"><ul>
                <li><a href="BGCTestSchedule.aspx"><small>Add BGC Schedule</small></a><a href="BGCSchedule_Display.aspx"><small>Display BGC Schedule</small></a></li>
                
            </ul></div>
        </li>
       
        <li><a href="#">Employee Details</a>
        <div class="submenu"><ul>
                <li><a href="Employee.aspx"><small>Add Employee</small></a><a href="Employee_Edit.aspx"><small>View/Edit Employee</small></a></li>
                
            </ul></div>
         </li>
          <li><a href="Logout.aspx">Logout</a></li>
        </ul>  
</asp:Content>