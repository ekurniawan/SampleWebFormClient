<%@ Page Title="Form Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormLogin.aspx.cs" Inherits="SampleASPNETClient.FormLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login Form</h2>
    <fieldset>
        <label for="Username">Username :</label><br />
        <asp:TextBox runat="server" ID="Username" /><br /><br />
        <label for="Password">Password :</label><br />
        <asp:TextBox runat="server" ID="Password" /><br /><br />

        <asp:Button Text="Submit" ID="btnSubmit" CssClass="btn btn-default" 
            runat="server" /> 
    </fieldset>
</asp:Content>
