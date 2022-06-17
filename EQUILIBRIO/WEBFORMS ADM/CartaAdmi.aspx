<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="CartaAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web14" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="CARTA"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- Los label vienen por cs. Al editar, cambian por txt. 
         También por cs. (ver WEBFORMS.CLI/VerReseña.aspx.cs)--%>

    <div class="Contenedor">

        <div class="HeadCarta">            
            <asp:TextBox class="Txt" ID="TxtNombreArt" runat="server" placeholder="NOMBRE"></asp:TextBox>
            <asp:TextBox class="Txt" ID="TxtDescripcionArt" runat="server" placeholder="DESCRIPCIÓN"></asp:TextBox><br />

            <asp:TextBox class="Txt" ID="TxtPrecioArt" runat="server" placeholder="PRECIO"></asp:TextBox>
            <asp:DropDownList class="Drop" ID="DropCategoria" runat="server" Height="30px"></asp:DropDownList><br />
        
            <asp:Button class="BtnOK" ID="BtnCrearArt" runat="server" Text="confirmar" OnClick="BtnCrearArt_Click" />

            <asp:Label ID="LbAddArt" runat="server" Text=""></asp:Label>
        </div>        
            

        <div class="CategoriaCarta" id="DivCartas" runat="server">
           <%-- <label class="LblTituloCarta">CATEGORÍA</label><br />

            <div class="ProductoCarta">
                <div class="NomPCarta">
                    <asp:Label class="LblTitulo" ID="Label2" runat="server" Text="Nombre del producto"></asp:Label><br />
                    <asp:Label class="Lbl" ID="Label3" runat="server" Text="Información"></asp:Label>
                </div>

                <div class="PrecProd">
                    <asp:Label class="Lbl" ID="Label4" runat="server" Text="$10.000.-"></asp:Label><br />
                    <asp:ImageButton class="BtnCarta" ID="BtnDltCarta" ImageUrl="~/IMG/delete.png" runat="server" />
                    <asp:ImageButton class="BtnCarta" ID="BtnEditCarta" ImageUrl="~/IMG/edit.png" runat="server" />
                </div>
            </div>
            <br />        

            <div class="EditarProductoCarta">
                <div class="NomPCarta">
                    <asp:TextBox class="TxtCarta" ID="TxtNom" placeholder="NOMBRE DEL PRODUCTO" runat="server"></asp:TextBox><br />
                    <asp:TextBox class="TxtCarta" ID="TxtInfo" runat="server" placeholder="Información"></asp:TextBox>
                </div>

                <div class="PrecProd">
                    <asp:TextBox class="TxtCarta" ID="TxtPrecio" placeholder="$10.000.-" runat="server"></asp:TextBox><br />
                    <asp:ImageButton class="BtnCarta" ID="BtnSaveCarta" ImageUrl="~/IMG/check.png" runat="server"/>
                </div>
            </div>--%>
        </div>
    </div>
</asp:Content>
