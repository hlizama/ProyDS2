<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmpleadoMan02.aspx.cs" Inherits="Mantenimientos_EmpleadoMan02" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        NUEVO EMPLEADO</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Nombres:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtNombre" runat="server" Width="182px"></asp:TextBox>
            </td>
            <td rowspan="4">
                <asp:Image ID="Image1" runat="server" Height="172px" Width="154px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Apellido Paterno:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Apellido Materno:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtApeMaterno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Fecha de Nacimiento:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Direccion:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDireccion" runat="server" Width="184px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Sexo:</td>
            <td class="auto-style8">
                <asp:RadioButton ID="optMasculino" runat="server" Checked="True" GroupName="G1" Text="M" />
                <br />
                <br />
                <asp:RadioButton ID="optFemenino" runat="server" GroupName="G1" Text="F" />
            </td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style3">Telefono:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">DNI:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Password:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Confirme Password:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtPass2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="3">
                <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" Width="580px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Red" NavigateUrl="~/Mantenimientos/EmpleadoMan01.aspx">Retornar</asp:HyperLink>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

