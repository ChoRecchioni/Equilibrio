<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="CartaAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .BtnForm {
            float: right;
            margin-left: 20px;
            margin-bottom: 10px;
        }
        .PrecProd {
            margin-top: -20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="CARTA"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Contenedor">
        <div class="CategoriaCarta" >
            <label class="LblTituloCarta">CATEGORÍA</label><br />
            <div class="ProductoCarta" >
                <div class="NomPCarta">
                    <asp:Label class="LblTitulo" ID="Label2" runat="server" Text="Nombre del producto"></asp:Label>
                </div>
                <br /><br />
                <div class="PrecProd">
                    <asp:ImageButton class="BtnForm" ID="BtnDelete" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" />
                    <asp:ImageButton class="BtnForm" ID="BtnEdit" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" /><br />
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
                <br /><br />
                <div class="PrecProd">
                    <asp:ImageButton class="BtnForm" ID="ImageButton1" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" />
                    <asp:ImageButton class="BtnForm" ID="ImageButton2" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" /><br />
                    <asp:Label class="Lbl" ID="Label6" runat="server" Text="$10.000.-"></asp:Label>
                </div>
                <div class="InfoPCarta" >
                    <asp:Label class="Lbl" ID="Label7" runat="server" Text="Información"></asp:Label>
                </div>
            </div>
        </div>

        <div class="CategoriaCarta" >
            <label class="LblTituloCarta" >CATEGORÍA</label><br />
            <div class="ProductoCarta">
                <div class="NomPCarta">
                    <asp:Label class="LblTitulo" ID="Label8" runat="server" Text="Nombre del producto"></asp:Label>
                </div>
                <br /><br />
                <div class="PrecProd">
                    <asp:ImageButton class="BtnForm" ID="ImageButton3" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" />
                    <asp:ImageButton class="BtnForm" ID="ImageButton4" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" /><br />
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
                <br /><br />
                <div class="PrecProd">
                    <asp:ImageButton class="BtnForm" ID="ImageButton5" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/delete.png" />
                    <asp:ImageButton class="BtnForm" ID="ImageButton6" runat="server" Height="20px" Width="20px" ImageUrl="~/IMG/edit.png" /><br />
                    <asp:Label class="Lbl" ID="Label12" runat="server" Text="$10.000.-"></asp:Label>
                </div>
                <div class="InfoPCarta">
                    <asp:Label class="Lbl" ID="Label13" runat="server" Text="Información"></asp:Label>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
