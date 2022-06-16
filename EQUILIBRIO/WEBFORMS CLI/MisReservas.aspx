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

        .auto-style4 {
            width: 60px;
        }

        .lblReserva {
            margin-left: 25px;
        }
    </style>
    <script>
        function EditarReserva(id) {
            window.location = "RegistrarReserva.aspx?ID=" + id;
            return false;
        }

        function EliminarReserva(id) {
            if (confirm("Desea eliminar la reserva?")) {
                $.ajax({
                    type: "post",
                    url: "MisReservas.aspx/EliminarReserva",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify({ id: id }),
                    dataType: "json",
                    success: function (response) {
                        if (!response.d.error) {
                            alert(response.d.msg);
                            window.location.reload();
                        }
                        else {
                            alert(response.d.msg);
                        }
                    },
                    error: function (response) {
                        alert("Error: " + response.d.msg);
                    },
                    async: true
                });
            }
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label2" runat="server" Text="MIS RESERVAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divReservas" runat="server" class="Contenedor">
    </div>
</asp:Content>
