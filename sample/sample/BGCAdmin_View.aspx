<%@ Page Title="View BGCAdmin Status" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BGCAdmin_View.aspx.cs" Inherits="sample.BGCAdmin_View" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style4 {
            font-size: x-large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br /><center>
     <h1><span><strong class="auto-style4">View BGC Test Administrators</strong></span></h1>
    <br /><asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    <asp:GridView ID="grdadmin" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdadmin_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" Width="553px" style="text-align: center" PagerSettings-PageButtonCount="10" PageSize="5">
        
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
                     
            </asp:TemplateField>
        
             <asp:TemplateField HeaderText="Status Change Time">
                <ItemTemplate>
                    <asp:Label ID="lblStatusTime" runat="server" Text='<%#Bind("StatusChangeTime")%>' ></asp:Label>
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
       
       
    </asp:GridView></center> <br /><br /><br /><br />
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