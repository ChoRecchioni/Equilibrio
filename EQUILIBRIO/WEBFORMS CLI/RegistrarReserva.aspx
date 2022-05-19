<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="RegistrarReserva.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web16" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 759px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="Nueva Reserva"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Contenedor">

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">

                    <asp:Label class="LblTitulo" ID="Label2" runat="server" Text="Seleccione un local"></asp:Label><br />
                </td>
                <td>
                    <asp:Label class="LblTitulo" ID="Label3" runat="server" Text="Seleccione la hora"></asp:Label><br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList class="Drop" ID="DropLocal" runat="server">
                        <asp:ListItem Text="LOCAL" Value="0" />
                    </asp:DropDownList><br />
                </td>
                <td>
                    <asp:DropDownList class="Drop" ID="DropHoras" runat="server">
                        <asp:ListItem Text="12:00" Value="0" />
                        <asp:ListItem Text="14:00" Value="1" />
                        <asp:ListItem Text="16:00" Value="2" />
                        <asp:ListItem Text="18:00" Value="3" />
                    </asp:DropDownList><br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <br />
                    <asp:Label class="LblTitulo" ID="Label5" runat="server" Text="Seleccione una fecha"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:Label class="LblTitulo" ID="Label4" runat="server" Text="Seleccione mesa disponible"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Calendar class="calendario" ID="Calendar1" runat="server"></asp:Calendar>
                    

                </td>
                <td style="vertical-align: top">
                    <asp:DropDownList class="Drop" ID="DropMesas" runat="server">
                        <asp:ListItem Text="MESAS" Value="0" />
                    </asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td>

                    <asp:Button class="BtnOK" ID="Button1" runat="server" Text="Reservar" />
                </td>
            </tr>
        </table>

        <asp:TextBox ID="TxtCliente" type="Hidden" runat="server" placeholder="CLIENTE"></asp:TextBox>

    </div>
</asp:Content>
