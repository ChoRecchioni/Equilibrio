<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web1" %>

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
            width: 670px;
        }

        .auto-style2 {
            border-right: 150px transparent solid;
            width: 400px;
        }

        .auto-style4 {
            vertical-align: super;
        }
    </style>




</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="REGISTRO"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdateMain" runat="server">
        <ContentTemplate>
            <asp:HiddenField ID="HdnRolCliente" runat="server" />

            <div class="Contenedor">
                <table class="auto-style1">
                    <tr style="height: 50px; vertical-align: top;">
                        <td class="auto-style2">
                            <asp:Label class="LblTitulo" ID="LbRegistro" runat="server" Text="DATOS PERSONALES"></asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:Label class="LblTitulo" ID="Label3" runat="server" Text="DIRECCIÓN"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextNombre" runat="server" placeholder="NOMBRE"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" class="ValidadorRegistro" ControlToValidate="TextNombre" runat="server" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style4">
                            <asp:TextBox class="Txt" ID="TextAlias" runat="server" placeholder="ALIAS"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" class="ValidadorRegistro" runat="server" ControlToValidate="TextAlias" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextApellido" runat="server" placeholder="APELLIDO"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" class="ValidadorRegistro" runat="server" ControlToValidate="TextApellido" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>

                        </td>
                        <td class="auto-style4">
                            <asp:TextBox class="Txt" ID="TextCalle" runat="server" placeholder="CALLE Y N°"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" class="ValidadorRegistro" runat="server" ControlToValidate="TextCalle" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextRut" oninput="checkRut(this)" runat="server" placeholder="RUT"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" class="ValidadorRegistro" style="margin-bottom: 0px;" runat="server" ControlToValidate="TextRut" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" class="ValidadorRegistro" runat="server" ControlToValidate="TextRut" ErrorMessage="RUT no valido" ValidationExpression="^(\d{7,8}-)(\d{1}$)"></asp:RegularExpressionValidator>

                        </td>

                        <td class="auto-style4">
                            <asp:TextBox class="Txt" ID="TextDpto" runat="server" placeholder="DPTO O BLOQUE"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" class="ValidadorRegistro" runat="server" ControlToValidate="TextDpto" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextTelefono" runat="server" placeholder="TELÉFONO"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" class="ValidadorRegistro" runat="server" ControlToValidate="TextTelefono" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>

                        </td>

                        <td class="auto-style4" style="vertical-align: super;">
                            <asp:DropDownList class="Drop" ID="DropComuna" runat="server">
                                <asp:ListItem Text="SELECCIONE UNA REGIÓN" Value="0" />
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextCorreo" runat="server" placeholder="CORREO"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" class="ValidadorRegistro" style="margin-bottom: 0px;" runat="server" ControlToValidate="TextCorreo" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" class="ValidadorRegistro" runat="server" ControlToValidate="TextCorreo" ErrorMessage="Correo No Valido." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            </td>
                        <td class="auto-style4" style="vertical-align: super;">
                            <asp:DropDownList class="Drop" ID="DropRegion" runat="server">
                                <asp:ListItem Text="SELECCIONE UNA COMUNA" Value="0" />
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" type="password" ID="TextContraseña" runat="server" placeholder="CONTRASEÑA"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" class="ValidadorRegistro" runat="server" ControlToValidate="TextContraseña" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator></td>
                        <td class="auto-style4"></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" type="password" ID="TextContraseña2" runat="server" placeholder="REPITA SU CONTRASEÑA"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" class="ValidadorRegistro" runat="server" ControlToValidate="TextContraseña2" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>

                        </td>
                        <td class="auto-style5">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style5">
                            <asp:Button ID="BtnEnviar" runat="server" class="BtnOK" OnClick="BtnEnviar_Click" Text="CONFIRMAR" />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
                <asp:Label ID="LbMensaje1" runat="server" Text=""></asp:Label>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdateProgress ID="Cargando" AssociatedUpdatePanelID="UpdateMain" runat="server">
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
