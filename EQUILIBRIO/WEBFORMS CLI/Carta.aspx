<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="Carta.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="CARTA"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Contenedor" style="width: 800px;">
        <div class="CategoríaCarta">
            <label class="LblTitulo" style="font-size: x-large;">CATEGORÍA</label><br />
            <div class="ProductoCarta" style="margin-top: 20px;">
                <div class="NomProd" style="float: left; margin: 0px; margin-top: 10px;">
                    <asp:Label class="LblTitulo" ID="Label2" runat="server" Text="Label"></asp:Label>
                </div>
                <br /><br />
                <div class="PrecProd" style="float: right;">
                    <asp:Label class="Lbl" ID="Label4" runat="server" Text="$10.000.-"></asp:Label>
                </div>
                <div class="InforProd" style="float: left; margin-left: 0px;">
                    <asp:Label class="Lbl" ID="Label3" runat="server" Text="Información"></asp:Label>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
