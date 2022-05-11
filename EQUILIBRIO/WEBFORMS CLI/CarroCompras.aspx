<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="CarroCompras.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web110" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table >
        <tr>
            <td class="auto-style5">PRODUCTO</td>
            <td class="auto-style3">CANTIDAD</td>
            <td class="auto-style4">PRECIO</td>
        </tr>
        <tr>
            <td >
                <asp:TextBox ID="TxtProducto1" runat="server" placeholder="PRODUCTO" Enabled="false"></asp:TextBox>
            </td>
            <td class="auto-style3"> 
                <asp:Button class="btn" ID="BtnMenor1" runat="server" Text="-" Width="30px" />
                <asp:TextBox ID="TxtCantida1" runat="server" Width="45px" Enabled="false"></asp:TextBox>
                <asp:Button class="btn" ID="BtnMayor1" runat="server" Text="+" Width="30px" />
            </td>
            <td >
                <asp:TextBox ID="TxtPrecio1" runat="server" placeholder="PRECIO" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                <asp:TextBox ID="TxtProducto2" runat="server" placeholder="PRODUCTO" Enabled="false"></asp:TextBox>
            </td>
            <td >
                <asp:Button class="btn" ID="BtnMenor2" runat="server" Text="-" Width="30px" />
                <asp:TextBox ID="TxtCantida2" runat="server" Width="45px" Enabled="false"></asp:TextBox>
                <asp:Button class="btn" ID="BtnMayor2" runat="server" Text="+"  Width="30px" />
            </td>
            <td >
                <asp:TextBox  ID="TxtPrecio2" runat="server" placeholder="PRECIO" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                <asp:TextBox ID="TxtProducto3" runat="server" placeholder="PRODUCTO" Enabled="false"></asp:TextBox>
            </td>
            <td >
                <asp:Button class="btn" ID="BtnMenor3" runat="server" Text="-" Width="30px" />
                <asp:TextBox ID="TxtCantida3" runat="server" Width="45px" Enabled="false"></asp:TextBox>
                <asp:Button class="btn" ID="BtnMayor3" runat="server" Text="+" Width="30px" />
            </td>
            <td >
                <asp:TextBox ID="TxtPrecio3" runat="server" placeholder="PRECIO" Enabled="false"></asp:TextBox>
            </td>
        </tr>
    </table>

    <br />
    <br />

    <asp:TextBox ID="TxtComentario" runat="server" placeholder="COMENTARIO AL LOCAL:" ></asp:TextBox><br />
    <asp:DropDownList ID="DropDireccion" runat="server"></asp:DropDownList><br />
    <asp:Label ID="LbMetodo" runat="server" Text="METODO DE PAGO"></asp:Label><br />
    <asp:RadioButton ID="RbCredito" runat="server" Text="Credito" GroupName="Metodo" />
    <asp:RadioButton ID="RbDebito" runat="server" Text="Debito" GroupName="Metodo"/><br />

    <asp:Button class="btn" ID="BtnPagar" runat="server" Text="PAGAR" />

</asp:Content>
