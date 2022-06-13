<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="RegistrarReserva.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web16" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 550px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="Nueva Reserva"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                <td class="auto-style2"></td>
                <td>
                    <asp:UpdatePanel ID="UPBtnOK" runat="server">
                        <ContentTemplate>
                            <asp:Button class="BtnOK" ID="Button1" runat="server" Text="Reservar" OnClick="Button1_Click" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
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
