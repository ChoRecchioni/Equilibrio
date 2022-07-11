<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="RegistrarReservaAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web17" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 550px;
        }

        .auto-style3 {
            width: 550px;
            margin-left: 80px;
        }

        .auto-style4 {
            height: 97px;
        }

        .auto-style5 {
            width: 550px;
            height: 35px;
        }

        .auto-style6 {
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="Nueva Reserva"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="Contenedor">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label class="LblTitulo" ID="Label2" runat="server" Text="Seleccione un local"></asp:Label>
                </td>
                <td>
                    <asp:Label class="LblTitulo" ID="Label3" runat="server" Text="Seleccione la hora"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <br />
                    <asp:UpdatePanel ID="UPLocal" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList class="Drop" ID="DropLocal" OnSelectedIndexChanged="DropLocal_SelectedIndexChanged" AutoPostBack="true" runat="server">
                                <asp:ListItem Text="LOCAL" Value="0" />
                            </asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td>
                    <br />
                    <asp:UpdatePanel ID="UPHora" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList class="Drop" ID="DropHoras" OnSelectedIndexChanged="DropHoras_SelectedIndexChanged" AutoPostBack="true" runat="server">
                            </asp:DropDownList>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="DropHoras" EventName="selectedindexchanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label class="LblTitulo" ID="Label5" runat="server" Text="Seleccione una fecha"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label class="LblTitulo" ID="Label4" runat="server" Text="Cantidad de personas"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" rowspan="3">
                    <asp:UpdatePanel ID="UPFecha" runat="server">
                        <ContentTemplate>
                            <asp:Calendar class="calendario" ID="Calendar1" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" AutoPostBack="true" runat="server"></asp:Calendar>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Calendar1" EventName="selectionChanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
                <td style="vertical-align: top">

                    <asp:RadioButtonList ID="Check" runat="server">

                        <asp:ListItem Value="2">2 personas</asp:ListItem>
                        <asp:ListItem Value="4">4 personas</asp:ListItem>

                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" class="ValidadorRegistro" ControlToValidate="Check" runat="server" ErrorMessage="seleccione una de las opciones "></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td style="vertical-align: top">
                    <asp:Label class="LblTitulo" ID="LbCliente" runat="server" Text="Rut Cliente"></asp:Label>
                    <asp:TextBox class="Txt" ID="TxtRut" oninput="checkRut(this)" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" class="ValidadorRegistro" Style="margin-bottom: 0px;" runat="server" ControlToValidate="TxtRut" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" class="ValidadorRegistro" runat="server" ControlToValidate="TxtRut" ErrorMessage="RUT no valido" ValidationExpression="^(\d{7,8}-)(\d{1}$)"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top">
                    <asp:Label class="LblTitulo" ID="Label6" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox class="Txt" ID="TxtNombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" class="ValidadorRegistro" runat="server" ControlToValidate="TxtNombre" ErrorMessage="Ingrese el nombre del cliente"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top" class="auto-style4">
                    <asp:Label ID="LbTelefono" runat="server" class="LblTitulo" Text="Teléfono"></asp:Label>
                    <br />
                    <asp:TextBox class="Txt" ID="TxtNumero" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" class="ValidadorRegistro" runat="server" ControlToValidate="TxtNumero" ErrorMessage="Ingrese un numero de contacto"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button class="BtnOK" ID="Button1" runat="server" Text="Reservar" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
        <asp:TextBox ID="TxtCliente" type="Hidden" runat="server" placeholder="CLIENTE"></asp:TextBox>
    </div>

    <asp:UpdateProgress ID="Cargando" runat="server">
        <ProgressTemplate>
            <div id="fondo"></div>
            <div class="load-9">
                <div class="spinner">
                    <div class="bubble-1"></div>
                    <div class="bubble-2"></div>
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>
