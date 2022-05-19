<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="GestionarReservas.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .Reserva {
            width: 100%;
            border-bottom: 1px solid black;
            padding-bottom: 20px;
            margin-top: 10px;
        }
        .auto-style2 {
            width: 423px;
        }
        .auto-style3 {
            width: 350px;
        }
        .auto-style4 {
            width: 60px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .Btn {
            margin: 10px;
            margin-top: 12px;
            width: 120px;
            height: 25px;
        }
        .Txt {
            width: 300px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label7" runat="server" Text="RESERVAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Contenedor" style="margin-top: 40px;">

        <asp:TextBox class="Txt" Style="float: left; margin-bottom: 30px;" ID="TxtBuscar" runat="server" placeholder="CLIENTE"></asp:TextBox>
        <asp:Button class="Btn" Style="float: left;" ID="BtnBuscar" runat="server" Text="BUSCAR" />
        <asp:TextBox class="Txt" Style="float: left;" ID="TextBox1" runat="server" placeholder="FECHA"></asp:TextBox>
        <asp:Button class="Btn" Style="float: left;" ID="Button1" runat="server" Text="BUSCAR" />        
        
        <table class="Reserva">
            <tr>
                <td class="auto-style2">
                    <asp:Label class="LblTitulo" ID="Label1" runat="server" Text="FECHA:"></asp:Label>
                    <asp:Label class="Lbl" ID="LblFecha1" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label class="LblTitulo" ID="Label6" runat="server" Text="HORA:"></asp:Label>
                    <asp:Label class="Lbl" ID="LblHora1" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label class="LblTitulo" ID="Label2" runat="server" Text="N° COMENSALES:"></asp:Label>
                    <asp:Label class="Lbl" ID="LbComensales1" runat="server" Text=""></asp:Label></td>
                <td class="auto-style4">
                    <asp:ImageButton class="BtnForm" ID="BtnEditar" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" />
                </td>
                <td>
                    <asp:ImageButton class="BtnForm" ID="BtnEditar0" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label class="LblTitulo" ID="Label3" runat="server" Text="CLIENTE:"></asp:Label>
                    <asp:Label class="Lbl" ID="LbCliente1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label class="LblTitulo" ID="Label4" runat="server" Text="DATOS DE CONTACTO:"></asp:Label>
                    <asp:Label class="Lbl" ID="LblDatos1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>



        
        
    </div>
</asp:Content>
