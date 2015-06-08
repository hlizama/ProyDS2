<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TipoServicioMan03.aspx.cs" Inherits="Mantenimientos_TipoServicioMan03" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 175px;
        }
        .auto-style4 {
            width: 175px;
            height: 47px;
        }
        .auto-style5 {
            height: 47px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ACTUALIZAR TIPO DE SERVICIO</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Codigo de Tipo de Servicio</td>
            <td>
                <asp:Label ID="lblCodigo" runat="server" BorderStyle="Inset" Width="79px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Nombre del Tipo de Servicio:</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Dias:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDias" runat="server" Width="43px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Precio:</td>
            <td>
                <asp:TextBox ID="txtPrecio" runat="server" Width="45px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
&nbsp;</td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">&nbsp;
                <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red">Retornar</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

