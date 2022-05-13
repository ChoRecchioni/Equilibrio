<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="VerReseña.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 400%;
        }
        .auto-style3 {
            width: 90px;
        }
        .auto-style4 {
            width: 90px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList class="Drop" ID="DropTier" runat="server"></asp:DropDownList>

    <table class="auto-style1">
        <tr>
            <td class="auto-style3"><asp:Label ID="LbNEstrella1" runat="server" Text="3"></asp:Label><asp:Image ID="ImgEstrella1" runat="server" Width="35px" /></td>
            <td><asp:Label ID="LbComentario1" runat="server" Text="COMENTARIO:"></asp:Label></td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td class="auto-style4"><asp:Label ID="LbNEstrella2" runat="server" Text="1"></asp:Label><asp:Image ID="ImgEstrella2" runat="server" Width="35px" /></td>
            <td><asp:Label ID="LbComentario2" runat="server" Text="COMENTARIO:"></asp:Label></td>
        </tr>
    </table>

</asp:Content>
