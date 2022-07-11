<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="CartaAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web14" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="CARTA"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Contenedor">
        <div class="HeadCarta">
            <asp:TextBox class="Txt" ID="TxtNombreArt" runat="server" placeholder="NOMBRE"></asp:TextBox>
            <asp:TextBox class="Txt" ID="TxtDescripcionArt" runat="server" placeholder="DESCRIPCIÓN"></asp:TextBox><br />

            <asp:TextBox class="Txt" ID="TxtPrecioArt" runat="server" placeholder="PRECIO"></asp:TextBox>
            <asp:DropDownList class="Drop" ID="DropCategoria" runat="server" Height="30px"></asp:DropDownList><br />

            <asp:Button class="BtnOKCarta" ID="BtnCrearArt" runat="server" Text="confirmar" OnClick="BtnCrearArt_Click" />

            <asp:Label ID="LbAddArt" runat="server" Text=""></asp:Label>
        </div>

        <div class="CategoriaCarta" id="DivCartas" runat="server">
        </div>
    </div>
</asp:Content>
