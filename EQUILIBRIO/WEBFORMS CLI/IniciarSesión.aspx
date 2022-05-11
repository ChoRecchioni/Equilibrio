<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="IniciarSesión.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="IniciarSesion" id="background">
        <asp:TextBox class="TxtBoxIS" ID="TxtUser" runat="server" Text="USUARIO"></asp:TextBox><br />
        <asp:TextBox class="TxtBoxIS" ID="TxtPass" runat="server" Text="CONTRASEÑA"></asp:TextBox><br />
        <asp:Button class="Btn" ID="BtnIniciar" runat="server" Text="INICIAR SESIÓN" /><br />
        <asp:LinkButton class="LblTitulo" ID="LnkRegistrar" runat="server" OnClick="LnkRegistrar_Click">NO TIENE CUENTA? REGISTRESE</asp:LinkButton>
    </div>
</asp:Content>
