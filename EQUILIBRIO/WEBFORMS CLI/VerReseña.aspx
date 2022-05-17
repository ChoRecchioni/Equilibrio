<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="VerReseña.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 400%;
        }
        .auto-style3 {
            width: 90px;
        }
        .auto-style4 {
            width: 90px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="RESEÑAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList class="Drop" ID="DropTier" runat="server"></asp:DropDownList>

<div class="Contenedor">   
    <asp:GridView ID="GrdReseña" runat="server"></asp:GridView>
</div>

</asp:Content>
