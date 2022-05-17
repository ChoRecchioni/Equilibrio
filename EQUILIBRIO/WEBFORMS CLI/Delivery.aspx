<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="Delivery.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 401px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="DELIVERY"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Contenedor">

        <label class="CategoríaProd">CATEGORÍA</label>

        <table class="ProdXCateg">
            <tr>
                <td class="auto-style1">
                    <div class="Producto">
                        <asp:Label Class="LblTitulo" ID="Label2" runat="server" Text="NOMBRE DEL PRODUCTO"></asp:Label><br />
                        <asp:Label Class="Txt" ID="Label3" runat="server" Text="Información del producto"></asp:Label><br />
                        <asp:Button class="Btn" ID="BtnMenos" runat="server" Text="-" Width="30px" Style="margin-right: 10px;" />
                        <asp:Label Class="Txt" ID="Label4" runat="server" Text="1"></asp:Label>
                        <asp:Button class="Btn" ID="BtnMas" runat="server" Text="+" Width="30px" Style="margin-left: 10px;" />
                        <asp:Label class="LblTitulo" ID="Precio" runat="server" Text="$10.000.-"></asp:Label>
                    </div>
                </td>
                <td>
                    <div class="Producto">
                        <asp:Label Class="LblTitulo" ID="Label5" runat="server" Text="NOMBRE DEL PRODUCTO"></asp:Label><br />
                        <asp:Label Class="Txt" ID="Label6" runat="server" Text="Información del producto"></asp:Label><br />
                        <asp:Button class="Btn" ID="Button1" runat="server" Text="-" Width="30px" Style="margin-right: 10px;" />
                        <asp:Label Class="Txt" ID="Label7" runat="server" Text="1"></asp:Label>
                        <asp:Button class="Btn" ID="Button2" runat="server" Text="+" Width="30px" Style="margin-left: 10px;" />
                        <asp:Label class="LblTitulo" ID="Label8" runat="server" Text="$10.000.-"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <div class="Producto">
                        <asp:Label Class="LblTitulo" ID="Label9" runat="server" Text="NOMBRE DEL PRODUCTO"></asp:Label><br />
                        <asp:Label Class="Txt" ID="Label10" runat="server" Text="Información del producto"></asp:Label><br />
                        <asp:Button class="Btn" ID="Button3" runat="server" Text="-" Width="30px" Style="margin-right: 10px;" />
                        <asp:Label Class="Txt" ID="Label11" runat="server" Text="1"></asp:Label>
                        <asp:Button class="Btn" ID="Button4" runat="server" Text="+" Width="30px" Style="margin-left: 10px;" />
                        <asp:Label class="LblTitulo" ID="Label12" runat="server" Text="$10.000.-"></asp:Label>
                    </div>
                </td>
                <td>
                    <div class="Producto">
                        <asp:Label Class="LblTitulo" ID="Label13" runat="server" Text="NOMBRE DEL PRODUCTO"></asp:Label><br />
                        <asp:Label Class="Txt" ID="Label14" runat="server" Text="Información del producto"></asp:Label><br />
                        <asp:Button class="Btn" ID="Button5" runat="server" Text="-" Width="30px" Style="margin-right: 10px;" />
                        <asp:Label Class="Txt" ID="Label15" runat="server" Text="1"></asp:Label>
                        <asp:Button class="Btn" ID="Button6" runat="server" Text="+" Width="30px" Style="margin-left: 10px;" />
                        <asp:Label class="LblTitulo" ID="Label16" runat="server" Text="$10.000.-"></asp:Label>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
