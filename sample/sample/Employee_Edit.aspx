<%@ Page Title="Edit Employee" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employee_Edit.aspx.cs" Inherits="sample.WebForm1" Theme="Theme2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            font-size: x-large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><br />
    <center>
        <h1><span><strong class="auto-style4">View / Edit Employee</strong></span></h1><br />
        <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    <asp:GridView ID="grdemp" runat="server" OnRowEditing="grdemployee_RowEditing"
         OnRowUpdating="grdemployee_RowUpdating"  AllowPaging="True" AutoGenerateColumns="False" OnRowCancelingEdit="grdemp_RowCancelingEdit" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="grdemp_PageIndexChanging" style="text-align: center" PageSize="5" >
        
        <AlternatingRowStyle BackColor="White" />
        
        <Columns>
            <asp:TemplateField HeaderText="Employee ID">
                <ItemTemplate>
                    <asp:Label ID="lblemployeeId" runat="server" Text='<%#Bind("EmployeeId")%>'></asp:Label>
            </ItemTemplate>
              
            </asp:TemplateField>
             <asp:TemplateField HeaderText="DOB">
                <ItemTemplate>
                    <asp:Label ID="lbldob" runat="server" Text='<%#Bind("DOB")%>' ></asp:Label>
                </ItemTemplate>
              
            </asp:TemplateField>
        
             <asp:TemplateField HeaderText="DOJ">
                <ItemTemplate>
                    <asp:Label ID="lbldoj" runat="server" Text='<%#Bind("DOJ")%>' ></asp:Label>
                </ItemTemplate>
             
            </asp:TemplateField>
        
             <asp:TemplateField HeaderText="Designation">
                <ItemTemplate>
                    <asp:Label ID="lbldesignation" runat="server" Text='<%#Bind("Designation")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="txtdesignation" runat="server" SelectedValue='<%#Bind("Designation")%>'>
                        <asp:ListItem Value="Manager"></asp:ListItem>
                        <asp:ListItem Value="ASE"></asp:ListItem>
                        <asp:ListItem Value="Clerk"></asp:ListItem>
                        <asp:ListItem Value="SE"></asp:ListItem>
                    </asp:DropDownList>
             
                </EditItemTemplate>
            </asp:TemplateField>
        
             <asp:TemplateField HeaderText="Division">
                <ItemTemplate>
                    <asp:Label ID="lbldivision" runat="server" Text='<%#Bind("Division")%>'></asp:Label>
                </ItemTemplate>
              
            </asp:TemplateField>
        
             <asp:TemplateField HeaderText="Gender">
                <ItemTemplate>
                    <asp:Label ID="lblgender" runat="server" Text='<%#Bind("Gender")%>'></asp:Label>
                </ItemTemplate>
              
            </asp:TemplateField>
        
             <asp:TemplateField HeaderText="CTC">
                <ItemTemplate>
                    <asp:Label ID="lblctc" runat="server" Text='<%#Bind("CTC")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtctc" TextMode="Number" runat="server" Text='<%#Bind("CTC")%>'  MaxLength="7" ToolTip="Enter numericals only"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="Enter CTC" ControlToValidate="txtctc" ></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" Display="Dynamic" runat="server" ControlToValidate="txtctc" MinimumValue="150000" MaximumValue="600000" ErrorMessage="CTC should be between 150000 to 600000" Type="Integer"></asp:RangeValidator>
                    
                </EditItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Unit Head">
                <ItemTemplate>
                    <asp:Label ID="lblunithead" runat="server" Text='<%#Bind("UnitHeadID")%>'></asp:Label>
                </ItemTemplate>
               
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Project ID">
                <ItemTemplate>
                    <asp:Label ID="lblprojectid" runat="server" Text='<%#Bind("ProjectID")%>'></asp:Label>
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
       
       
    </asp:GridView><br /><br /><br /><br />
        </center>
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