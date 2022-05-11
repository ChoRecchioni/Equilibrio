<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="RegistrarReserva.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Nueva Reserva"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Seleccione un local"></asp:Label><br />
    <asp:DropDownList ID="DropLocal" runat="server"></asp:DropDownList>
    <br />
    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
    <br />
     <asp:Label ID="Label3" runat="server" Text="Seleccione la hora"></asp:Label><br />
    <asp:DropDownList ID="DropHoras" runat="server"></asp:DropDownList><br />

     <asp:Label ID="Label4" runat="server" Text="Seleccione mesa disponible"></asp:Label><br />
    <asp:DropDownList ID="DropMesas" runat="server"></asp:DropDownList><br /> 
    <br />  

    <asp:TextBox ID="TxtCliente" type ="Hidden" runat="server" placeholder ="CLIENTE"></asp:TextBox><br />

    <asp:Button ID="Button1" runat="server" Text="Reservar" />
</asp:Content>
