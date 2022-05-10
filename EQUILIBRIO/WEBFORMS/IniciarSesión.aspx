<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS/Inicio.Master" AutoEventWireup="true" CodeBehind="IniciarSesión.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="IniciarSesion" id="background">
        <asp:TextBox class="TxtBoxIS" ID="TxtUser" runat="server" Text="USUARIO"></asp:TextBox><br />
        <asp:TextBox class="TxtBoxIS" ID="TxtPass" runat="server" Text="CONTRASEÑA"></asp:TextBox><br />
        <asp:Button class="btn" ID="BtnIniciar" runat="server" Text="INICIAR SESIÓN" /><br />
        <asp:LinkButton ID="LnkRegistrar" runat="server">NO TIENE CUENTA? REGISTRESE</asp:LinkButton>
    </div>
</asp:Content>
