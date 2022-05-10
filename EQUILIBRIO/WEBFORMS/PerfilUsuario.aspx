<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS/Inicio.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 490%;
            height: 601px;
        }
        .auto-style2 {
            margin-left: 40px;
        }
        .auto-style3 {
            width: 646px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="auto-style1">
        <tr>
            <td class="auto-style3">DATOS PERSONALES</td>
            <td>MIS COMPRAS</td>
        </tr>
        <tr>
            <td class="auto-style3">RUT:<asp:Label ID="TxtRut" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" rowspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">NOMBRE:<asp:Label ID="TxtNombre" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
    </table>

</asp:Content>
