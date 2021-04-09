<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="School_DB_Web_Form._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>
            Welcome To Rainbow School Database
        </h3>
    </div>

    <div class="row">
        <div class="col-md-4">
            
                <img src="https://sccnhub.com/images/Online-Student-Registration.png" class="img-fluid" height="50%" width="50%"/>
           
        </div>
        <div class="col-md-8">
           
               <div class="form-group">
                   <table>
                       <tr>
                  <td><label for="SID">Enter Student ID</label></td>
                <td><asp:TextBox ID="SID" runat="server"></asp:TextBox></td>
                           </tr>
                <tr>
                    <td> <label for="SNAME">Enter Student Name</label></td>
                <td><asp:TextBox ID="SNAME" runat="server"></asp:TextBox></td>
                </tr>
               
                  <tr>
                      <td> <label for="SMOB">Enter Student Mobile</label></td>
               <td> <asp:TextBox ID="SMOB" runat="server"></asp:TextBox></td>
                  </tr>
                  <tr>
                       <td><label for="SBRANCH">Enter Student Branch</label></td>
               <td><asp:TextBox ID="SBRANCH" runat="server"></asp:TextBox></td>
                  </tr>
                        </table>
               </div>
                <asp:Button ID="Button1" runat="server" Text="Submit Form" OnClick="Button1_Click" />
           
        </div>

    </div>
    <div>
       
    </div>
</asp:Content>
