<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h2>HMS courier system</h2>
            </hgroup>
            <p>
               
                <asp:Image ID="Image2" runat="server" ImageAlign="Middle" ImageUrl="~/Images/courier1.jpg" Width="950px" />
               
            </p>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Recomendamos lo siguiente:</h3>
    <ol class="round">
        <li class="one">
            <h5>Logearse</h5>
            Se debe logearse para utilizar el sistema.
        </li>
    </ol>
</asp:Content>