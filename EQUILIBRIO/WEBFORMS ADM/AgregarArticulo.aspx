<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="Formulario web1.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web18" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            margin-top: 30px;
            width: 75%;
        }

        .auto-style2 {
            width: 550px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="AÑADIR ARTÍCULO"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdateMain" runat="server">
        <ContentTemplate>            
            <asp:HiddenField ID="HdnRolCliente" runat="server" />

            <div class="Contenedor">
                <table class="auto-style1">
                    <tr style="height: 50px; vertical-align: top;">
                        <td class="auto-style2">
                            <asp:Label class="LblTitulo" ID="LbRegistro" runat="server" Text="INFORMACION DE ARTÍCULO"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextNombre" runat="server" placeholder="NOMBRE"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" class="ValidadorRegistro" ControlToValidate="TextNombre" runat="server" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                        </td>
                        </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:TextBox class="Txt" ID="TextPrecio" runat="server" placeholder="PRECIO"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" class="ValidadorRegistro" runat="server" ControlToValidate="TextPrecio" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:TextBox class="Txt" ID="TextComentario" runat="server" placeholder="COMENTARIO"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" class="ValidadorRegistro" runat="server" ControlToValidate="TextComentario" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>

                        </td>
                         </tr>

                     <tr>
                          <td class="auto-style2">
                            <asp:DropDownList class="Drop" ID="DropCategorias" runat="server">
                            </asp:DropDownList></td>

                        <td class="auto-style4">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Button class="BtnOK" ID="Button1" runat="server" Text="AGREGAR" Style="margin-left: 300px;"  />
                           
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
                <asp:Label ID="LbMensaje1" runat="server" Text=""></asp:Label>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdateProgress ID="Cargando" AssociatedUpdatePanelID="UpdateMain" runat="server">
        <ProgressTemplate>
            <div id="fondo"></div>
            <div class="load-9">
                <div class="spinner">
                    <div class="bubble-1"></div>
                    <div class="bubble-2"></div>
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>






</asp:Content>
