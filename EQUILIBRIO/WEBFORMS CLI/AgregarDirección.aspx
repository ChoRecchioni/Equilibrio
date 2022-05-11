<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="AgregarDirección.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:TextBox ID="TxtAlias" runat="server" placeholder="ALIAS"></asp:TextBox><br />
        <asp:TextBox ID="TxtCalle" runat="server" placeholder="CALLE Y N°"></asp:TextBox><br />
        <asp:DropDownList ID="DropComuna" runat="server"></asp:DropDownList><br />
        <asp:DropDownList ID="DropRegion" runat="server"></asp:DropDownList><br />
        <asp:Button class="btn" ID="Button1" runat="server" Text="Confirmar" />
    </div>
</asp:Content>
