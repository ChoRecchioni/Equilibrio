<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="GestionarReservas.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-bottom: 1px solid black;
            padding-bottom: 20px;
        }
        .auto-style2 {
            width: 423px;
        }
        .auto-style3 {
            width: 350px;
        }
        .TxtReserva {
            font-weight: bold;
        }
        .auto-style4 {
            width: 60px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Contenedor">


            <br />
        <br />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">


        <asp:Label class="TxtReserva" ID="Label1" runat="server" Text="FECHA:"></asp:Label>
        <asp:Label class="TxtReserva" ID="LblFecha1" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
        <asp:Label class="TxtReserva" ID="Label6" runat="server" Text="HORA:"></asp:Label>
        <asp:Label class="TxtReserva" ID="LblHora1" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
        <asp:Label class="TxtReserva" ID="Label2" runat="server" Text="N° COMENSALES:"></asp:Label>
        <asp:Label class="TxtReserva" ID="LbComensales1" runat="server" Text=""></asp:Label></td>
                <td class="auto-style4">
                <asp:ImageButton class="BtnForm" ID="BtnEditar" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" />
                </td>
                <td>
                <asp:ImageButton class="BtnForm" ID="BtnEditar0" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
        <asp:Label ID="Label3" runat="server" Text="CLIENTE:"></asp:Label>
        <asp:Label ID="LbCliente1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
        <asp:Label ID="Label4" runat="server" Text="DATOS DE CONTACTO:"></asp:Label>
        <asp:Label ID="LblDatos1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
  
       
        </table>

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">


        <asp:Label class="TxtReserva" ID="Label5" runat="server" Text="FECHA:"></asp:Label>
        <asp:Label class="TxtReserva" ID="LbFecha2" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
        <asp:Label class="TxtReserva" ID="Label8" runat="server" Text="HORA:"></asp:Label>
        <asp:Label class="TxtReserva" ID="LbHora2" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
        <asp:Label class="TxtReserva" ID="Label10" runat="server" Text="N° COMENSALES:"></asp:Label>
        <asp:Label class="TxtReserva" ID="LbComensales2" runat="server" Text=""></asp:Label></td>
                <td class="auto-style4">
                <asp:ImageButton class="BtnForm" ID="ImageButton1" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" />
                </td>
                <td>
                <asp:ImageButton class="BtnForm" ID="ImageButton2" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
        <asp:Label ID="Label12" runat="server" Text="CLIENTE:"></asp:Label>
        <asp:Label ID="LbCliente2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
        <asp:Label ID="Label14" runat="server" Text="DATOS DE CONTACTO:"></asp:Label>
        <asp:Label ID="LbDatos2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
  
       
        </table>

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">


        <asp:Label class="TxtReserva" ID="Label16" runat="server" Text="FECHA:"></asp:Label>
        <asp:Label class="TxtReserva" ID="LbFecha3" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
        <asp:Label class="TxtReserva" ID="Label18" runat="server" Text="HORA:"></asp:Label>
        <asp:Label class="TxtReserva" ID="LbHora3" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
        <asp:Label class="TxtReserva" ID="Label20" runat="server" Text="N° COMENSALES:"></asp:Label>
        <asp:Label class="TxtReserva" ID="LbComensales3" runat="server" Text=""></asp:Label></td>
                <td class="auto-style4">
                <asp:ImageButton class="BtnForm" ID="ImageButton3" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" />
                </td>
                <td>
                <asp:ImageButton class="BtnForm" ID="ImageButton4" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
        <asp:Label ID="Label22" runat="server" Text="CLIENTE:"></asp:Label>
        <asp:Label ID="LbCliente3" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
        <asp:Label ID="Label24" runat="server" Text="DATOS DE CONTACTO:"></asp:Label>
        <asp:Label ID="LbDatos3" runat="server" Text=""></asp:Label>
                </td>
            </tr>
  
       
        </table>
        <br />
        <asp:TextBox ID="TxtBuscador" runat="server" placeholder="CLIENTE"></asp:TextBox><asp:Button class="btn" ID="BtnBuscar" runat="server" Text="BUSCAR" />
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server" CssClass="auto-style5" OnSelectionChanged="Calendar1_SelectionChanged" Width="400px"></asp:Calendar>

    </div>
</asp:Content>
