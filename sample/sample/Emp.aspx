<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Emp.aspx.cs" Inherits="sample.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add Employee
    </h1>
    <p style="text-align:end">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * fields are mandatory</p>
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblName" runat="server" Text="Employee Name"></asp:Label><sup style="color:red">*</sup>
             </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Employee Name" ControlToValidate="txtName" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lbldob" runat="server" Text="DOB"></asp:Label><sup style="color:red">*</sup>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtdob" runat="server" TextMode="Date"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Date of Birth" ControlToValidate="txtdob" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lbllocation" runat="server" Text="Location"></asp:Label><sup style="color:red">*</sup>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtlocation" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter location" ControlToValidate="txtlocation" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label><sup style="color:red">*</sup>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:RadioButtonList>
            </asp:TableCell>
          </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lbldoj" runat="server" Text="DOJ"></asp:Label><sup style="color:red">*</sup>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtdoj" runat="server" TextMode="Date"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter DOJ" ControlToValidate="txtdoj" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblctc" runat="server" Text="CTC"></asp:Label><sup style="color:red">*</sup>
            </asp:TableCell>
            
            <asp:TableCell>
                <asp:TextBox ID="txtctc" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Enter CTC" ControlToValidate="txtctc" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lbldesignation" runat="server" Text="Designation"></asp:Label><sup style="color:red">*</sup>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList3"  runat="server">
                    <asp:ListItem Text="select" Value="select" >Select</asp:ListItem>
                    <asp:ListItem Text="Unit Head" Value="Unit Head">Unit Head</asp:ListItem>
                    <asp:ListItem Text="Employee" Value="Employee">Emoployee</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Select designation" ControlToValidate="DropDownList3" InitialValue="Select" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblunithead" runat="server" Text="Unit Head"></asp:Label><sup style="color:red">*</sup>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>101</asp:ListItem>
                    <asp:ListItem>102</asp:ListItem>
                    <asp:ListItem>103</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Select unithead ID" ControlToValidate="DropDownList1" InitialValue="Select" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblprojectid" runat="server" Text="Project ID"></asp:Label><sup style="color:red">*</sup>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:listitem>P101</asp:listitem>
                    <asp:ListItem>P102</asp:ListItem>
                    <asp:ListItem>P103</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Select Project ID" ControlToValidate="DropDownList2" InitialValue="Select" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="submit" runat="server" Text="Submit" />
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
