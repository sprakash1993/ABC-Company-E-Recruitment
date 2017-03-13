<%@ Page Title="BGC Schedule" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" Theme="Theme2" CodeBehind="BGCTestSchedule.aspx.cs" Inherits="sample.BGCTestSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            
        }
        .auto-style3 {
            width: 141px;
        }
        .auto-style4 {
            width: 118px;
            float:right;
        }
        .auto-style5 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><center>
    <div class="mainbar">
        <div class="article">
    <h1><span><strong class="auto-style5">Add BGC Schedule</strong></span></h1>
      <p style="text-align:right; color: #FF0000;">All * Fields are mandatory</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">
                     

                <asp:Label ID="Label1" runat="server" Text="Administrator ID"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="AdministratorID" DataValueField="AdministratorID">
                    
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" SelectCommand="SELECT [AdministratorID] FROM [BGCAdministrator]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Administrator ID" ControlToValidate="DropDownList1" InitialValue="Select"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label2" runat="server" Text="From Date"></asp:Label>
                <asp:Label ID="Label11" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Date" ToolTip="Enter future date"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" runat="server" ErrorMessage="Enter Date." ControlToValidate="TextBox1" SetFocusOnError="True"></asp:RequiredFieldValidator>
               <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1"  ErrorMessage="From Date should be within one month from now."></asp:RangeValidator>

            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label3" runat="server" Text="To Date"></asp:Label>
                <asp:Label ID="Label12" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Date" ToolTip="Enter future date"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" runat="server" ErrorMessage="Enter Date." ControlToValidate="TextBox2" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator2" Display="Dynamic" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter valid date." SetFocusOnError="True" ></asp:RangeValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" Display="Dynamic" ControlToCompare="TextBox1" ControlToValidate="TextBox2" ErrorMessage="To date should be greater than From date." Operator="GreaterThan" Type="Date"></asp:CompareValidator>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Height="31px" Width="89px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</div><br /><br /><br /></div></center>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <ul>
          <li ><a href="Home_HR.aspx">Home</a></li>
          <li><a href="#">BGC Admin Details</a><div class="submenu"><ul>
                <li><a href="BGCAdmin.aspx"><small>Add BGC Admin</small></a><a href="BGCAdmin_View.aspx"><small>Display all BGC Admin</small></a></li>
                
            </ul></div>

          </li>          
          
        <li ><a href="#">BGC Schedule Details</a>
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