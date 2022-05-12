<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="Delivery.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 227%;
            height: 94px;
        }
        .auto-style2 {
            width: 400px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="auto-style1">
        <tr>
            <td class="auto-style2">PRODUCTO</td>
        </tr>
        <tr>
            <td class="auto-style2">INFORMACION DEL PRODUCTO.
                <br />
                INGREDIENTES, ACOMPAÑAMIENTO.<br />
                ETC.</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button class="btn" ID="Btnmenos1" runat="server" Text="-" Width="30px" />
                <asp:Label ID="LbCantidad1" runat="server" Text="1"></asp:Label>
                <asp:Button class="btn" ID="Btnmas1" runat="server" Text="+" Width="30px" />
                <asp:Label ID="LbPrecio1" runat="server" Text="$12.000"></asp:Label></td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">PRODUCTO</td>
        </tr>
        <tr>
            <td class="auto-style2">INFORMACION DEL PRODUCTO.
                <br />
                INGREDIENTES, ACOMPAÑAMIENTO.<br />
                ETC.</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button class="btn" ID="Btnmenos2" runat="server" Text="-" Width="30px" />
                <asp:Label ID="LbCantidad2" runat="server" Text="1"></asp:Label>
                <asp:Button class="btn" ID="Btnmas2" runat="server" Text="+" Width="30px" />
                <asp:Label ID="LbPrecio2" runat="server" Text="$12.000"></asp:Label>
            </td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">PRODUCTO</td>
        </tr>
        <tr>
            <td class="auto-style2">INFORMACION DEL PRODUCTO.
                <br />
                INGREDIENTES, ACOMPAÑAMIENTO.<br />
                ETC.</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button class="btn" ID="Btnmenos3" runat="server" Text="-" Width="30px" />
                <asp:Label ID="LbCantidad3" runat="server" Text="1"></asp:Label>
                <asp:Button class="btn" ID="Btnmas3" runat="server" Text="+" Width="30px" />
                <asp:Label ID="LbPrecio3" runat="server" Text="$12.000"></asp:Label></td>
        </tr>
    </table>

</asp:Content>