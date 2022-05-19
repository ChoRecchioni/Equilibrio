<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="VerReseña.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .Contenedor {
            margin-top: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="RESEÑAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<div class="Contenedor">  
    <asp:DropDownList ID="FiltroLocal" runat="server">
        <%--rellenar--%>
    </asp:DropDownList>
    <div class="reseña" style="border-bottom:solid 1px black; margin-top: 30px;">
        <asp:Label class="LblTitulo" ID="Ptaje" runat="server" Text=""></asp:Label>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/IMG/full-star.png" Height="20px" Width="20px" Style="vertical-align: bottom;" />
        <asp:Label class="LblTitulo" ID="Label3" runat="server" Text="- COMENTARIO:"></asp:Label>
        <asp:Label class="Lbl" ID="Coment" runat="server" Text=""></asp:Label><br />
    </div>
</div>

</asp:Content>
