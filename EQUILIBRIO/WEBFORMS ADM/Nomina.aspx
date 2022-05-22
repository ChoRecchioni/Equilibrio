<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="Nomina.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web15" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 110%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="NÓMINA"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Contenedor">
        <asp:TextBox class="TxtNomina" ID="TxtRut" runat="server" placeholder="RUT"></asp:TextBox>
        <asp:Button class="BtnBN" ID="BtnBuscar1" runat="server" Text="BUSCAR" />
        <asp:TextBox class="TxtNomina" ID="TxtNombre" runat="server" placeholder="NOMBRE"></asp:TextBox>
        <asp:Button class="BtnBN" ID="BtnBuscar2" runat="server" Text="BUSCAR" />
        <asp:TextBox class="TxtNomina" ID="TxtRol" runat="server" placeholder="ROL"></asp:TextBox>
        <asp:Button class="BtnBN" ID="BtnBuscar3" runat="server" Text="BUSCAR" />

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>
