<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReporteIncidenciaMan03.aspx.cs" Inherits="Mantenimientos_ReporteIncidenciaMan03" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ACTUALIZACION DE REPORTE INCIDENCIA</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Envio Pendiente:</td>
            <td>
                <asp:DropDownList ID="cboEnvioPe" runat="server" AutoPostBack="True" Height="25px" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Codigo de Reporte:</td>
            <td class="auto-style1">
                    <asp:Label ID="lblCodigo" runat="server" BorderStyle="Inset" Width="83px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Nombre de Incidencia:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtNombreIn" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td class="auto-style3">Nro. Dias de Retraso:</td>
            <td>
                <asp:TextBox ID="txtRetraso" runat="server" Width="61px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Notificacion:</td>
            <td>
                <asp:Label ID="lblNotifica" runat="server" BorderStyle="Inset" Width="144px"></asp:Label>
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
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
            </td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
&nbsp;&nbsp;&nbsp;
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

