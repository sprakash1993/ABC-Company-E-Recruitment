<%@ Page Title="View Candidate Profile" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CandidateProfileDisplay.aspx.cs" Inherits="sample.CandidateProfileDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            font-size: x-large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><center><h1><span><strong class="auto-style4">View Candidate Profile</strong></span></h1><br />
    <asp:Label ID="Label1" runat="server" Text="Select Criteria"></asp:Label>
    
    <asp:DropDownList ID="DropDownList1" runat="server" CausesValidation="false" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Select</asp:ListItem>
        <asp:ListItem>VacancyID</asp:ListItem>
        <asp:ListItem>BGCTestStatus</asp:ListItem>
        <asp:ListItem>TestStatus</asp:ListItem>
    </asp:DropDownList>
        <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Label" Visible="false"></asp:Label>

     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Enabled="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="197px" style="text-align: center" Width="561px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Candidate ID">
                <ItemTemplate>
                    <asp:Label ID="candidateId" runat="server" Text='<%#Bind("CandidateProfileID") %>'/>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Status">
                <ItemTemplate>
                     <asp:Label ID="hrinterviewstatus" runat="server" Text='Approved'/>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Vacancy ID">
                <ItemTemplate>
                    <asp:Label ID="vacancyId" runat="server" Text='<%#Bind("VacancyID") %>'/>
                </ItemTemplate>
                
            </asp:TemplateField>
        </Columns>
         <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
         <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
         <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
         <SortedAscendingCellStyle BackColor="#FDF5AC" />
         <SortedAscendingHeaderStyle BackColor="#4D0000" />
         <SortedDescendingCellStyle BackColor="#FCF6C0" />
         <SortedDescendingHeaderStyle BackColor="#820000" />
       </asp:GridView>
    
    <asp:GridView ID="GridView2" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="197px" style="text-align: center" Width="562px">
         <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Candidate ID">
                <ItemTemplate>
                    <asp:Label ID="candidateId" runat="server" Text='<%#Bind("CandidateProfileID") %>'/>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Status">
                <ItemTemplate>
                     <asp:Label ID="hrinterviewstatus" runat="server" Text='Approved'/>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="BGCTestStatus">
                <ItemTemplate>
                    <asp:Label ID="bgcStatus" runat="server" Text='<%#Bind("BGCTestStatus1") %>'/>
                </ItemTemplate>
                
            </asp:TemplateField>
        </Columns>
        
         <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
         <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
         <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
         <SortedAscendingCellStyle BackColor="#FDF5AC" />
         <SortedAscendingHeaderStyle BackColor="#4D0000" />
         <SortedDescendingCellStyle BackColor="#FCF6C0" />
         <SortedDescendingHeaderStyle BackColor="#820000" />
        
         </asp:GridView>


    <asp:GridView ID="GridView3" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="197px" style="text-align: center" Width="561px">
  <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Candidate ID">
                <ItemTemplate>
                    <asp:Label ID="candidateId" runat="server" Text='<%#Bind("CandidateProfileID") %>'/>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Status">
                <ItemTemplate>
                     <asp:Label ID="hrinterviewstatus" runat="server" Text='Approved'/>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TestStatus">
                <ItemTemplate>
                    <asp:Label ID="teststatus" runat="server" Text='<%#Bind("TestStatus1") %>'/>
                </ItemTemplate>
                
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>


    </center>
   <%-- <asp:Button ID="Button1" runat="server" Text="submit" />--%>
    <br /><br /><br />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
         <ul>
          <li ><a href="Home_admin.aspx">Home</a></li>
          <li ><a href="CandidateProfile.aspx">Edit Candidate Profile</a></li>
           <li class="active"><a href="CandidateProfileDisplay.aspx">View Candidate Profile</a></li>
           <li ><a href="Logout.aspx">Logout</a></li>
          </ul>
</asp:Content>
