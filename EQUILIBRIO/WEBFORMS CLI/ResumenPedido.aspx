<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="ResumenPedido.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 20px;
            width: 100%;
        }

        .auto-style2 {
            margin-left: 30px;
            width: 250px;
            border-left: 3px black solid;
        }


        .auto-style30 {
            margin-left: 30px;
            width: 291px;
            border-left: 3px black solid;
            text-align: right;
        }
        .auto-style31 {
            width: 126px;
        }
        .auto-style32 {
            width: 76px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="RESUMEN DEL PEDIDO"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="Contenedor">
        <table class="auto-style1">
            <tr style="height: 10px;">
                <td class="LblTitulo" colspan="2">Cliente</td>
                <td class="auto-style5">
                    <asp:Label class="LblTitulo" ID="LbCompras" runat="server" Text="MIS COMPRAS" Style="margin-left: 10px;"></asp:Label></td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style32">
                    <asp:Label class="Lbl" ID="LblRut" runat="server" Text="RUT:" />
                </td>
                <td class="auto-style31">
                    <asp:Label class="Lbl" ID="LbRutu" runat="server" Text=" "></asp:Label>
                </td>
                <td class="auto-style2" rowspan="9">
                    <div id="divC" runat="server"></div>
                </td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style32">
                    <asp:Label class="Lbl" ID="LblNombre" runat="server" Text="NOMBRE:" />
                </td>
                <td class="auto-style31">
                    <asp:Label class="Lbl" ID="LbNombreu" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style32">
                    <asp:Label class="Lbl" ID="LblApellido" runat="server" Text="APELLIDO:" />
                </td>
                <td class="auto-style31">
                    <asp:Label class="Lbl" ID="LbApellidou" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style32">
                    <asp:Label class="Lbl" ID="LblTelefono" runat="server" Text="TELÉFONO:" />
                </td>
                <td class="auto-style31">
                    <asp:Label class="Lbl" ID="LbTelefonou" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style4" colspan="2">
                    <br />
                    <span class="LblTitulo">Dirección</span></td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style32">
                    <asp:Label class="Lbl" ID="LblDireccion" runat="server" Text="DIRECCIÓN:" />
                </td>
                <td class="auto-style31">
                    <asp:Label class="Lbl" ID="LbDireccionu" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style32">
                    <asp:Label class="Lbl" ID="LblComuna" runat="server" Text="COMUNA:" />
                </td>
                <td class="auto-style31">
                    <asp:Label class="Lbl" ID="LbComunau" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style32">
                    <asp:Label class="Lbl" ID="LblRegion" runat="server" Text="REGIÓN:" />
                </td>
                <td class="auto-style31">
                    <asp:Label class="Lbl" ID="LbRegionu" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style29" colspan="2">
                    <br />
                    <span class="LblTitulo">Método de pago</span>
                </td>
            </tr>
            <tr style="height: 10px;">
                <td class="auto-style29" colspan="2">
                    <asp:Label class="Lbl" ID="Label9" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style30"> 
                <asp:Label class="LblTitulo" ID="LbCantidad0" runat="server" Text="TOTAL:" ></asp:Label>
                <asp:Label class="LblTitulo" ID="LblTotal" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
            </table>
    </div>

</asp:Content>
