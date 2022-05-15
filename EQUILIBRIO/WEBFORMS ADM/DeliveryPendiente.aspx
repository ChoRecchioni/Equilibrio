<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="DeliveryPendiente.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1000px;
            height: 62px;
        }
        .auto-style5 {
            width: 50px;
        }
        .auto-style9 {
            width: 123px;
        }
        .auto-style10 {
            width: 229px;
        }
        .auto-style11 {
            width: 32px;
        }
        .auto-style12 {
            width: 50px;
        }
        .auto-style13 {
            width: 229px;
            height: 23px;
        }
        .auto-style14 {
            width: 123px;
            height: 23px;
        }
        .auto-style15 {
            width: 32px;
            height: 23px;
        }
        .auto-style16 {
            width: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="DELIVERY PENDIENTE"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <table class="auto-style1">
        <tr>
            <td class="auto-style10">PEDIDO N°:<asp:Label ID="LbPedido" runat="server" Text=" 00001"></asp:Label> </td>
            <td class="auto-style16" rowspan="4">ITEM</td>
            <td class="auto-style9">
                <asp:Label ID="LbArticulo1" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style11">X<asp:Label ID="LbCantidad1" runat="server" Text="1"></asp:Label></td>
            <td class="auto-style5" rowspan="4">COMENTARIO:<asp:Label ID="Label3" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style12" rowspan="4"> <asp:ImageButton class="BtnForm" ID="BtnEditar0" runat="server" Height="40px" Width="40px" ImageUrl="~/IMG/delete.png" /></td>
            <td class="auto-style5" rowspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">CLIENTE:<asp:Label ID="LbCliente" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style9"><asp:Label ID="LbArticulo2" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style11">X<asp:Label ID="LbCantidad2" runat="server" Text="1"></asp:Label></td>
        <tr>
            <td class="auto-style10">TELEFONO:<asp:Label ID="LbTelefono" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style9"><asp:Label ID="LbArticulo3" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style11">X<asp:Label ID="LbCantidad3" runat="server" Text="1"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style13">DIRECCION:<asp:Label ID="LbDireccion" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style14"></td>
            <td class="auto-style15"></td>
        </tr>
    </table>

    <table class="auto-style1">
        <tr>
            <td class="auto-style10">PEDIDO N°:<asp:Label ID="LbPedido2" runat="server" Text=" 00001"></asp:Label> </td>
            <td class="auto-style16" rowspan="4">ITEM</td>
            <td class="auto-style9">
                <asp:Label ID="LbArticulo4" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style11">X<asp:Label ID="LbCantidad4" runat="server" Text="1"></asp:Label></td>
            <td class="auto-style5" rowspan="4">COMENTARIO:<asp:Label ID="LbComentario2" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style12" rowspan="4"> <asp:ImageButton class="BtnForm" ID="ImageButton1" runat="server" Height="40px" Width="40px" ImageUrl="~/IMG/delete.png" /></td>
            <td class="auto-style5" rowspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">CLIENTE:<asp:Label ID="LbCliente2" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style9"><asp:Label ID="LbArticulo5" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style11">X<asp:Label ID="LbCantidad5" runat="server" Text="1"></asp:Label></td>
        <tr>
            <td class="auto-style10">TELEFONO:<asp:Label ID="LbTelefono2" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style9"><asp:Label ID="LbArticulo6" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style11">X<asp:Label ID="LbCantidad6" runat="server" Text="1"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style13">DIRECCION:<asp:Label ID="LbDireccion2" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style14"></td>
            <td class="auto-style15"></td>
        </tr>
    </table>

</asp:Content>
