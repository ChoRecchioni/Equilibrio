<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="Carta.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 389%;
        }
        .auto-style2 {
            width: 546px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="LbTitulo" runat="server" Text="CATEGORIA"></asp:Label>
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">PRODUCTO:<asp:Label ID="LbProducto1" runat="server" Text=" "></asp:Label></td>
            <td>
                <asp:Label ID="LbPrecio1" runat="server" Text="12.000"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2">INFORMACION:<asp:Label ID="LbInformacion1" runat="server" Text=" "></asp:Label></td>
        </tr>
    </table>

    <table class="auto-style1">
        <tr>
            <td class="auto-style2">PRODUCTO:<asp:Label ID="LbProducto2" runat="server" Text=" "></asp:Label></td>
            <td>
                <asp:Label ID="LbPrecio2" runat="server" Text="12.000"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2">INFORMACION:<asp:Label ID="LbInformacion2" runat="server" Text=" "></asp:Label></td>
        </tr>
    </table>

    <table class="auto-style1">
        <tr>
            <td class="auto-style2">PRODUCTO:<asp:Label ID="LbProducto3" runat="server" Text=" "></asp:Label></td>
            <td>
                <asp:Label ID="LbPrecio3" runat="server" Text="12.000"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2">INFORMACION: <asp:Label ID="LbInformacion3" runat="server" Text=" "></asp:Label></td>
        </tr>
    </table>

</asp:Content>
