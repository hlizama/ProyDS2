<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TipoServicioMan02.aspx.cs" Inherits="Mantenimientos_TipoServicioMan02" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 123px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NUEVO TIPO DE SERVICIO</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Nombre de Servcio:</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="235px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Dias:</td>
            <td>
                <asp:TextBox ID="txtDias" runat="server" Width="39px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
            </td>
            <td>
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="389px"></asp:Label>
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

