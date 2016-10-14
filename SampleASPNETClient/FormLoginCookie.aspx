<%@ Page Title="Form Login Cookie" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormLoginCookie.aspx.cs" Inherits="SampleASPNETClient.FormLoginCookie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Form Login Cookie</h2>

    <fieldset>
        <label for="Username">Username :</label><br />
        <asp:TextBox runat="server" ID="Username" /><br /><br />
        <label for="Password">Password :</label><br />
        <asp:TextBox runat="server" ID="Password" TextMode="Password" /><br /><br />
        <asp:Button Text="Submit" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" />
    </fieldset>

    <br />
    <asp:Literal ID="ltKeterangan" runat="server" />
</asp:Content>
