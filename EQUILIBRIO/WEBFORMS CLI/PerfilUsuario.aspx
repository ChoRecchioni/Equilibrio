﻿<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 20px;
            width: 85%;
            
        }
        .auto-style2 {
            margin-left: 30px;
            width: 291px;
            border-left: 3px black solid;
        }
        .auto-style4 {
            width: 540px;
        }
        .auto-style5 {
            width: 291px;
        }
        .auto-style13 {
            width: 58px;
        }
        .auto-style14 {
            width: 350px;
        }
        .auto-style15 {
            width: 58px;
        }
        .auto-style16 {
            width: 350px;
        }
        .auto-style25 {
            width: 58px;
            height: 30px;
        }
        .auto-style26 {
            width: 350px;
            height: 30px;
        }
        .auto-style29 {
            width: 540px;
            height: 10px;
        }
        .auto-style30 {
            width: 540px;
            height: 10px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="MI PERFIL"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Contenedor">
    <table class="auto-style1">
        <tr style="height: 10px;">
            <td class="auto-style4" colspan="2"><asp:Label class="LblTitulo" ID="LbDatos" runat="server" Text="DATOS PERSONALES"></asp:Label>
                <asp:ImageButton class="BtnForm" ID="BtnEditar" runat="server" />
                <asp:ImageButton class="BtnForm" ID="BtnEditConfirm" runat="server" OnClick="BtnEditar_Click"/>
            </td>
            <td class="auto-style5"><asp:Label class="LblTitulo" ID="LbCompras" runat="server" Text="MIS COMPRAS" Style="margin-left: 10px;"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style25">
                <asp:Label class="Lbl" ID="LblRut" runat="server" Text="RUT:"/>
            </td>
            <td class="auto-style26">
                <asp:TextBox class="Txt" ID="TxtRut" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2" rowspan="7">&nbsp;</td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style15">
                <asp:Label class="Lbl" ID="LblNombre" runat="server" Text="NOMBRE:"/>
            </td>
            <td class="auto-style16">
                <asp:TextBox class="Txt" ID="TxtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style13">
                <asp:Label class="Lbl" ID="LblApellido" runat="server" Text="APELLIDO:"/>
            </td>
            <td class="auto-style14">
                <asp:TextBox class="Txt" ID="TxtApellido" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style15">
                <asp:Label class="Lbl" ID="LblTelefono" runat="server" Text="TELÉFONO:"/>
            </td>
            <td class="auto-style16">
                <asp:TextBox class="Txt" ID="TxtTeléfono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style30" colspan="2">
                <asp:Button class="BtnOK" ID="Button1" runat="server" Text="Cerrar sesión" style="width: 150px; margin-top: 20px; margin-right: 65px;" OnClick="Button1_Click"/>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style29" colspan="2">
                <br />
                <asp:Label class="LblTitulo" ID="LbDirecciones" runat="server" Text="MIS DIRECCIONES"></asp:Label>
                <asp:ImageButton class="BtnForm" ID="BtnAgregar" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/plus.png" OnClick="BtnAgregar_Click"/>
            </td>
        </tr>
        <tr style="height: 10px;">            
            <td colspan="2">
                <div class="Direccion" style="margin-bottom: 20px;">
                    <asp:Label class="Lbl" ID="LblAlias" runat="server" Text="ALIAS:"/>
                    <asp:TextBox class="Txt Dir" ID="TxtAlias" runat="server" Width="300px" Style="position: relative; right: -70px;"></asp:TextBox>
                    <asp:ImageButton class="BtnForm" ID="BtnEditar0" runat="server" Height="20px" Width="20px" Style="position: relative; right: -85px;" ImageUrl="~/IMG/edit.png" /><br />
                    <asp:Label class="Lbl" ID="LblDireccion" runat="server" Text="DIRECCIÓN:"/>
                    <asp:TextBox class="Txt Dir" ID="TxtDireccion" runat="server" Style="position: relative; right: -20px;"></asp:TextBox><br />
                    <asp:Label class="Lbl" ID="LblComuna" runat="server" Text="COMUNA:"/>
                    <asp:TextBox class="Txt Dir" ID="TxtComuna" runat="server" Style="position: relative; right: -36px;"></asp:TextBox><br />
                    <asp:Label class="Lbl" ID="LblRegion" runat="server" Text="REGIÓN:"/>
                    <asp:TextBox class="Txt Dir" ID="TxtRegion" runat="server" Style="position: relative; right: -50px;"></asp:TextBox><br />
                </div>
            </td>
        </tr>
        </table>
        <asp:Label ID="LbEditUser" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
