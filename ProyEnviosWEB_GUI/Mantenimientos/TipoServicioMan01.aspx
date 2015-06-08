<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TipoServicioMan01.aspx.cs" Inherits="Mantenimientos_TipoServicioMan01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
        .auto-style2 {
            width: 473px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LISTADO DE TIPO DE SERVICIO</p>
<table class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" PostBackUrl="~/Mantenimientos/TipoServicioMan02.aspx" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:GridView ID="grvTipoServicio" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="grvTipoServicio_RowCommand" Width="628px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Editar" />
                    <asp:BoundField DataField="IDTipoServicio" HeaderText="Codigo" />
                    <asp:BoundField DataField="Nombre" HeaderText="Tipo Servicio" />
                    <asp:BoundField DataField="dias" HeaderText="Dias" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" />
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
        <td class="auto-style2">
            <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="587px"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red">Retornar al Menu Mantenimientos</asp:HyperLink>
        </td>
    </tr>
</table>
</asp:Content>

