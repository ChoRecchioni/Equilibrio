<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="MisReservas.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web15" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-bottom: 1px solid black;
            padding-bottom: 20px;
            margin-top: 20px;
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

        .lblReserva {
            margin-left: 25px;
        }
    </style>
    <script>
        function EditarReserva(id) {
            window.location = "RegistrarReserva.aspx?Id=" + id;
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label2" runat="server" Text="MIS RESERVAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divReservas" runat="server" class="Contenedor">
        <asp:ImageButton class="BtnForm" Style="display: none;" ID="BtnEditar" OnClick="BtnEditar_Click" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" />
        <%--<table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label class="TxtReserva" ID="Label1" runat="server" Text="FECHA:"></asp:Label>
                    <asp:Label class="TxtReserva" ID="LblFecha" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label class="TxtReserva" ID="Label6" runat="server" Text="HORA:"></asp:Label>
                    <asp:Label class="TxtReserva" ID="LblHora" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:ImageButton class="BtnForm" ID="BtnEditar" OnClick="BtnEditar_Click" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" />
                </td>
                <td>
                    <asp:ImageButton class="BtnForm" ID="BtnEditar0" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="Label3" runat="server" Text="LOCAL:"></asp:Label>
                    <asp:Label ID="LblLocal" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="Label4" runat="server" Text="DIRECCIÓN:"></asp:Label>
                    <asp:Label ID="LblDireccion" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="Label5" runat="server" Text="TELÉFONO:"></asp:Label>
                    <asp:Label ID="LblTelefono" runat="server" Text=""></asp:Label>


                </td>
            </tr>
        </table>--%>
    </div>
</asp:Content>
