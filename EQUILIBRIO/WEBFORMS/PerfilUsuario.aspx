<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS/Inicio.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 490%;
            height: 601px;
        }
        .auto-style2 {
            margin-left: 40px;
        }
        .auto-style3 {
            width: 646px;
        }
        .auto-style4 {
            width: 646px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="auto-style1">
        <tr>
            <td class="auto-style4">DATOS PERSONALES
                <asp:ImageButton class="Btn" ID="BtnEditar" runat="server" Height="33px" Width="35px" ImageUrl="~/IMG/edit.png" />
            </td>
            <td>MIS COMPRAS</td>
        </tr>
        <tr>
            <td class="auto-style3">RUT:<asp:TextBox class="Txt" ID="TxtRut" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2" rowspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">NOMBRE:<asp:TextBox class="Txt" ID="TxtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">APELLIDO:<asp:TextBox class="Txt" ID="TxtApellido" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">TELÉFONO:<asp:TextBox class="Txt" ID="TxtTeléfono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">MIS DIRECCIONES<asp:ImageButton ID="ImageButton1" runat="server" Height="35px" Width="35px" ImageUrl="~/IMG/plus.png"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
    </table>

</asp:Content>
