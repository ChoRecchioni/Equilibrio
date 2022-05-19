<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="CartaAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 800px;
        }
        .auto-style3 {
            width: 450px;
        }
        .auto-style4 {
            width: 88px;
        }
        .auto-style5 {
            width: 450px;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style8 {
            width: 40px;
        }
        .auto-style9 {
            width: 450px;
        }
        .auto-style10 {
            width: 88px;
        }
        .auto-style11 {
            width: 88px;
        }
        .auto-style13 {
            width: 805px;
        }
        .auto-style14 {
            width: 59px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="CARTA"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="LbTitulo" runat="server" Text="CATEGORIA"></asp:Label>
    <br />
    <table class="auto-style6">
        <tr>
            <td class="auto-style9">PRODUCTO:<asp:Label ID="LbProducto1" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style10">
                <asp:Label ID="LbPrecio1" runat="server" Text="12.000"></asp:Label></td>
            <td rowspan="2" class="auto-style8"><asp:ImageButton class="BtnForm" ID="BtnEditar" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" /></td>
            <td rowspan="2" class="auto-style8"><asp:ImageButton class="BtnForm" ID="BtnEditar0" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" /></td>
        </tr>
        <tr>
            <td colspan="2">INFORMACION:<asp:Label ID="LbInformacion1" runat="server" Text=" "></asp:Label></td>
        </tr>
    </table>

    <table class="auto-style13">
        <tr>
            <td class="auto-style5">PRODUCTO:<asp:Label ID="LbProducto2" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style11">
                <asp:Label ID="LbPrecio2" runat="server" Text="12.000"></asp:Label></td>
            <td rowspan="2" class="auto-style8"><asp:ImageButton class="BtnForm" ID="ImageButton1" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" /></td>
            <td rowspan="2" class="auto-style8"><asp:ImageButton class="BtnForm" ID="ImageButton2" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" /></td>
        </tr>
        <tr>
            <td colspan="2">INFORMACION:<asp:Label ID="LbInformacion2" runat="server" Text=" "></asp:Label></td>
        </tr>
    </table>

    <table class="auto-style1">
        <tr>
            <td class="auto-style3">PRODUCTO:<asp:Label ID="LbProducto3" runat="server" Text=" "></asp:Label></td>
            <td class="auto-style4">
                <asp:Label ID="LbPrecio3" runat="server" Text="12.000"></asp:Label></td>
            <td rowspan="2" class="auto-style8"><asp:ImageButton class="BtnForm" ID="ImageButton3" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" /></td>
            <td rowspan="2" class="auto-style8"><asp:ImageButton class="BtnForm" ID="ImageButton4" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" /></td>
        </tr>
        <tr>
            <td colspan="2">INFORMACION: <asp:Label ID="LbInformacion3" runat="server" Text=" "></asp:Label></td>
        </tr>
    </table>
</asp:Content>
