<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DestinoMan03.aspx.cs" Inherits="Mantenimientos_DestinoMan03" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ACTUALIZACION DE DESTINO</p>
    <p>
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Ciudades:</td>
            <td>
                <asp:DropDownList ID="cboCiudad" runat="server" AutoPostBack="True" Height="25px" Width="175px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style4">Codigo Distrito:</td>
            <td class="auto-style2">
                    <asp:Label ID="lblCodigo" runat="server" BorderStyle="Inset" Width="83px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Distrito:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtDistrito" runat="server" Width="108px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Direccion:</td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server" Width="175px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
                &nbsp;</td>
            <td>&nbsp; &nbsp;<asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
            <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="380px"></asp:Label>
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

