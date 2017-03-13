<%@ Page Title="Candidate Profile" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CandidateProfile.aspx.cs" Inherits="sample.CandidateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style4 {
            font-size: x-large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><center>
    <h1><span><strong class="auto-style4">Edit Candidate Profile</strong></span></h1><br />
    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" CellPadding="4" ForeColor="#333333" GridLines="None" Height="201px" style="text-align: center" Width="540px" >
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
            <asp:TemplateField HeaderText="BGC Status">
                <ItemTemplate>
                    <asp:Label ID="bgcStatus" runat="server" Text='<%#Bind("BGCTestStatus1") %>'/>
                </ItemTemplate>
                <EditItemTemplate>
                    <%--<asp:TextBox ID="bgcStatus" runat="server" CausesValidation="false" ></asp:TextBox>--%>
                     <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%#Bind("BGCTestStatus") %>'>
        <asp:ListItem Value="False">Pending</asp:ListItem>
        <asp:ListItem Value="True">Cleared</asp:ListItem>
    </asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkEdit" runat="server" CommandName="edit">Edit</asp:LinkButton>
                   
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkUpdate" runat="server" CommandName="update">Update</asp:LinkButton>
                    <asp:LinkButton ID="Linkcancel" runat="server" CommandName="cancel">Cancel</asp:LinkButton>
                </EditItemTemplate>
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
    <br /><br /><br />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
         <ul>
          <li ><a href="Home_admin.aspx">Home</a></li>
          <li class="active"><a href="CandidateProfile.aspx">Edit Candidate Profile</a></li>
           <li><a href="CandidateProfileDisplay.aspx">View Candidate Profile</a></li>
           <li><a href="Logout.aspx">Logout</a></li>
          </ul>
</asp:Content>