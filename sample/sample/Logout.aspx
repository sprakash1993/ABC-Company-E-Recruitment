<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="sample.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="refresh" content="3;url=Home.aspx"
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:Label ID="Label1" runat="server" Text="Label"> <h2  style="text-align:center;color:maroon;">Logging out...</h2></asp:Label><asp:Label ID="Label2" runat="server" Text="Label"><h2 style="text-align:center;color:maroon;">Redirecting...     <img src="images/redirecting.gif" height="20px" width="20px" /></h2></asp:Label>
 <script type="text/javascript">
     window.onload = function () {
         var seconds = 1;
         document.getElementById("<%=Label2.ClientID %>").style.visibility = "hidden";
         setTimeout(function () {
             document.getElementById("<%=Label1.ClientID %>").style.visibility = "hidden";
             document.getElementById("<%=Label2.ClientID %>").style.visibility = "visible";
            }, seconds * 1000);
        };
</script>
</asp:Content>
