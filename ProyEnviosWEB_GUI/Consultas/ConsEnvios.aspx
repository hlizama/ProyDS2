<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConsEnvios.aspx.cs" Inherits="Consultas_ConsEnvios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 753px;
        }
        .auto-style2 {
            width: 207px;
        }
        .auto-style3 {
            width: 208px;
        }
        .auto-style4 {
            width: 263px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CONSULTA DE ENVIOS&nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Consultar Envio Por Chofer:</td>
            <td>Consultar Envio Por Empleado:</td>
            <td class="auto-style4">Consultar Envio Por Cliente:</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:DropDownList ID="cboChofer" runat="server" Height="25px" Width="236px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="cboEmpleado" runat="server" Height="25px" style="margin-bottom: 4px" Width="188px">
                </asp:DropDownList>
            </td>
            <td class="auto-style4">
                <asp:DropDownList ID="cboCliente" runat="server" Height="25px" Width="173px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnConsultar1" runat="server" OnClick="btnConsultar1_Click" Text="Consultar" />
            </td>
            <td>
                <asp:Button ID="btnConsultar2" runat="server" OnClick="btnConsultar2_Click" Text="Consultar" />
            </td>
            <td class="auto-style4">
                <asp:Button ID="btnConsultar3" runat="server" OnClick="btnConsultar3_Click" Text="Consultar" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grvEnvios" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1038px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="IDEnvio" HeaderText="Codigo" />
                        <asp:BoundField DataField="CINombre" HeaderText="Ciudad" />
                        <asp:BoundField DataField="Distrito" HeaderText="Distrito" />
                        <asp:BoundField DataField="TCNombre" HeaderText="Tipo Cargo" />
                        <asp:BoundField DataField="TSNombre" HeaderText="Tipo Servicio" />
                        <asp:BoundField DataField="Estatus" HeaderText="Estatus" />
                        <asp:BoundField DataField="Placa" HeaderText="Trans. Placa" />
                        <asp:BoundField DataField="FechaEstimada" HeaderText="Fecha Estimada" />
                        <asp:BoundField DataField="Peso" HeaderText="Cargo Peso" />
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
            <td class="auto-style2" colspan="3">
                <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Height="16px" Width="606px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red">Retornar</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

