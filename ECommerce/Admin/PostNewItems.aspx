<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPannel.Master" AutoEventWireup="true" CodeBehind="PostNewItems.aspx.cs" Inherits="ECommerce.Admin.PostNewItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <p style="text-align:center; font-size:50px">Post New Product</p><br />
    <div style="text-align:center;">
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Product Name........." Height="27px" Width="599px"></asp:TextBox><br /><br />
         <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter price........." Height="27px" Width="599px"></asp:TextBox><br /><br />
         <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Description........." Height="27px" Width="599px"></asp:TextBox><br /><br />
         <asp:TextBox ID="TextBox4" runat="server" placeholder="Enter Type........." Height="27px" Width="599px"></asp:TextBox><br /><br />

        <asp:FileUpload ID="FileUpload1" runat="server" Height="27px" Width="599px"/><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" Height="27px" Width="599px" OnClick="Button1_Click"/>
    </div>
    <br /><br />
</asp:Content>
