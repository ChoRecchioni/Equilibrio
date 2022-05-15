<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS USER/User.Master" AutoEventWireup="true" CodeBehind="IniciarSesión.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="IniciarSesion" id="background">
        <asp:TextBox class="TxtBoxIS" ID="TxtUser" runat="server" Placeholder="USUARIO"></asp:TextBox><br />
        <asp:TextBox class="TxtBoxIS" ID="TxtPass" runat="server" Placeholder="CONTRASEÑA"></asp:TextBox><br />
        <asp:Button class="BtnOK" ID="BtnIniciar" runat="server" Text="INICIAR SESIÓN" style="margin-top: 30px; margin-left: 0px;" OnClick="BtnIniciar_Click" /><br />
        <asp:LinkButton class="LblTitulo" ID="LnkRegistrar" runat="server" OnClick="LnkRegistrar_Click">NO TIENE CUENTA? REGISTRESE</asp:LinkButton>
    </div>
</asp:Content>
