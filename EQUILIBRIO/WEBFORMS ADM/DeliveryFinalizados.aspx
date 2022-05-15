<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="DeliveryFinalizados.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1000px;
        }
        .auto-style2 {
            width: 300px;
        }
        .auto-style3 {
            width: 50px;
        }
        .auto-style4 {
            width: 206px;
        }
        .auto-style5 {
            width: 40px;
        }
        .auto-style6 {
            width: 71px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="DELIVERYS FINALIZADOS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:TextBox ID="TxtNpedido" runat="server" placeholder="N° PEDIDO" ></asp:TextBox><asp:Button class= "btn" ID="Button1" runat="server" Text="Buscar" />
    <asp:TextBox ID="TxtCliente" runat="server" placeholder="CLIENTE" ></asp:TextBox><asp:Button class= "btn" ID="Button2" runat="server" Text="Buscar" />
    <asp:TextBox ID="TxtFecha" runat="server" placeholder="FECHA" ></asp:TextBox><asp:Button class= "btn" ID="Button3" runat="server" Text="Buscar" />
    <asp:TextBox ID="TxtEstado" runat="server" placeholder="ESTADO" ></asp:TextBox><asp:Button class= "btn" ID="Button4" runat="server" Text="Buscar" />
    
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">PEDIDO:<asp:Label ID="LbPedido1" runat="server" Text="00001"></asp:Label></td>
            <td rowspan="4" class="auto-style3">ITEM</td>
            <td class="auto-style4"><asp:Label ID="LbArticulo1" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style5">X<asp:Label ID="LbCantidad1" runat="server" Text="1"></asp:Label></td>
            <td rowspan="4" class="auto-style6"><asp:ImageButton class="BtnForm" ID="BtnEditar0" runat="server" Height="40px" Width="40px" ImageUrl="~/IMG/delete.png" /></td>
            <td rowspan="4"> <asp:Label ID="LbComentario1" runat="server" Text="COMENTARIO"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style2">CLIENTE:<asp:Label ID="LbCliente1" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style4"><asp:Label ID="LbArticulo2" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style5">X<asp:Label ID="LbCantidad2" runat="server" Text="1"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style2">TELEFONO<asp:Label ID="LbTelefono1" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style4"><asp:Label ID="LbArticulo3" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style5">X<asp:Label ID="LbCantidad3" runat="server" Text="1"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style2">DIRECCION:<asp:Label ID="LbDireccion1" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">PEDIDO:<asp:Label ID="LbPedido2" runat="server" Text="00001"></asp:Label></td>
            <td rowspan="4" class="auto-style3">ITEM</td>
            <td class="auto-style4"><asp:Label ID="LbArticulo4" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style5">X<asp:Label ID="LbCantidad4" runat="server" Text="1"></asp:Label></td>
            <td rowspan="4" class="auto-style6"><asp:ImageButton class="BtnForm" ID="ImageButton1" runat="server" Height="40px" Width="40px" ImageUrl="~/IMG/delete.png" /></td>
            <td rowspan="4"> <asp:Label ID="LbComentar2" runat="server" Text="COMENTARIO"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style2">CLIENTE:<asp:Label ID="LbCliente2" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style4"><asp:Label ID="LbArticulo5" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style5">X<asp:Label ID="LbCantidad5" runat="server" Text="1"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style2">TELEFONO<asp:Label ID="LbTelefono2" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style4"><asp:Label ID="LbArticulo6" runat="server" Text="ARTICULO"></asp:Label></td>
            <td class="auto-style5">X<asp:Label ID="LbCantidad6" runat="server" Text="1"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style2">DIRECCION:<asp:Label ID="LbDireccion2" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>

</asp:Content>
