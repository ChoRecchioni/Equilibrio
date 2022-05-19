<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="AgregarArticulo.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .Contenedor {
            margin-top: 40px;
        }
        #TxtDescripción {
            height: 200px;
        }
        .BtnOK {
            margin-left: 650px;
        }
        .Drop {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label2" runat="server" Text="ARTÍCULO"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Contenedor">
        <asp:DropDownList class="Drop" ID="DropCategoria" runat="server" >

        </asp:DropDownList><br />
        <asp:TextBox class="Txt" ID="TxtProducto" runat="server" placeholder="NOMBRE"></asp:TextBox><br />
        <asp:TextBox class="Txt" ID="TxtDescripcion" runat="server" placeholder="DESCRIPCIÓN" ></asp:TextBox><br />
        <asp:TextBox class="Txt" ID="TxtPrecio" runat="server" placeholder="PRECIO"></asp:TextBox><br />
        <asp:Button class="BtnOK" ID="BtnAgregar" runat="server" Text="confirmar" />
    </div>
</asp:Content>
