<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-left: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="TablaInicio" class="auto-style1">
        <tr>
            <td>
    <asp:Image ID="ImgInicio" runat="server" ImageUrl="~/IMG/Mariscos-e1592426953245-1200x900.jpg" Width="622px"/>
            </td>
            <td rowspan="2" style="vertical-align: baseline; padding-top: 30px; width: 300px;">
    <asp:Label ID="LblTitulo" runat="server" Text="NUESTRA HISTORIA"></asp:Label><br />
    <asp:Label ID="Texto" runat="server" Text="
        Equilibrio es una cadena de mariscos con locales en Santiago y Viña del mar..." ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    </asp:Content>
