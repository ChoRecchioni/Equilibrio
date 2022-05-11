<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="AgregarReseña.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="star-rating">
        <asp:DropDownList ID="DropLocal" runat="server"></asp:DropDownList><br />

        <asp:RadioButton ID="star5" type="radio" name="rating" value="5" runat="server" />
        <asp:Label for="star-5" title="5 stars" runat="server" >
            <i class="active fa fa-star" aria-hidden="true"></i>
        </asp:Label>
         <asp:RadioButton ID="star4" type="radio" name="rating" value="4" runat="server" />
        <asp:Label for="star-4" title="4 stars" runat="server" >
            <i class="active fa fa-star" aria-hidden="true"></i>
        </asp:Label>
         <asp:RadioButton ID="star3" type="radio" name="rating" value="3" runat="server" />
        <asp:Label for="star-3" title="3 stars" runat="server" >
            <i class="active fa fa-star" aria-hidden="true"></i>
        </asp:Label>
         <asp:RadioButton ID="star2" type="radio" name="rating" value="2" runat="server" />
        <asp:Label for="star-2" title="2 stars" runat="server" >
            <i class="active fa fa-star" aria-hidden="true"></i>
        </asp:Label>
         <asp:RadioButton ID="star1" type="radio" name="rating" value="1" runat="server" />
        <asp:Label for="star-1" title="1 stars" runat="server" >
            <i class="active fa fa-star" aria-hidden="true"></i>
        </asp:Label><br />

        <asp:TextBox ID="TxtComentario" runat="server" placeholder="COMENTARIO:"></asp:TextBox>

        <asp:Button class="btn" ID="BtnIngresar" runat="server" Text="INGRESAR" />


    </div>
</asp:Content>
