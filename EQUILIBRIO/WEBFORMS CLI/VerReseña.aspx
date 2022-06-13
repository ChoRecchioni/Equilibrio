 {<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="VerReseña.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="RESEÑAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Contenedor">
        <asp:DropDownList class="Drop" ID="FiltroLocal" runat="server">
            <asp:ListItem Text="SELECCIONE UN LOCAL" Value="-1" />

        </asp:DropDownList>

        <div id="DivResenas" runat="server">
        </div>
    </div>

</asp:Content>
