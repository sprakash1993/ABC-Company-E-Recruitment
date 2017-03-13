<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="employeedetails.aspx.cs" Inherits="sample.employeedetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grdemployee" runat="server" OnRowCancelingEdit="grdemployee_RowCancelingEdit" OnRowEditing="grdemployee_RowEditing"
         OnRowUpdating="grdemployee_RowUpdating"  AllowPaging="true" AutoGenerateColumns="false" >
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
                    <asp:TextBox ID="txtdesignation" runat="server" Text='<%#Bind("Designation")%>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
        
             <asp:TemplateField HeaderText="Location">
                <ItemTemplate>
                    <asp:Label ID="lbllocation" runat="server" Text='<%#Bind("Location")%>'></asp:Label>
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
                    <asp:TextBox ID="txtctc" runat="server" Text='<%#Bind("CTC")%>'></asp:TextBox>
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
                </EditItemTemplate>
            </asp:TemplateField>
        
        </Columns>
       
    </asp:GridView>
</asp:Content>
