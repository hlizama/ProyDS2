<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CargoMan02.aspx.cs" Inherits="Mantenimientos_CargoMan02" %>

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
            width: 115px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NUEVO CARGO</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Tipo Cargo:</td>
            <td>
                <asp:DropDownList ID="cboTipoCargo" runat="server" Height="25px" Width="281px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Descripcion:</td>
            <td>
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Peso:</td>
            <td>
                <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Unidad de Medida:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtUniMedida" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">
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

