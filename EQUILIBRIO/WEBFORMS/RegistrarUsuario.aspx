<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS/Inicio.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
        <div>
            <asp:Label ID="LbResgistro" runat="server" Text="Resgistrar Usuario"></asp:Label><br />
            <asp:TextBox ID="TextNombre" runat="server" placeholder="Nombre"></asp:TextBox><br />
            <asp:TextBox ID="TextApellido" runat="server" placeholder="Apellido"></asp:TextBox><br />
            <asp:TextBox ID="TextRut" runat="server" placeholder="Rut"></asp:TextBox><br />
            <asp:TextBox ID="TextTelefono" runat="server" placeholder="Telefono"></asp:TextBox><br />
            <asp:TextBox  type="password" ID="TextContraseña" runat="server" placeholder="Contraseña"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label><br />
            <asp:TextBox ID="TextAlias" runat="server" placeholder="Alias"></asp:TextBox><br />
            <asp:TextBox ID="TextCalle" runat="server" placeholder="Calle"></asp:TextBox><br />
            <asp:Label ID="Label1" runat="server" Text="Seleccione una Comuna"></asp:Label><br />
            <asp:DropDownList ID="DropComuna" runat="server"></asp:DropDownList><br />
            <asp:Label ID="Label2" runat="server" Text="Seleccione una Region"></asp:Label><br />
            <asp:DropDownList ID="DropRegion" runat="server"></asp:DropDownList><br />
            <asp:Button ID="BtnEnviar" runat="server" Text="Confirmar"/>
        </div>
    
</asp:Content>
