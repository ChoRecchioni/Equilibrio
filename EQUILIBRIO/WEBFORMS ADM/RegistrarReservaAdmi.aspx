<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="RegistrarReservaAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                    <br />
                </td>
                <td>
                    <asp:Label class="LblTitulo" ID="Label3" runat="server" Text="Seleccione la hora"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:UpdatePanel ID="UPLocal" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList class="Drop" ID="DropLocal" OnSelectedIndexChanged="DropLocal_SelectedIndexChanged" AutoPostBack="true" runat="server">
                                <asp:ListItem Text="LOCAL" Value="0" />
                            </asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <br />
                </td>
                <td>
                    <asp:UpdatePanel ID="UPHora" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList class="Drop" ID="DropHoras" OnSelectedIndexChanged="DropHoras_SelectedIndexChanged" AutoPostBack="true" runat="server">
                            </asp:DropDownList>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="DropHoras" EventName="selectedindexchanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <br />
                    <asp:Label class="LblTitulo" ID="Label5" runat="server" Text="Seleccione una fecha"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:Label class="LblTitulo" ID="Label4" runat="server" Text="Cantidad de personas"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
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
                    <asp:CheckBoxList ID="Check" runat="server">
                        <asp:ListItem Value="2">2 personas</asp:ListItem>
                        <asp:ListItem Value="4">4 personas</asp:ListItem>
                    </asp:CheckBoxList>
                   
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label class="LblTitulo" ID="LbCliente" runat="server" Text="Nombre del Cliente"></asp:Label>
                </td>
                <td>
                    <asp:UpdatePanel ID="UPBtnOK" runat="server">
                        <ContentTemplate>
                            <asp:Button class="BtnOK" ID="Button1" runat="server" Text="Reservar" OnClick="Button1_Click" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox class="Txt" ID="TxtNombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" class="ValidadorRegistro" runat="server" ControlToValidate="TxtNombre" ErrorMessage="Ingrese el nombre del cliente"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label class="LblTitulo" ID="LbTelefono" runat="server" Text="Numero del Cliente"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox class="Txt" ID="TxtNumero" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" class="ValidadorRegistro" runat="server" ControlToValidate="TxtNumero" ErrorMessage="Ingrese un numero de contacto"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
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
