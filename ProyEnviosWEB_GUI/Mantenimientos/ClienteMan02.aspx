<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClienteMan02.aspx.cs" Inherits="Mantenimientos_ClienteMan02" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 118px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NUEVO CLIENTE</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Nombre:</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Apellido Paterno:</td>
            <td>
                <asp:TextBox ID="txtApePat" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Apellido Materno:</td>
            <td>
                <asp:TextBox ID="txtApeMat" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Fecha Nacimiento:</td>
            <td>
                <asp:TextBox ID="txtFecNac" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Direcccion:</td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Correo:</td>
            <td>
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">RUC</td>
            <td>
                <asp:TextBox ID="txtRuc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Telefono:</td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">DNI:</td>
            <td>
                <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Password</td>
            <td>
                <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Confirme Password:</td>
            <td>
                <asp:TextBox ID="txtPass2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
            <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="320px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red" NavigateUrl="~/Mantenimientos/ClienteMan01.aspx">Retornar</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

