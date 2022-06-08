﻿<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <style type="text/css">
        .auto-style1 {
            width: 670px;
        }

        .auto-style2 {
            border-right: 150px transparent solid;
            width: 400px;
        }
    </style>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="REGISTRO"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="HdnRolCliente" runat="server" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdateMain" runat="server">
        <ContentTemplate>

            <div class="Contenedor">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label class="LblTitulo" ID="LbRegistro" runat="server" Text="DATOS PERSONALES"></asp:Label></td>
                        <td class="auto-style4">
                            <asp:Label class="LblTitulo" ID="Label3" runat="server" Text="DIRECCIÓN"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextNombre" runat="server" placeholder="NOMBRE"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextNombre" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style4">
                            <asp:TextBox class="Txt" ID="TextAlias" runat="server" placeholder="ALIAS"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextAlias" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextApellido" runat="server" placeholder="APELLIDO"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextApellido" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        <td class="auto-style4">
                            <asp:TextBox class="Txt" ID="TextCalle" runat="server" placeholder="CALLE Y N°"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextCalle" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextRut" runat="server" placeholder="RUT"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextRut" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        <td class="auto-style4">
                            <asp:TextBox class="Txt" ID="TextDpto" runat="server" placeholder="DPTO O BLOQUE"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextDpto" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextTelefono" runat="server" placeholder="TELÉFONO"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextTelefono" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        <td class="auto-style4">
                            <asp:DropDownList class="Drop" ID="DropComuna" runat="server">
                                <asp:ListItem Text="SELECCIONE UNA REGIÓN" Value="0" />
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" type="password" ID="TextContraseña" runat="server" placeholder="CONTRASEÑA"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextContraseña" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        <td class="auto-style4">
                            <asp:DropDownList class="Drop" ID="DropRegion" runat="server">
                                <asp:ListItem Text="SELECCIONE UNA COMUNA" Value="0" />
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" type="password" ID="TextContraseña2" runat="server" placeholder="REPITA SU CONTRASEÑA"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextContraseña2" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        <td class="auto-style4">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td class="auto-style5">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Campos vacíos requeridos." DisplayMode="SingleParagraph" />

                            <asp:Button class="BtnOK" ID="BtnEnviar" runat="server" Text="CONFIRMAR" OnClick="BtnEnviar_Click" />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
                <asp:Label ID="LbMensaje1" runat="server" Text=""></asp:Label>
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
