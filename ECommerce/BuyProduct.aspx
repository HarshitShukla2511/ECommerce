<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="BuyProduct.aspx.cs" Inherits="ECommerce.BuyProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #BuyPage{
            height:700px;
            width : 1250px;
            /*border : 2px solid yellow;*/
          
        }

         #box1{
            height:500px;
            width : 500px;
            border : 2px solid yellow;
          float:left;
        }

          #box2{
            height:500px;
            width : 500px;
           border : 2px solid yellow;
          float:right;
        }

          #heading{
              height:100px;
              width:1250px;
              background-color:gray;
              text-align:center;
          }
        .auto-style1 {
            height: 120px;
            width: 114px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <div id="BuyPage">
     <div id="heading">
         <span style="color:white; font-size:50px; ">Buying Deatails</span>
     </div>
     <div>
        <div id="box1" style="text-align:center;">
            <span style="color:black; font-size:35px; ">User Deatails</span>
            <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="394px"></asp:TextBox><br /><br />
            <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="394px"></asp:TextBox><br /><br />
            <asp:TextBox ID="TextBox3" runat="server" Height="26px" Width="394px"></asp:TextBox><br /><br />
            <asp:TextBox ID="TextBox4" runat="server" Height="26px" Width="394px"></asp:TextBox><br /><br />
            <asp:TextBox ID="TextBox5" runat="server" Height="26px" Width="394px"></asp:TextBox><br /><br />
            <asp:TextBox ID="TextBox6" runat="server" Height="26px" Width="394px"></asp:TextBox><br /><br />
            <asp:TextBox ID="TextBox7" runat="server" Height="26px" Width="394px"></asp:TextBox><br /><br />
       </div>
       <div id="box2" style="text-align:center;">
           <span style="color:black; font-size:35px; ">Product Deatails<br />
           </span>&nbsp; 
            <img id="Image" runat="server" src="" class="auto-style1" />
           <h1 id="head1" runat="server"></h1>
            <asp:TextBox ID="TextBox10" runat="server" Height="26px" Width="394px"></asp:TextBox><br /><br />
            <asp:TextBox ID="TextBox11" runat="server" Height="26px" Width="394px"></asp:TextBox><br /><br />

         Product Cost :  <asp:Label ID="Label1" runat="server"  Text="Product Cost"> </asp:Label><br /><br />
           Discount Cost :<asp:Label ID="Label2" runat="server" Text="Discount Cost"></asp:Label><br /><br />
          Total Cost : <asp:Label ID="Label3" runat="server" Text="Total Cost"></asp:Label><br /><br />

       </div>
     </div>
    </div>
    <br />
</asp:Content>
