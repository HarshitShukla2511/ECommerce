<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPannel.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ECommerce.Admin.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p style="text-align:center; font-size:50px"> Admin Login</p><br /><br />
    <div style="text-align:center;">
          <asp:TextBox  runat="server" placeholder="Enter User Id"  Height="27px" Width="599px" ID="TextBox1"></asp:TextBox><br /><br />
         <asp:TextBox  runat="server" placeholder="Enter Password..."  Height="27px" Width="599px" ID="TextBox2"></asp:TextBox><br /><br />
        <asp:Button runat="server" Text="Login" Height="27px" Width="599px" ID="Button1" OnClick="Button1_Click" /><br /><br />

    </div>
</asp:Content>
