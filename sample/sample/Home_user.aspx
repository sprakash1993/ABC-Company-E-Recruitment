<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home_user.aspx.cs" Inherits="sample.Home_user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <center>
<div id="slideShowImages">
    <img src="images/1.jpg" alt="Slide 1" />
    <img src="images/2.jpg" alt="Slide 2" />
    <img src="images/3.jpg" alt="Slide 3" />    
    <img src="images/4.jpg" alt="Slide 4" />
    <img src="images/5.jpg" alt="Slide 4" />
    <img src="images/7.png" alt="Slide 4" />
  </div>  </center>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
        <ul>
          <li class="active"><a href="Home_user.aspx">Home</a></li>
         
          <li><a href="Logout.aspx">Logout</a></li>
        </ul>    
          
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fbg">
    <div class="fbg_resize">
        <h2><span>E-Recruitment System</span></h2>
        <p>Recruitment is a process of searching applicants to staff vacancies in any organization. To meet the demands of the expanding industry, Company ABC has been increasing the recruitment of new employees by almost 20% every six months. It is thus very important  to Company ABC that its recruitment process is efficient, robust and effective.  The Recruitment process of Company ABC involves taking into account many parameters under consideration in order to recruit the right candidate. It is key to the success of the growth of Company ABC’s professional services. Company ABC proposes e-recruitment process is to meet the needs of a rapidly growing business in the age of internet. E-recruitment  solves some of the challenges faced by rapidly growing organizations.</p>
        <div class="clr"></div>
    </div>
  </div><br /><br /><br /><br />
</asp:Content>