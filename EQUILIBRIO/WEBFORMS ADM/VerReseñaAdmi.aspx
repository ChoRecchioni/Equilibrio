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
    <asp:DropDownList class="Drop" ID="FiltroLocal" runat="server" Height="30px">
        <%--rellenar--%>
    </asp:DropDownList>
    <div class="Reseña" style="border-bottom:solid 1px black; margin-bottom: 20px;">
        <asp:Label class="LblTitulo" ID="Ptaje" runat="server" Text=""></asp:Label>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/IMG/full-star.png" Height="20px" Width="20px" Style="vertical-align: bottom;" />
        <asp:Label class="LblTitulo" ID="Label3" runat="server" Text="- COMENTARIO:"></asp:Label>
        <asp:Label class="Lbl" ID="Coment" runat="server" Text=""></asp:Label><br />
    </div>
</div>

</asp:Content>
