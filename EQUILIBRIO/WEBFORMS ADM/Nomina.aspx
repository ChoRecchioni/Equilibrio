<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="Nomina.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 110%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:TextBox ID="TxtRut" runat="server" placeholder="RUT" ></asp:TextBox><asp:Button class="btn" ID="BtnBuscar1" runat="server" Text="BUSCAR" />
    <asp:TextBox ID="TxtNombre" runat="server" placeholder="NOMBRE" ></asp:TextBox><asp:Button class="btn" ID="BtnBuscar2" runat="server" Text="BUSCAR" />
    <asp:TextBox ID="TxtRol" runat="server" placeholder="ROL" ></asp:TextBox><asp:Button class="btn" ID="BtnBuscar3" runat="server" Text="BUSCAR" />
    <table class="auto-style1">
        <tr>
            <td>RUT</td>
            <td>NOMBRE</td>
            <td>APELLIDO</td>
            <td>TELEFONO</td>
            <td>DIRECCION</td>
            <td>ROL</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:Label ID="LbRut1" runat="server" Text="11.111.111-1"></asp:Label></td>
            <td><asp:Label ID="LbNombre1" runat="server" Text="BENITO"></asp:Label></td>
            <td><asp:Label ID="LbApellido1" runat="server" Text=" MALO"></asp:Label></td>
            <td><asp:Label ID="LbTelefono" runat="server" Text="+56911111111"></asp:Label></td>
            <td><asp:Label ID="LbDireccion" runat="server" Text="YEYEYEYEYEYE"></asp:Label></td>
            <td><asp:Label ID="LbRol1" runat="server" Text="TRAPERO"></asp:Label></td>
            <td><asp:ImageButton class="BtnForm" ID="ImageButton3" runat="server" Height="30px" Width="30px" ImageUrl="~/IMG/edit.png" /></td>
            <td><asp:ImageButton class="BtnForm" ID="ImageButton4" runat="server" Height="30px" Width="30px" ImageUrl="~/IMG/delete.png" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="LbRut2" runat="server" Text=" "></asp:Label></td>
            <td><asp:Label ID="LbNombre2" runat="server" Text=" "></asp:Label></td>
            <td><asp:Label ID="LbApellido2" runat="server" Text=" "></asp:Label></td>
            <td><asp:Label ID="LbTelefono2" runat="server" Text=" "></asp:Label></td>
            <td><asp:Label ID="LbDireccion2" runat="server" Text=" "></asp:Label></td>
            <td><asp:Label ID="LbRol" runat="server" Text=" "></asp:Label></td>
            <td><asp:ImageButton class="BtnForm" ID="ImageButton1" runat="server" Height="30px" Width="30px" ImageUrl="~/IMG/edit.png" /></td>
            <td><asp:ImageButton class="BtnForm" ID="ImageButton2" runat="server" Height="30px" Width="30px" ImageUrl="~/IMG/delete.png" /></td>
        </tr>
    </table>
    <br />

</asp:Content>
