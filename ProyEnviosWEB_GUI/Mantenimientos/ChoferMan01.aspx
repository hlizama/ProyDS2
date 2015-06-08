<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChoferMan01.aspx.cs" Inherits="Mantenimientos_ChoferMan01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LISTADO DE CHOFERES</p>
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Button ID="btnNuevo" runat="server" PostBackUrl="~/Mantenimientos/ChoferMan02.aspx" Text="Nuevo" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvChoferes" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1023px" OnRowCommand="grvChoferes_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Editar" />
                        <asp:BoundField DataField="IDChofer" HeaderText="Codigo" />
                        <asp:BoundField DataField="Razon_Social" HeaderText="Razon Social" />
                        <asp:BoundField DataField="FechaNacimiento" DataFormatString="{0:d}" HeaderText="Fecha Nacimiento" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="DNI" HeaderText="DNI" />
                        <asp:BoundField DataField="NumeroBrevete" HeaderText="Nro. Brevete" />
                        <asp:BoundField DataField="TipoBrevete" HeaderText="Tipo Brevete" />
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

