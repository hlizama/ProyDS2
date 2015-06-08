<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TipoCargoMan03.aspx.cs" Inherits="Mantenimientos_TipoCargoMan03" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ACTUALIZACION DE CARGOS</p>
    <p>
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Codigo de Cargo:</td>
            <td>
                    <asp:Label ID="lblCodigo" runat="server" BorderStyle="Inset" Width="83px"></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="auto-style3">Nombre de Cargo:</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
            </td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
&nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
            <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="326px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red">Retornar</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>

