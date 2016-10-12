<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormMahasiswa.aspx.cs" Inherits="SampleASPNETClient.FormMahasiswa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Daftar Mahasiswa</h2>

    <asp:HyperLink NavigateUrl="~/FormAddMahasiswa" Text="Add Mahasiswa" runat="server" /><br />

    <asp:GridView CssClass="table table-striped" runat="server" ID="gvMahasiswa"
        ItemType="SampleASPNETClient.Models.Mahasiswa"
        SelectMethod="gvMahasiswa_GetData"></asp:GridView>


</asp:Content>
