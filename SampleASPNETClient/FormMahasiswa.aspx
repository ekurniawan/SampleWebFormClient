<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormMahasiswa.aspx.cs" Inherits="SampleASPNETClient.FormMahasiswa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Daftar Mahasiswa</h2>


    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:HyperLink NavigateUrl="~/FormAddMahasiswa" Text="Add Mahasiswa" runat="server" /><br />
    <asp:GridView CssClass="table table-striped" runat="server" ID="gvMahasiswa"
        AutoGenerateEditButton="true" AutoGenerateColumns="false"
        ItemType="SampleASPNETClient.Models.Mahasiswa" DataKeyNames="Nim"
        SelectMethod="gvMahasiswa_GetData"
        UpdateMethod="gvMahasiswa_UpdateItem">
        <Columns>
            <asp:BoundField DataField="Nim" ReadOnly="true" />
            <asp:BoundField DataField="Nama" />
            <asp:BoundField DataField="Email" />
            <asp:BoundField DataField="IPK" />
        </Columns>
    </asp:GridView>


</asp:Content>
