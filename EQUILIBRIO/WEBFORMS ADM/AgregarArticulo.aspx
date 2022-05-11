<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="AgregarArticulo.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Contenedor" id="">
    <asp:Label ID="Label1" runat="server" Text="Elegir categoria"></asp:Label><br />
    <asp:DropDownList ID="DropCategoria" runat="server" ></asp:DropDownList><br />
    <asp:TextBox ID="TxtProducto" runat="server" placeholder="Nombre del producto"></asp:TextBox><br />
    <asp:TextBox ID="TxtDescripcion" runat="server" placeholder="Descripcion" ></asp:TextBox><br />
    <asp:TextBox ID="TxtPrecio" type="number" runat="server" placeholder="Precio"></asp:TextBox><br />
    <asp:Button class="btn" ID="BtnAgregar" runat="server" Text="Agregar" />
    </div>
</asp:Content>
