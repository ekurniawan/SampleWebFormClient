<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormAddMahasiswa.aspx.cs" Inherits="SampleASPNETClient.FormAddMahasiswa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Form Add Mahasiswa</h2>

    <asp:Literal ID="ltKet" runat="server" />
    <fieldset>
        <label for="txtNim">Nim :</label><br />
        <asp:TextBox runat="server" ID="txtNim" /><br /><br />
        <label for="txtNama">Nama :</label><br />
        <asp:TextBox runat="server" ID="txtNama" /><br /><br />
        <label for="txtEmail">Email :</label><br />
        <asp:TextBox runat="server" ID="txtEmail" /><br /><br />
        <label for="txtIPK">IPK :</label><br />
        <asp:TextBox runat="server" ID="txtIPK" /><br /><br />
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
    </fieldset>
</asp:Content>
