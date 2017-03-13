<%@ Page Title="Edit BGCAdmin Status" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BGCAdmin_Edit.aspx.cs" Inherits="sample.BGCAdmin_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            font-size: x-large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
     <h1><span><strong class="auto-style4">Edit BGC Test Administrators</strong></span></h1>
    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    <asp:GridView ID="grdadmin" runat="server" AllowPaging="true"  AutoGenerateColumns="False" OnRowEditing="grdBGCAdmin_RowEditing" OnRowUpdating="grdBGCAdmin_RowUpdating" OnRowCancelingEdit="grdBGCAdmin_RowCancelingEdit" CellPadding="4" ForeColor="#333333" GridLines="None" style="text-align: center" Width="789px" PageSize="5" OnPageIndexChanging="grdadmin_PageIndexChanging">
        
        <AlternatingRowStyle BackColor="White" />
        
        <Columns>
            <asp:TemplateField HeaderText="Administrator ID">
                <ItemTemplate>
                    <asp:Label ID="lblAdminId" runat="server" Text='<%#Bind("AdministratorID")%>'></asp:Label>
            </ItemTemplate>
              
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:Label ID="lblStatus" runat="server" Text='<%#Bind("Status1")%>' ></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <%--<asp:TextBox ID="txtStatus" runat="server" Text='<%#Bind("Status1")%>'></asp:TextBox>--%>
                    <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%#Bind("Status")%>'>
                        <asp:ListItem Value="0">Awaiting Approval</asp:ListItem>
                        <asp:ListItem Value="1">Approved</asp:ListItem>
                        <asp:ListItem Value="2">On Leave</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>         
            </asp:TemplateField>
        
             <asp:TemplateField HeaderText="Status Change Time">
                <ItemTemplate>
                    <asp:Label ID="lblStatusTime" runat="server" Text='<%#Bind("StatusChangeTime")%>' ></asp:Label>
                </ItemTemplate>
                         
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
        </center><br /><br /><br /><br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <ul>
          <li><a href="Home_unitHead.aspx">Home</a></li>
          <li class="active"><a href="BGCAdmin_Edit.aspx">Approve BGC Admin</a></li>
          <li><a href="Logout.aspx">Logout</a></li>
        </ul>  
</asp:Content>
