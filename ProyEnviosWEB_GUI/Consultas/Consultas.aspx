<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Consultas.aspx.cs" Inherits="Consultas_Consultas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>ENVIOS Y CONSULTAS</strong></p>
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="Nuevo Envio" Value="Nuevo Envio"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Consultas/ConsEnvios.aspx" Text="Consulta de Envios" Value="Consulta de Envios"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Consultas/ConsEmpleadoEnvioFecha.aspx" Text="Consulta de Envios Por Empleado y Fecha" Value="Consulta de Envios Por Empleado y Fecha"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Consultas/ConsEnvioCiudad.aspx" Text="Consulta de Envios Por Ciudad" Value="Consulta de Envios Por Ciudad"></asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" ForeColor="#5555DD" />
                </asp:TreeView>
            </td>
        </tr>
    </table>
</asp:Content>

