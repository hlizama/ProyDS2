<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChoferMan03.aspx.cs" Inherits="Mantenimientos_ChoferMan03" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 47px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ACTUALIZACION DE CHOFERES
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Codigo Chofer:</td>
                <td>
                    <asp:Label ID="lblCodigo" runat="server" BorderStyle="Inset" Width="83px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Nombre:</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" Width="273px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Apellido Paterno:</td>
                <td>
                    <asp:TextBox ID="txtApePaterno" runat="server" Width="215px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Apellido Materno:</td>
                <td>
                    <asp:TextBox ID="txtApeMaterno" runat="server" Width="214px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Fecha de Nacimiento:</td>
                <td>
                    <asp:TextBox ID="txtFecNacimiento" runat="server" Width="140px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Direccion:</td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server" Width="274px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Telefono:</td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">DNI:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Nro. Brevete:</td>
                <td>
                    <asp:TextBox ID="txtNroBrevete" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Licencia de Conducir:</td>
                <td>
                    <asp:RadioButton ID="optC" runat="server" Checked="True" GroupName="Grupo01" Text="Categoria III - C" />
                    <br />
                    <br />
                    <asp:RadioButton ID="optB" runat="server" GroupName="Grupo01" Text="Categoria III - B" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
                </td>
                <td>
                    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
            <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="580px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red">Retornar</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        &nbsp;</p>
</asp:Content>

