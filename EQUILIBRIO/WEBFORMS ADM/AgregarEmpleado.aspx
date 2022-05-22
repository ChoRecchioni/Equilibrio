<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="AgregarEmpleado.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web18" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="AGREGAR EMPLEADO"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Contenedor">
        <div class="AgrEmp" style="text-align: center;">
            <asp:TextBox class="TxtAddEm" ID="TxtRut" runat="server" placeholder="RUT"></asp:TextBox>
            <asp:TextBox class="TxtAddEm" ID="TxtNombre" runat="server" placeholder="NOMBRE"></asp:TextBox><br />
            <asp:TextBox class="TxtAddEm" ID="TxtApellido" runat="server" placeholder="APELLIDO"></asp:TextBox>
            <asp:TextBox class="TxtAddEm" ID="TxtTelefono" runat="server" placeholder="TELEFONO"></asp:TextBox><br />
            <asp:TextBox class="TxtAddEm" ID="TxtDireccion" runat="server" placeholder="DIRECCION"></asp:TextBox>
            <asp:DropDownList class="Drop" ID="DropRol" runat="server" Height="30px" Style="margin-inline: 20px;">
            </asp:DropDownList><br />
        </div>
        <asp:Button class="BtnOK" ID="Button1" runat="server" Text="AGREGAR" Style="float: right; margin-right: 10%;" />
    </div>
</asp:Content>
