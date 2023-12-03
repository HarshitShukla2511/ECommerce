<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPannel.Master" AutoEventWireup="true" CodeBehind="AllProduct.aspx.cs" Inherits="ECommerce.Admin.AllProduct" %>
<%@ Import Namespace="ECommerce" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
  <thead>
    <tr>
      <th scope="col">S.No</th>
      <th scope="col">Product ID</th>
      <th scope="col">Product name</th>
      <th scope="col">Price</th>
      <th scope="col">img</th>
      <th scope="col">Descrption</th>
      <th scope="col">type</th>
      <th scope="col">Remove</th>
      <th scope="col">Edit</th>
    </tr>
  </thead>

   <%
       int sno = 1;
       DBWork db = new DBWork();
       db.reader =  db.SelectData();
       while (db.reader.Read())
       {
    %>
  <tbody>
    <tr>
      <th scope="row"><%= sno %></th>
      <td><%= db.reader["id"] %></td>
      <td><%= db.reader["productname"] %></td>
      <td><%= db.reader["price"] %></td> 
      <td> <img height="100" width="100" src ="/img/<%= db.reader["img"] %>" /></td>
      <td><%= db.reader["dpc"] %></td>
      <td><%= db.reader["type"] %></td>
      <td><a href="RemoveProduct.aspx?id=<%= db.reader["id"] %>" class="btn btn-outline-warning">Remove</a></td>
      <td><a href="EditProduct.aspx?id=<%= db.reader["id"] %>" class="btn btn-outline-warning">Edit</a></td>
      
    </tr>
    
  </tbody>

     <%
             sno++;
         } %>

</table>
</asp:Content>
