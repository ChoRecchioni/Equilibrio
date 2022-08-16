<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="GestionarReservas.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web11" %>

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

        .auto-style5 {
            margin-left: 0px;
        }

        .lblReserva {
            margin-left: 25px;
        }

        .Btn {
            margin: 10px;
            margin-top: 0px;
            width: 120px;
            height: 25px;
        }

        .Txt {
            width: 300px;
        }
    </style>
    <script>
       function checkRut(rut) {
            // Despejar Puntos
            var valor = rut.value.replace('.', '');
            // Despejar Guión
            valor = valor.replace('-', '');

            // Aislar Cuerpo y Dígito Verificador
            cuerpo = valor.slice(0, -1);
            dv = valor.slice(-1).toUpperCase();

            // Formatear RUN
            rut.value = cuerpo + '-' + dv

            // Si no cumple con el mínimo ej. (n.nnn.nnn)
            if (cuerpo.length <= 6) { return false; }

            // Calcular Dígito Verificador
            suma = 0;
            multiplo = 2;

            // Para cada dígito del Cuerpo
            for (i = 1; i <= cuerpo.length; i++) {

                // Obtener su Producto con el Múltiplo Correspondiente
                index = multiplo * valor.charAt(cuerpo.length - i);

                // Sumar al Contador General
                suma = suma + index;

                // Consolidar Múltiplo dentro del rango [2,7]
                if (multiplo < 7) { multiplo = multiplo + 1; } else { multiplo = 2; }
            }

            // Calcular Dígito Verificador en base al Módulo 11
            dvEsperado = 11 - (suma % 11);

            // Casos Especiales (0 y K)
            dv = (dv == 'K') ? 10 : dv;
            dv = (dv == 0) ? 11 : dv;

            // Validar que el Cuerpo coincide con su Dígito Verificador
            if (dvEsperado != dv) { return false; }

            // Si todo sale bien, eliminar errores (decretar que es válido)
           rut.setCustomValidity('');
        }

        function EditarReserva(id) {
            window.location = "RegistrarReservaAdmi.aspx?ID=" + id;
            return false;
        }

        function EliminarReserva(id) {
            if (confirm("Desea eliminar la reserva?")) {
                $.ajax({
                    type: "post",
                    url: "GestionarReservas.aspx/EliminarReserva",
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
    <asp:Label class="titulos" ID="Label7" runat="server" Text="RESERVAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Contenedor" style="margin-top: 40px;">

        <asp:TextBox class="Txt" oninput="checkRut(this)" Style="float: left; margin-bottom: 30px;" ID="TxtBuscarRut" runat="server" placeholder="CLIENTE"></asp:TextBox>
        <asp:Button class="Btn" Style="float: left;" ID="BtnBuscarRut" runat="server" Text="BUSCAR" OnClick="BtnBuscarRut_Click" />
        <input class="calendarioreserva" id="fechaBuscar" runat="server" type="date" />
        <asp:Button class="Btn" ID="BtnBuscarFecha" runat="server" Text="BUSCAR" OnClick="BtnBuscarFecha_Click" />
        <br />

        <div id="divReservas" class="Contenedor" style="margin-left: 0px;" runat="server">
        </div>

    </div>
</asp:Content>
