<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="IniciarSesión.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdateMain" runat="server">
        <ContentTemplate>
            <div class="IniciarSesion" id="background">
                <asp:TextBox class="TxtBoxIS" ID="TxtUser" runat="server" Placeholder="USUARIO"></asp:TextBox><br />
                <asp:TextBox class="TxtBoxIS" ID="TxtPass" runat="server" Placeholder="CONTRASEÑA" type="password"></asp:TextBox><br />
                <asp:Button class="BtnOK" ID="BtnIniciar" runat="server" Text="INICIAR SESIÓN" Style="margin-top: 30px; margin-left: 0px;" OnClick="BtnIniciar_Click" /><br />
                <asp:LinkButton class="LblTitulo" ID="LnkRegistrar" runat="server" OnClick="LnkRegistrar_Click">NO TIENE CUENTA? REGISTRESE</asp:LinkButton>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdateProgress ID="Cargando" AssociatedUpdatePanelID="UpdateMain" runat="server">
        <ProgressTemplate>
            <div id="fondo"></div>
            <div class="load-9">
                <div class="spinner">
                    <div class="bubble-1"></div>
                    <div class="bubble-2"></div>
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>
