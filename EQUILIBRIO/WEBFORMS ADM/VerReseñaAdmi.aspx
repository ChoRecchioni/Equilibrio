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
    <asp:DropDownList class="Drop" ID="FiltroLocal" runat="server">
        <asp:ListItem Text="SELECCIONE UN LOCAL" Value="-1" />
        
    </asp:DropDownList>

    <div id="DivResenas" runat="server">
        
    </div>
    </div>

</asp:Content>
