<%@ Page Title="Employee" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" Theme="Theme2" CodeBehind="Employee.aspx.cs" Inherits="sample.Employee1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 83%;
            height: 538px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            font-weight: 700;
        }
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style5 {
            width: 109px;
        }
        #Reset1 {
            width: 86px;
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><br /><br />
    <center><div class="mainbar">
        <div class="article"><center>
          <h1><span><strong class="auto-style4">Add Employee</strong></span></h1>
            <div class="clr">
                <br />
            </div>
            <p style="text-align:right; color: #FF0000;">All * Fields are mandatory</p>

    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label>
                <asp:Label ID="Label11" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox1" runat="server" MaxLength="30" ToolTip="Enter only alphabet"></asp:TextBox>
            </td>
            <td class="auto-style5"> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Enter Employee Name" ControlToValidate="TextBox1" SetFocusOnError="True"></asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ControlToValidate="TextBox1" ErrorMessage="Enter only alphabets " ValidationExpression="[a-zA-Z]*" SetFocusOnError="True"></asp:RegularExpressionValidator>
      </td>
                  </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="DOB"></asp:Label>
                <asp:Label ID="Label12" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" placeholder="mm/dd/yyyy" runat="server" TextMode="Date" ToolTip="Minimum age sholud be 18 years"></asp:TextBox>
            </td>
            <td class="auto-style5">  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Date of Birth" Display="Dynamic" ControlToValidate="TextBox2" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <%--<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Minimum age should be 18 years" Display="Dynamic" ControlToValidate="TextBox2" MinimumValue="12/31/1994" MaximumValue="12/31/1994"></asp:RangeValidator>--%>
             <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="Enter valid DOB(Age should be between 20 to 60)." Display="Dynamic" ControlToValidate="TextBox2" Type="Date" MinimumValue="01/01/1955" MaximumValue="01/01/1995" SetFocusOnError="True"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label7" runat="server" Text="Division"></asp:Label>
                <asp:Label ID="Label13" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="TextBox3" runat="server" Width="100px">
                    <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="Hyderabad"></asp:ListItem>
                    <asp:ListItem Value="Chennai"></asp:ListItem>
                    <asp:ListItem Value="Bangalore"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5"> <asp:RequiredFieldValidator InitialValue="Select" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select Division" ControlToValidate="TextBox3" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
                <asp:Label ID="Label14" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label10" runat="server" Text="DOJ"></asp:Label>
                <asp:Label ID="Label15" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox7" placeholder="mm/dd/yyyy" runat="server" TextMode="Date" ToolTip="Enter future date"></asp:TextBox>
            </td>
            <td class="auto-style5"> <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Date of Joining" Display="Dynamic" ControlToValidate="TextBox7" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator2" runat="server" Type="Date" ErrorMessage="DOJ should be a future date" Display="Dynamic" ControlToValidate="TextBox7"  SetFocusOnError="True"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label5" runat="server" Text="CTC"></asp:Label>
                <asp:Label ID="Label16" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox5" runat="server" MaxLength="6" ToolTip="Enter numericals only" ></asp:TextBox>
            </td>
            <td class="auto-style5"><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Display="Dynamic" ErrorMessage="Enter CTC" ControlToValidate="TextBox5" SetFocusOnError="True" ></asp:RequiredFieldValidator>
              <asp:RangeValidator ID="RangeValidator1" runat="server" Display="Dynamic" ControlToValidate="TextBox5" ErrorMessage="CTC should be between 150000 and 300000" MinimumValue="150000" MaximumValue="300000"></asp:RangeValidator>

            </td>
               
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Designation"></asp:Label>
                <asp:Label ID="Label17" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="TextBox6" runat="server" Width="100px">
                    <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="Manager"></asp:ListItem>
                    <asp:ListItem Value="SE"></asp:ListItem>
                    <asp:ListItem Value="ASE"></asp:ListItem>
                    <asp:ListItem Value="Clerk"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5"><asp:RequiredFieldValidator InitialValue="Select" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Select designation" ControlToValidate="TextBox6" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label8" runat="server" Text="Unit Head ID"></asp:Label>
                <asp:Label ID="Label18" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="100px">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>101</asp:ListItem>
                    <asp:ListItem>102</asp:ListItem>
                    <asp:ListItem>103</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Select unithead ID" ControlToValidate="DropDownList1" InitialValue="Select" SetFocusOnError="True" ></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label9" runat="server" Text="Project ID"></asp:Label>
                <asp:Label ID="Label19" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="100px">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>501</asp:ListItem>
                    <asp:ListItem>502</asp:ListItem>
                    <asp:ListItem>503</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5">  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Select Project ID" ControlToValidate="DropDownList2" InitialValue="Select" SetFocusOnError="True" ></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5">  &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="3">
                <asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="Submit" Width="120px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="Button2" runat="server" Height="32px" Width="120px" Text="Cancel" CausesValidation="False" OnClick="Button2_Click"></asp:Button> </td>
        </tr>
               
      
    </table>
        </center>
</div><br /><br /><br /></div>
  <br /><br /><br />

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