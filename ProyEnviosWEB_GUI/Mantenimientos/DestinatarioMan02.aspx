<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DestinatarioMan02.aspx.cs" Inherits="Mantenimientos_DestinatarioMan02" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
        }
        .auto-style4 {
            height: 23px;
            width: 116px;
        }
        .auto-style5 {
            width: 116px;
        }
        .auto-style6 {
            width: 116px;
            height: 45px;
        }
        .auto-style7 {
            height: 45px;
        }
        .auto-style8 {
            width: 116px;
            height: 47px;
        }
        .auto-style9 {
            height: 47px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NUEVO DESTINATARIO</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style6">Nombres:</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;Apellido Paterno:</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Apellido Materno: </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtApeMaterno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">DNI:</td>
            <td>
                <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Direccion:</td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Telefono:</td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
            </td>
            <td>
                <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">
            <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="580px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red" NavigateUrl="~/Mantenimientos/DestinatarioMan01.aspx">Retornar</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

