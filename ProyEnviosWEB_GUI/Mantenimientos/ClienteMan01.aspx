<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClienteMan01.aspx.cs" Inherits="Mantenimientos_ClienteMan01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LISTADO DE CLIENTES</p>
<table class="auto-style1">
    <tr>
        <td>
            <asp:Button ID="btnNuevo" runat="server" PostBackUrl="~/Mantenimientos/ClienteMan02.aspx" Text="Nuevo" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="grvClientes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="grvClientes_RowCommand" Width="1126px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Editar" />
                    <asp:BoundField DataField="IDCliente" HeaderText="Codigo" />
                    <asp:BoundField DataField="Razon_Social" HeaderText="Razon Social" />
                    <asp:BoundField DataField="DNI" HeaderText="DNI" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="RUC" HeaderText="RUC" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="411px"></asp:Label>
            </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red" NavigateUrl="~/Mantenimientos/Mantenimientos.aspx">Retornar al Menu de Mantenimiento</asp:HyperLink>
            </td>
    </tr>
</table>
</asp:Content>

