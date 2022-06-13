<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="Carta.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="CARTA"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Los label vienen por cs. Al editar, cambian por txt. 
         También por cs. (ver WEBFORMS.CLI/VerReseña.aspx.cs)
        
        Ver CartaAdmi para arreglar formato:
        --%>
    
    <div class="Contenedor">
        <div class="CategoriaCarta">
            <label class="LblTituloCarta">CATEGORÍA</label><br />
            <div class="ProductoCarta">
                <div class="NomPCarta">
                    <asp:Label class="LblTitulo" ID="Label2" runat="server" Text="Nombre del producto"></asp:Label>
                </div>
                <br />
                <br />
                <div class="PrecProd">
                    <asp:Label class="Lbl" ID="Label4" runat="server" Text="$10.000.-"></asp:Label>
                </div>
                <div class="InfoPCarta">
                    <asp:Label class="Lbl" ID="Label3" runat="server" Text="Información"></asp:Label>
                </div>
            </div>
            <div class="ProductoCarta">
                <div class="NomPCarta">
                    <asp:Label class="LblTitulo" ID="Label5" runat="server" Text="Nombre del producto"></asp:Label>
                </div>
                <br />
                <br />
                <div class="PrecProd">
                    <asp:Label class="Lbl" ID="Label6" runat="server" Text="$10.000.-"></asp:Label>
                </div>
                <div class="InfoPCarta">
                    <asp:Label class="Lbl" ID="Label7" runat="server" Text="Información"></asp:Label>
                </div>
            </div>
        </div>

        <div class="CategoriaCarta" >
            <label class="LblTituloCarta">CATEGORÍA</label><br />
            <div class="ProductoCarta">
                <div class="NomPCarta">
                    <asp:Label class="LblTitulo" ID="Label8" runat="server" Text="Nombre del producto"></asp:Label>
                </div>
                <br />
                <br />
                <div class="PrecProd">
                    <asp:Label class="Lbl" ID="Label9" runat="server" Text="$10.000.-"></asp:Label>
                </div>
                <div class="InfoPCarta">
                    <asp:Label class="Lbl" ID="Label10" runat="server" Text="Información"></asp:Label>
                </div>
            </div>
            <div class="ProductoCarta">
                <div class="NomPCarta">
                    <asp:Label class="LblTitulo" ID="Label11" runat="server" Text="Nombre del producto"></asp:Label>
                </div>
                <br />
                <br />
                <div class="PrecProd">
                    <asp:Label class="Lbl" ID="Label12" runat="server" Text="$10.000.-"></asp:Label>
                </div>
                <div class="InfoPCarta">
                    <asp:Label class="Lbl" ID="Label13" runat="server" Text="Información"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
