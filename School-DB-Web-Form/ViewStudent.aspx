<%@ Page Language="C#" Title="View Student Data Page" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewStudent.aspx.cs" Inherits="School_DB_Web_Form.ViewStudent" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
      
        <table class="table table-hover">
  <thead>
    <tr>
      <th scope="col">SID</th>
      <th scope="col">SNAME</th>
      <th scope="col">SMOB</th>
      <th scope="col">SBRANCH</th>
    </tr>
  </thead>
  <tbody>
    <tr>
     <th scope="row"> <asp:TextBox ID="SID" runat="server" ReadOnly="true"></asp:TextBox></th>
    <td><asp:TextBox ID="SNAME" runat="server" ReadOnly="true"></asp:TextBox></td>
      <td><asp:TextBox ID="SMOB" runat="server" ReadOnly="true"></asp:TextBox></td>
      <td><asp:TextBox ID="SBRANCH" runat="server" ReadOnly="true"></asp:TextBox></td>
       
    </tr>
  
  </tbody>
</table>
       
    </div>
    </asp:Content>