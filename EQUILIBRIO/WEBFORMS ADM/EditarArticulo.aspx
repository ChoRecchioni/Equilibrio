<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="EditarArticulo.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHtitulos" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

     <div class="Contenedor">

         <asp:Label ID="Label1" runat="server" Text="Titulo"></asp:Label><br />
         <asp:TextBox ID="TxtTitulo" class="Txt" runat="server"></asp:TextBox><br />
         <br />

         <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label><br />
         <asp:TextBox ID="Txtprecio" class="Txt" runat="server"></asp:TextBox><br />
         <br />

         <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label><br />
         <asp:TextBox ID="TxtInfo" class="Txt" TextMode="MultiLine"  runat="server"></asp:TextBox><br />
         <br />

         <asp:DropDownList class="Drop" ID="DropCategoria" runat="server" Height="30px"></asp:DropDownList><br />

         <asp:Button ID="BtnEditar"  class="Btn" runat="server" Text="Actualizar" OnClick="Bnt_Actualizar"/>



     </div>

</asp:Content>
