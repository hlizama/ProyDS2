<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConsEmpleadoEnvioFecha.aspx.cs" Inherits="Consultas_ConsEmpleadoEnvioFecha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CONSULTAR ENVIOS POR EMPLEADO Y FECHA</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Seleccionar Empleado:</td>
            <td>
                <asp:DropDownList ID="cboEmpleado" runat="server" Height="25px" Width="271px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Seleccionar Fecha de Inicio:</td>
            <td>
                <asp:TextBox ID="txtFecInicio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Seleccionar Fecha de Fin:</td>
            <td>
                <asp:TextBox ID="txtFecFin" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="btnCosultar" runat="server" OnClick="btnCosultar_Click" Text="Consultar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvEnvios" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="973px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="IDEnvio" HeaderText="Codigo Envio" />
                        <asp:BoundField DataField="Razon_Social" HeaderText="Cliente" />
                        <asp:BoundField DataField="FechaEstimada" DataFormatString="{0:d}" HeaderText="Fecha Estimada" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                        <asp:BoundField DataField="TCNombre" HeaderText="Cargo" />
                        <asp:BoundField DataField="TSNombre" HeaderText="Servicio" />
                        <asp:BoundField DataField="Estatus" HeaderText="Estatus" />
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
            <td colspan="2">
                <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Height="16px" Width="606px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red">Retornar</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

