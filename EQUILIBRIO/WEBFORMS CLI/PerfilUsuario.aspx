<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 20px;
            width: 85%;
        }

        .auto-style4 {
            width: 540px;
        }

        .auto-style5 {
            width: 291px;
        }

        .auto-style13 {
            width: 58px;
        }

        .auto-style14 {
            width: 350px;
        }

        .auto-style15 {
            width: 58px;
        }

        .auto-style16 {
            width: 350px;
        }

        .auto-style25 {
            width: 58px;
            height: 30px;
        }

        .auto-style26 {
            width: 350px;
            height: 30px;
        }

        .auto-style29 {
            width: 540px;
            height: 10px;
        }

        .auto-style30 {
            width: 540px;
            height: 10px;
            text-align: right;
        }

        .auto-style31 {
            position: relative;
            right: -58px;
            top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="MI PERFIL"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdateMain" runat="server">
        <ContentTemplate>
            <div class="Contenedor">
                <table class="auto-style1">
                    <tr style="height: 10px;">
                        <td class="auto-style4" colspan="2">
                            <asp:Label class="LblTitulo" ID="LbDatos" runat="server" Text="DATOS PERSONALES"></asp:Label>
                            <asp:ImageButton class="BtnForm" ID="BtnEditarUser" style="float: right;" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" CssClass="auto-style31" OnClick="BtnEditarUser_Click" />
                            <asp:ImageButton class="BtnForm" ID="BtnCheckUser" style="float: right;" runat="server" Visible="false" Height="20px" Width="20px" ImageUrl="~/IMG/check.png" CssClass="auto-style31" OnClick="BtnCheckUser_Click" />
                        </td>
                        <td class="auto-style5" colspan="2">
                            <asp:Label class="LblTitulo" ID="LbDirecciones0" runat="server" Text="MIS DIRECCIONES"></asp:Label>
                            <asp:ImageButton class="BtnForm" ID="BtnEditarDir" style="float: right;" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" CssClass="auto-style31" OnClick="BtnEditarDir_Click" />
                            <asp:ImageButton class="BtnForm" ID="BtnCheckDir" Visible="false" style="float: right;" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/check.png" CssClass="auto-style31" OnClick="BtnCheckDir_Click" />

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label class="Lbl" ID="LblRut" runat="server" Text="RUT:" />
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox CssClass="TxtPerfil" class="TxtPerfil" ID="TxtRut" Enabled="false" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style2">
                            <asp:Label class="Lbl" ID="LblAlias" runat="server" Text="ALIAS:" />
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox CssClass="TxtPerfil" class="TxtPerfil" ID="TxtAlias" Enabled="false" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr style="height: 10px;">
                        <td class="auto-style15">
                            <asp:Label class="Lbl" ID="LblNombre" runat="server" Text="NOMBRE:" />
                        </td>
                        <td class="auto-style16">
                            <asp:TextBox CssClass="TxtPerfil" class="TxtPerfil" ID="TxtNombre" Enabled="false" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style2">
                            <asp:Label class="Lbl" ID="LblDireccion" runat="server" Text="DIRECCIÓN:" />
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox CssClass="TxtPerfil" class="TxtPerfil" ID="TxtDireccion" Enabled="false" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr style="height: 10px;">
                        <td class="auto-style13">
                            <asp:Label class="Lbl" ID="LblApellido" runat="server" Text="APELLIDO:" />
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox CssClass="TxtPerfil" class="TxtPerfil" ID="TxtApellido" Enabled="false" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style2">
                            <asp:Label class="Lbl" ID="LblDepto" runat="server" Text="DEPTO:" />
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox CssClass="TxtPerfil" class="TxtPerfil" ID="TxtDepto" Enabled="false" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr style="height: 10px;">
                        <td class="auto-style15">
                            <asp:Label class="Lbl" ID="LblTelefono" runat="server" Text="TELÉFONO:" />
                        </td>
                        <td class="auto-style16">
                            <asp:TextBox CssClass="TxtPerfil" ID="TxtTeléfono" Enabled="false" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style2">
                            <asp:Label class="Lbl" ID="LblComuna" runat="server" Text="REGIÓN:" />
                        </td>
                        <td class="auto-style2">
                            <asp:UpdatePanel ID="UPC" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="DropRegion" CssClass="DropPerfil" style="vertical-align: middle;" Enabled="false" runat="server" OnSelectedIndexChanged="DropRegion_SelectedIndexChanged" AutoPostBack="true">
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr style="height: 10px;">
                        <td class="auto-style30" colspan="2" style="text-align: center;">
                            <asp:Button class="BtnOK" ID="Button1" runat="server" Text="Cerrar sesión" Style="margin-left: -70px; margin-bottom: 0px; margin-top: 20px;" OnClick="Button1_Click" />
                        </td>
                        <td class="auto-style2" style="vertical-align:super;">
                            <asp:Label class="Lbl" ID="LblRegion" runat="server" Text="COMUNA:" />
                        </td>
                        <td class="auto-style2" style="vertical-align:super;">
                            <asp:UpdatePanel ID="UPR" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="DropComuna" CssClass="DropPerfil" style="vertical-align: middle;" Enabled="false" runat="server">
                                    </asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="DropComuna" EventName="selectedindexchanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                </table>
                <asp:Label ID="LbEditUser" runat="server" Text=""></asp:Label>
                <asp:Label ID="LbEditDir" runat="server" Text=""></asp:Label>
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
