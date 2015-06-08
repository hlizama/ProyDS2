<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConsEnvioCiudad.aspx.cs" Inherits="Consultas_ConsEnvioCiudad" %>

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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LISTAR ENVIOS POR CIUDADES</p>
    <table class="auto-style1">
        <tr>
            <td>Seleccione Ciudad:
                <asp:DropDownList ID="cboCiudad" runat="server" AutoPostBack="True" Height="25px" OnSelectedIndexChanged="cboCiudad_SelectedIndexChanged" Width="182px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvEnvios" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="868px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="IDEnvio" HeaderText="Codigo Envio" />
                        <asp:BoundField DataField="Estatus" HeaderText="Estatus" />
                        <asp:BoundField DataField="Razon_Social" HeaderText="Nonbre Cliente" />
                        <asp:BoundField DataField="FechaEstimada" HeaderText="Fecha Estimada" />
                        <asp:BoundField DataField="Distrito" HeaderText="Distrito" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
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
                <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Height="16px" Width="606px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red">Retornar</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

