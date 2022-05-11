<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="CarroCompras.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web110" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        table {
            margin-top: 20px;
            width: 100%;            
        }
        .auto-style1 {
            margin-top: 20px;
            width: 73%;
        }
        .auto-style2 {
            width: 222px;
        }
        .auto-style3 {
            width: 163px;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            height: 52px;
        }
        .auto-style7 {
            width: 608px;
        }
        .auto-style8 {
            margin-top: 20px;
            width: 73%;
            height: 35px;
        }
        .auto-style9 {
            width: 222px;
            height: 35px;
        }
        .auto-style10 {
            width: 163px;
            height: 35px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="CarroCompras">
    <table>
        <tr style="height: 50px;">
            <td class="auto-style1"><asp:Label class="LblTitulo" ID="LbProducto" runat="server" Text="PRODUCTO" ></asp:Label></td>
            <td class="auto-style2"><asp:Label class="LblTitulo" ID="LbCantidad" runat="server" Text="CANTIDAD" ></asp:Label></td>
            <td class="auto-style3"><asp:Label class="LblTitulo" ID="LbPrecio" runat="server" Text="PRECIO" ></asp:Label></td>
        </tr>
        <tr style="height: 35px">
            <td class="auto-style1" >
                <asp:Label ID="Label1" runat="server" Text="Nombre del producto"></asp:Label>
            </td>
            <td class="auto-style2"> 
                <asp:Button class="Btn" ID="BtnMenos" runat="server" Text="-" Width="30px" Style="margin-right: 10px;" />
                <asp:Label ID="Label2" runat="server" Text="1"></asp:Label>
                <asp:Button class="Btn" ID="BtnMas" runat="server" Text="+" Width="30px" Style="margin-left: 10px;" />
            </td>
            <td class="auto-style3" >
                <asp:Label ID="Label3" runat="server" Text="$10.000.-"></asp:Label>
            </td>
        </tr>
        <tr style="height: 35px">
            <td class="auto-style1" >
                &nbsp;</td>
            <td class="auto-style2"> 
                &nbsp;</td>
            <td class="auto-style3" >
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8" >
                </td>
            <td class="auto-style9"> 
                <asp:Label class="LblTitulo" ID="LbCantidad0" runat="server" Text="TOTAL:" ></asp:Label>
            </td>
            <td class="auto-style10" >
                <asp:Label class="LblTitulo" ID="LblTotal" runat="server" Text="$10.000.-"></asp:Label>
            </td>
        </tr>
        </table>

    <br />

        <table class="auto-style4">
            <tr>
                <td class="auto-style7" rowspan="2">

    <asp:TextBox class="Txt" ID="TxtComentario" runat="server" placeholder="COMENTARIO:" Style="text-align-last: left; margin-top: -35px; padding-left: 5px;" Height="100px"></asp:TextBox></td>
                <td class="auto-style5">
    <asp:DropDownList class="Drop" ID="DropDireccion" runat="server" >
        <asp:ListItem Text="SELECCIONE UNA DIRECCIÓN" Value="0" />
        <asp:ListItem Text="ALIAS" Value="1" />
    </asp:DropDownList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>

    <asp:Button class="BtnOK" ID="BtnPagar" runat="server" Text="PAGAR" OnClick="BtnPagar_Click" />
                </td>
            </tr>
        </table>
        </div>
</asp:Content>
