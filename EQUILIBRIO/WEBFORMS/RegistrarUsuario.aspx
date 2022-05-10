<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS/Inicio.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Label class="LbTitulo" runat="server" Text="REGISTRAR USUARIO"></asp:Label>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 367px;
        }
        .auto-style4 {
            width: 279px;
        }
        .auto-style5 {
            width: 279px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
        <div class="RegistrarUsuario">
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
            <asp:Label class="lbl" ID="LbRegistro" runat="server" Text="DATOS PERSONALES"></asp:Label></td>
                    <td class="auto-style4">
            <asp:Label class="lbl" ID="Label3" runat="server" Text="DIRECCIÓN"></asp:Label></td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:TextBox class="Txt" ID="TextNombre" runat="server" placeholder="NOMBRE"></asp:TextBox></td>
                    <td class="auto-style4">
            <asp:TextBox class="Txt" ID="TextAlias" runat="server" placeholder="ALIAS"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:TextBox class="Txt" ID="TextApellido" runat="server" placeholder="APELLIDO"></asp:TextBox></td>
                    <td class="auto-style4">
            <asp:TextBox class="Txt" ID="TextCalle" runat="server" placeholder="CALLE Y N°"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:TextBox class="Txt" ID="TextRut" runat="server" placeholder="RUT"></asp:TextBox></td>
                    <td class="auto-style4">
            <asp:TextBox class="Txt" ID="TextDpto" runat="server" placeholder="DPTO O BLOQUE"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:TextBox class="Txt" ID="TextTelefono" runat="server" placeholder="TELÉFONO"></asp:TextBox></td>
                    <td class="auto-style4">
            <asp:DropDownList class="Drop" ID="DropComuna" runat="server">
                <asp:ListItem Text="SELECCIONE UNA COMUNA" Value="0" />
            </asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:TextBox class="Txt" type="password" ID="TextContraseña" runat="server" placeholder="CONTRASEÑA"></asp:TextBox></td>
                    <td class="auto-style4">
            <asp:DropDownList class="Drop" ID="DropRegion" runat="server">
                <asp:ListItem Text="SELECCIONE UNA REGIÓN" Value="0" />
            </asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    </td>
                    <td class="auto-style5">
            <asp:Button class="btn" ID="BtnEnviar" runat="server" Text="CONFIRMAR"/>
                    </td>
                </tr>
            </table>
            <br />
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    
</asp:Content>
