<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS/Inicio.Master" AutoEventWireup="true" CodeBehind="AgregarEmpleado.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:TextBox ID="TxtRut" runat="server" placeholder="RUT" ></asp:TextBox><br />
        <asp:TextBox ID="TxtNombre" runat="server" placeholder="NOMBRE" ></asp:TextBox><br />
        <asp:TextBox ID="TxtApellido" runat="server" placeholder="APELLIDO" ></asp:TextBox><br />
        <asp:TextBox ID="TxtTelefono" runat="server" placeholder="TELEFONO" ></asp:TextBox><br />
        <asp:TextBox ID="TxtDireccion" runat="server" placeholder="DIRECCION" ></asp:TextBox><br />
        <asp:Label ID="LbRol" runat="server" Text="Elegir Rol"></asp:Label><br />
        <asp:DropDownList ID="DropRol" runat="server"></asp:DropDownList><br />
        <asp:Button class="btn" ID="Button1" runat="server" Text="AGREGAR" />
    </div>
</asp:Content>
