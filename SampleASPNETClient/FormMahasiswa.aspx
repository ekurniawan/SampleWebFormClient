<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormMahasiswa.aspx.cs" Inherits="SampleASPNETClient.FormMahasiswa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Daftar Mahasiswa</h2>

    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:HyperLink NavigateUrl="~/FormAddMahasiswa" Text="Add Mahasiswa" runat="server" /><br />
    <asp:GridView CssClass="table table-striped" runat="server" ID="gvMahasiswa"
        AutoGenerateColumns="False" 
        ItemType="SampleASPNETClient.Models.Mahasiswa" DataKeyNames="Nim"
        SelectMethod="gvMahasiswa_GetData"
        UpdateMethod="gvMahasiswa_UpdateItem"
        DeleteMethod="gvMahasiswa_DeleteItem">
        <Columns>
            <asp:BoundField DataField="Nim" ReadOnly="true" />
            <asp:BoundField DataField="Nama" />
            <asp:BoundField DataField="Email" />
            <asp:BoundField DataField="IPK" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>


</asp:Content>
