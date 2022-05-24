<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="VerReseñaAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 400%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="RESEÑAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Contenedor">  
    <asp:DropDownList class="DropStars" ID="FiltroEstrellas" runat="server">
        <asp:ListItem Value="1" >★</asp:ListItem>
        <asp:ListItem Value="2" >★★</asp:ListItem>
        <asp:ListItem Value="3" >★★★</asp:ListItem>
        <asp:ListItem Value="4" >★★★★</asp:ListItem>
        <asp:ListItem Value="5" >★★★★★</asp:ListItem>        
    </asp:DropDownList>

    <div id="DivResenas" runat="server">
        
    </div>
    </div>

</asp:Content>
