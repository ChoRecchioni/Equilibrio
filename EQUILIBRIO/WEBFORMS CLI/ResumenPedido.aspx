<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="ResumenPedido.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 400%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="RESUMEN DEL PEDIDO"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="auto-style1">
        <tr>
            <td>DATOS CLIENTE</td>
        </tr>
        <tr>
            <td>RUT:<asp:Label ID="LbRut" runat="server" Text=" "></asp:Label><br />
                NOMBRE:<asp:Label ID="LbNombre" runat="server" Text=" "></asp:Label><br />
                APELLIDO:<asp:Label ID="LbApellido" runat="server" Text=" "></asp:Label><br />
                TELEFONO:<asp:Label ID="LbTelefono" runat="server" Text=" "></asp:Label></td>
        </tr>
    </table>

     <table class="auto-style1">
        <tr>
            <td>DIRECCION DE ENVIO</td>
        </tr>
        <tr>
            <td>ALIAS:<asp:Label ID="LbAlias" runat="server" Text=" "></asp:Label><br />
                DIRECCION:<asp:Label ID="LbDireccion" runat="server" Text=" "></asp:Label><br />
                COMUNA:<asp:Label ID="LbComuna" runat="server" Text=" "></asp:Label></td>
        </tr>
    </table>

    <table class="auto-style1">
        <tr>
            <td>METODO DE PAGO</td>
        </tr>
        <tr>
            <asp:Label ID="LbMetodo" runat="server" Text=" "></asp:Label>
            <td><br />    
        </tr>
    </table>

    <table class="auto-style1">
        <tr>
            <td>COMPRA</td>
        </tr>
        <tr>
            <asp:Label ID="LbProducto1" runat="server" Text=" "></asp:Label>
            <td>   
        </tr>
        <tr>
            <td><asp:Label ID="LbProducto2" runat="server" Text=" "></asp:Label></tr>
        <tr>
            <td><asp:Label ID="LbProducto3" runat="server" Text=" "></asp:Label></tr>
        <tr>
            <td>TOTAL:<asp:Label ID="LbTotal" runat="server" Text="48.000"></asp:Label></tr>
        
    </table>
    
</asp:Content>
