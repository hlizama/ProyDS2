<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Mantenimientos.aspx.cs" Inherits="Mantenimientos_Mantenimientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 253px;
        }
        .auto-style3 {
            float: left;
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="auto-style1">
        <tr>     
            <td class="auto-style3">&nbsp; &nbsp;<asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" EnableTheming="True" ExpandDepth="0">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode Text="Clientes" Value="Clientes" NavigateUrl="~/Mantenimientos/ClienteMan01.aspx"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/Mantenimientos/EmpleadoMan01.aspx" Text="Empleados" Value="Empleados"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/Mantenimientos/DestinatarioMan01.aspx" Text="Destinatarios" Value="Destinatarios"></asp:TreeNode>
                    <asp:TreeNode Text="Transportes" Value="Transportes">
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/TransporteMan01.aspx" Text="Transportes" Value="Transportes"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/MarcaMan01.aspx" Text="Marcas" Value="Marcas"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/ChoferMan01.aspx" Text="Choferes" Value="Choferes"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Destinos" Value="Destinos">
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/DestinoMan01.aspx" Text="Destinos" Value="Destinos"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/CiudadMan01.aspx" Text="Ciudades" Value="Ciudades"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Cargos" Value="Cargos">
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/CargoMan01.aspx" Text="Cargos" Value="Cargos"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/TipoCargoMan01.aspx" Text="Tipo de Cargo" Value="Tipo de Cargo"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/TipoServicioMan01.aspx" Text="Tipo de Servicio" Value="Tipo de Servicio"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/Mantenimientos/ReporteIncidenciaMan01.aspx" Text="Reportar Incidencia" Value="Reportar Incidencia"></asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" ForeColor="#5555DD" />
                </asp:TreeView>
            </td>
            <td class="auto-style2" style="width: 635px; background-color: #FFFFFF; height: 400px; float: left; padding-left: 20px;"><asp:Image ID="Image1" runat="server" ImageUrl="~/Images/courier.jpg" style="text-align: justify; margin-top: 0px" Width="631px" Height="262px" />
            </td>
        </tr>
    </table>
</asp:Content>

