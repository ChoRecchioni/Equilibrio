<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 20px;
            width: 85%;
            
        }
        .auto-style2 {
            margin-left: 30px;
            width: 291px;
            border-left: 3px black solid;
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
        .auto-style17 {
            width: 58px;
        }
        .auto-style18 {
            width: 350px;
        }
        .auto-style19 {
            width: 58px;
        }
        .auto-style20 {
            width: 350px;
        }
        .auto-style21 {
            width: 58px;
        }
        .auto-style22 {
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
        .auto-style27 {
            width: 58px;
            height: 28px;
        }
        .auto-style28 {
            width: 350px;
            height: 28px;
        }
        .auto-style29 {
            width: 540px;
            height: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="MI PERFIL"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Contenedor">
    <table class="auto-style1">
        <tr style="height: 10px;">
            <td class="auto-style4" colspan="2"><asp:Label class="LblTitulo" ID="LbDatos" runat="server" Text="DATOS PERSONALES"></asp:Label>
                <asp:ImageButton class="BtnForm" ID="BtnEditar" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" />
            </td>
            <td class="auto-style5"><asp:Label class="LblTitulo" ID="LbCompras" runat="server" Text="MIS COMPRAS" Style="margin-left: 10px;"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style25">
                <asp:Label class="Lbl" ID="LblRut" runat="server" Text="RUT:"/>
            </td>
            <td class="auto-style26">
                <asp:TextBox class="Txt" ID="TxtRut" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2" rowspan="8">&nbsp;</td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style15">
                <asp:Label class="Lbl" ID="LblNombre" runat="server" Text="NOMBRE:"/>
            </td>
            <td class="auto-style16">
                <asp:TextBox class="Txt" ID="TxtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style13">
                <asp:Label class="Lbl" ID="LblApellido" runat="server" Text="APELLIDO:"/>
            </td>
            <td class="auto-style14">
                <asp:TextBox class="Txt" ID="TxtApellido" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style15">
                <asp:Label class="Lbl" ID="LblTelefono" runat="server" Text="TELÉFONO:"/>
            </td>
            <td class="auto-style16">
                <asp:TextBox class="Txt" ID="TxtTeléfono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style29" colspan="2">
                <br />
                <asp:Label class="LblTitulo" ID="LbDirecciones" runat="server" Text="MIS DIRECCIONES"></asp:Label>
                <asp:ImageButton class="BtnForm" ID="BtnAgregar" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/plus.png" OnClick="BtnAgregar_Click"/>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style17">
                <asp:Label class="Lbl" ID="LblAlias" runat="server" Text="ALIAS:"/>
            </td>
            <td class="auto-style18">
                <asp:TextBox class="Txt" ID="TxtAlias" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style19">
                <asp:Label class="Lbl" ID="LblDireccion" runat="server" Text="DIRECCIÓN:"/>
            </td>
            <td class="auto-style20">
                <asp:TextBox class="Txt" ID="TxtDireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style21">
                <asp:Label class="Lbl" ID="LblComuna" runat="server" Text="COMUNA:"/>
            </td>
            <td class="auto-style22">
                <asp:TextBox class="Txt" ID="TxtComuna" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style27">
                <asp:Label class="Lbl" ID="LblRegion" runat="server" Text="REGIÓN:"/>
            </td>
            <td class="auto-style28">
                <asp:TextBox class="Txt" ID="TxtRegion" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
    </table>
    </div>

</asp:Content>
