<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReporteIncidenciaMan01.aspx.cs" Inherits="Mantenimientos_ReporteIncidenciaMan01" %>

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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LISTADO DE REPORTE INCIDENCIAS</p>
    <table class="auto-style1">
        <tr>
            <td>&nbsp;&nbsp;<asp:Button ID="btnNuevo" runat="server" PostBackUrl="~/Mantenimientos/ReporteIncidenciaMan02.aspx" Text="Nuevo" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvReportes" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grvReportes_RowCommand" Width="982px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Editar" />
                        <asp:BoundField DataField="IDReporte" HeaderText="Codigo Reporte" />
                        <asp:BoundField DataField="IDEnvio" HeaderText="Codigo Envio" />
                        <asp:BoundField DataField="Nombre" HeaderText="Incidencia" />
                        <asp:BoundField DataField="Notificado" HeaderText="Notificado" />
                        <asp:BoundField DataField="Retraso" HeaderText="Retraso" />
                        <asp:BoundField DataField="Descrip" HeaderText="Descripcion" />
                        <asp:BoundField DataField="Fecha" DataFormatString="{0:d}" HeaderText="Fecha" />
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
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red">Retornar al Menu de Mantenimiento</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

