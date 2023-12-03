<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPannel.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="ECommerce.Admin.EditProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-align:center; font-size:50px">Edit Product</p><br />
    <div style="text-align:center;">
        <asp:TextBox  runat="server" placeholder="Enter Product ID...."  Height="27px" Width="599px" ID="TextBox5"></asp:TextBox>
        <asp:Button runat="server" Text="Show Details" Height="27px" ID="Button2" OnClick="Button2_Click"/><br /><br />
        <asp:TextBox ID="TextBox1" runat="server"  Height="27px" Width="599px"></asp:TextBox><br /><br />
         <asp:TextBox ID="TextBox2" runat="server" Height="27px" Width="599px"></asp:TextBox><br /><br />
         <asp:TextBox ID="TextBox3" runat="server"  Height="27px" Width="599px"></asp:TextBox><br /><br />
         <asp:TextBox ID="TextBox4" runat="server"  Height="27px" Width="599px"></asp:TextBox><br /><br />

        <asp:FileUpload ID="FileUpload1" runat="server" Height="27px" Width="599px"/><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Edit Product" Height="27px" Width="599px" OnClick="Button1_Click" />
    </div><br /><br />
</asp:Content>
