<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="PerfilAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web1" %>
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
                <asp:ImageButton class="BtnForm" ID="BtnEditarUser" runat="server"  Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" CssClass="auto-style31"  OnClick="BtnEditarUser_Click" />
                <asp:ImageButton class="BtnForm" ID="BtnCheckUser" runat="server" Visible="false"  Height="20px" Width="20px" ImageUrl="~/IMG/check.png" CssClass="auto-style31" OnClick="BtnCheckUser_Click" />
            </td>
            <td class="auto-style5" colspan="2">
                &nbsp;&nbsp;
                </tr>
        <tr>
            <td class="auto-style25">
                <asp:Label class="Lbl" ID="LblRut" runat="server" Text="RUT:"/>
            </td>
            <td class="auto-style26">
                <asp:TextBox class="Txt" ID="TxtRut" Enabled="false" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style15">
                <asp:Label class="Lbl" ID="LblNombre" runat="server" Text="NOMBRE:"/>
            </td>
            <td class="auto-style14">
                <asp:TextBox class="Txt" ID="TxtNombre" Enabled="false" runat="server"></asp:TextBox>
            </td>     
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style13">
                <asp:Label class="Lbl" ID="LblApellido" runat="server" Text="APELLIDO:"/>
            </td>
            <td class="auto-style14">
                <asp:TextBox class="Txt" ID="TxtApellido" Enabled="false" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style15">
                <asp:Label class="Lbl" ID="LblTelefono" runat="server" Text="TELÉFONO:"/>
            </td>
            <td class="auto-style14">
                <asp:TextBox class="Txt" ID="TxtTeléfono" Enabled="false" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style30" colspan="2">
                <asp:Button class="BtnOK" ID="Button1" runat="server" Text="Cerrar sesión" style="margin-top: 20px; margin-right: 65px;" OnClick="Button1_Click"/>
            </td>
        </tr>
        <tr style="height: 10px;">
            <td class="auto-style29" colspan="2">
                <br />
            </td>
            
        </tr>
        <tr style="height: 10px;">            
            <td colspan="2">
            </td>
            
        </tr>
        </table>
        <asp:Label ID="LbEditUser" runat="server" Text=""></asp:Label>
         <asp:Label ID="LbEditDir" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
