<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="AgregarDirección.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 20px;
            width: 75%;
        }
        .auto-style2 {
            width: 550px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="HdnCodigo" runat="server" />
    <div class="Contenedor">
            <table class="auto-style1">
                <tr>
                    <td class="LblTitulo">
                        DIRECCIÓN:</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">

        <asp:TextBox class="Txt" ID="TxtAlias" runat="server" placeholder="ALIAS"></asp:TextBox></td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
        <asp:TextBox class="Txt" ID="TxtCalle" runat="server" placeholder="CALLE Y N°"></asp:TextBox></td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
        <asp:DropDownList class="Drop" ID="DropComuna" runat="server"></asp:DropDownList></td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
        <asp:DropDownList class="Drop" ID="DropRegion" runat="server"></asp:DropDownList></td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    </td>
                    <td class="auto-style5">
            <asp:Button class="BtnOK" ID="BtnEnviar" runat="server" Text="CONFIRMAR" style="margin-left: 300px;" OnClick="BtnEnviar_Click" />
                    </td>
                </tr>
            </table>
                <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
         </div>
    <div>

        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>
