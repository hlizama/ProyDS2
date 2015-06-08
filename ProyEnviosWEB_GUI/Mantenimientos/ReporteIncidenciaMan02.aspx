<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReporteIncidenciaMan02.aspx.cs" Inherits="Mantenimientos_ReporteIncidenciaMan02" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 47px;
        }
        .auto-style3 {
            width: 134px;
        }
        .auto-style4 {
            height: 47px;
            width: 134px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NUEVO REPORTE INCIDENCIA</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Envio Pendiente:</td>
            <td>
                <asp:DropDownList ID="cboEnvioPe" runat="server" AutoPostBack="True" Height="25px" OnSelectedIndexChanged="cboEnvioPe_SelectedIndexChanged" Width="298px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Nombre de Incidencia:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtNombreIn" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Nro. Dias de Retraso:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtRetraso" runat="server" Width="61px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">E - Mail de Cliente:</td>
            <td>
                <asp:Label ID="lblCorreo" runat="server" BorderStyle="Inset" Width="187px"></asp:Label>
            &nbsp;&nbsp;
                <asp:Label ID="lblEstadoNotidicado" runat="server" BorderStyle="Inset"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Fecha:</td>
            <td>
                <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;Descripcion:<br />
                <asp:TextBox ID="txtDescripcion" runat="server" Height="65px" TextMode="MultiLine" Width="437px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
            </td>
            <td>
                <asp:Button ID="btnNotificar" runat="server" OnClick="btnNotificar_Click" Text="Notificar" />
&nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="422px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red">Retornar</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

