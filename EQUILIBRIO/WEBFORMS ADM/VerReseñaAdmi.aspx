<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="VerReseñaAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 400%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DropDownList class="Drop" ID="DropTier" runat="server"></asp:DropDownList>


    <table class="auto-style1">
        <tr>
            <td rowspan="2"><asp:Label ID="LbNEstrella1" runat="server" Text="3"></asp:Label><asp:Image ID="ImgEstrella1" runat="server" Width="35px" />
            </td>
            <td rowspan="2"><asp:Label ID="LbComentario1" runat="server" Text="COMENTARIO"></asp:Label></td>
            <td>CLIENTE:<asp:Label ID="LbCliente1" runat="server" Text=" "></asp:Label></td>
        </tr>
        <tr>
            <td>DATOS DE CONTACTO:<asp:Label ID="LbDatos1" runat="server" Text=" "></asp:Label> </td>
        </tr>
    </table>
    <br />
    <table class="auto-style1">
        <tr>
            <td rowspan="2"><asp:Label ID="LbNEstrella2" runat="server" Text="1"></asp:Label><asp:Image ID="ImgEstrella2" runat="server" Width="35px" />
            </td>
            <td rowspan="2"><asp:Label ID="LbComentario2" runat="server" Text="COMENTARIO"></asp:Label></td>
            <td>CLIENTE:<asp:Label ID="LbCliente2" runat="server" Text=" "></asp:Label></td>
        </tr>
        <tr>
            <td>DATOS DE CONTACTO:<asp:Label ID="LbDatos2" runat="server" Text=" "></asp:Label> </td>
        </tr>
    </table>


</asp:Content>
