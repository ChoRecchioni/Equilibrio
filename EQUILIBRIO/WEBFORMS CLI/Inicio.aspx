<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="equilibrio.WEBFORMS.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-left: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="Contenedor" style="height: 410px;">
        <asp:Image ID="ImgInicio" runat="server" ImageUrl="~/IMG/Mariscos-e1592426953245-1200x900.jpg" Width="470px" style="float: left;  padding: 30px;"/>

        <div class="TextoInicio">
            <asp:Label Class="LblTitulo" ID="TitInicio" runat="server" Text="NUESTRA HISTORIA"></asp:Label>
            <br />
            <br />
            <asp:Label ID="TextInicio" runat="server" Text="
        Equilibrio es una cadena de mariscos con locales en Santiago y Viña del mar..."></asp:Label>
        </div>
    </div>

    </asp:Content>
