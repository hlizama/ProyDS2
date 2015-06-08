<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DestinoMan02.aspx.cs" Inherits="Mantenimientos_DestinoMan02" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 100px;
        }
        .auto-style4 {
            height: 23px;
            width: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NUEVO DESTINO</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Ciudades:</td>
            <td>
                <asp:DropDownList ID="cboCiudad" runat="server" Height="25px" Width="175px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style2"></td>
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
&nbsp; </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
            </td>
            <td>&nbsp; &nbsp;<asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
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
</asp:Content>

