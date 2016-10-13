<%@ Page Title="Registrasi" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormRegistrasi.aspx.cs" Inherits="SampleASPNETClient.FormRegistrasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Form Registrasi</h2>
    <br />

    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:FormView runat="server" ID="frmRegistrasi" 
        ItemType="SampleASPNETClient.Models.RegisterBindingModel"
        DataKeyNames="Email" DefaultMode="Insert" InsertMethod="frmRegistrasi_InsertItem">
        <InsertItemTemplate>
            <label for="Email">Email :</label><br />
            <asp:TextBox runat="server" ID="Email" Text="<%# BindItem.Email %>" 
                TextMode="Email" /><br /><br />
            <label for="Password">Password: </label><br />
            <asp:TextBox runat="server" ID="Password" Text="<%# BindItem.Password %>"
                TextMode="Password" /><br /><br />
            <label for="ConfirmPassword">Confirm Password:</label><br />
            <asp:TextBox runat="server" ID="ConfirmPassword" Text="<%# BindItem.ConfirmPassword %>"
                TextMode="Password" /><br /><br />

            <asp:Button Text="Add" ID="btnAdd" CommandName="Insert"
                 CssClass="btn btn-success" runat="server" />
        </InsertItemTemplate>
    </asp:FormView><br /><br />

    <asp:Literal ID="ltKeterangan" runat="server" />
</asp:Content>
