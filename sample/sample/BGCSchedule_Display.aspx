<%@ Page Title="View BGC Schedule" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BGCSchedule_Display.aspx.cs" Inherits="sample.BGCSchedule_Display" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            font-size: x-large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
     <br /><center>
         <h1><span><strong class="auto-style4">View BGC Schedules</strong></span></h1>
    <br />
        <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    <asp:GridView ID="grdschedule" runat="server" OnPageIndexChanging="grdschedule_PageIndexChanging" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  style="text-align: center" Width="746px"  PageSize="5">
        
         <AlternatingRowStyle BackColor="White" />
        
        <Columns>
            <asp:TemplateField HeaderText="BGCID">
                <ItemTemplate>
                    <asp:Label ID="lblBGCId" runat="server" Text='<%#Bind("BGCID")%>'></asp:Label>
            </ItemTemplate>
              
            </asp:TemplateField>
             <asp:TemplateField HeaderText="From Date">
                <ItemTemplate>
                    <asp:Label ID="lblFromDate" runat="server" Text='<%#Bind("FromDate")%>' ></asp:Label>
                </ItemTemplate>
                     
            </asp:TemplateField>
            <asp:TemplateField HeaderText="To Date">
                <ItemTemplate>
                    <asp:Label ID="lblToDate" runat="server" Text='<%#Bind("ToDate")%>' ></asp:Label>
                </ItemTemplate>
                     
            </asp:TemplateField>
        
             <asp:TemplateField HeaderText="Administrator ID">
                <ItemTemplate>
                    <asp:Label ID="lblAdministratorId" runat="server" Text='<%#Bind("AdministratorId")%>' ></asp:Label>
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
    <br /><br /><br /><br /><br />


</asp:Content>
