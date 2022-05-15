<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="AgregarReseña.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web19" %>
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
    <asp:Label class="titulos" ID="Label1" runat="server" Text="AÑADIR RESEÑA"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Contenedor">
        <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
        <asp:DropDownList class="Drop" ID="DropLocal" runat="server">
            <asp:ListItem Text="SELECCIONE UN LOCAL" Value="0" />
            <asp:ListItem Text="SANTIAGO" Value="1" />
            <asp:ListItem Text="PROVIDENCIA" Value="2" />
            <asp:ListItem Text="ÑUÑOA" Value="3" />
            <asp:ListItem Text="MAIPÚ" Value="4" />
            <asp:ListItem Text="VIÑA DEL MAR" Value="5" />

        </asp:DropDownList></td>

                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <div class="rating">
                          <label>
                            <input type="radio" name="stars" value="1" />
                            <span class="icon">★</span>
                          </label>
                          <label>
                            <input type="radio" name="stars" value="2" />
                            <span class="icon">★</span>
                            <span class="icon">★</span>
                          </label>
                          <label>
                            <input type="radio" name="stars" value="3" />
                            <span class="icon">★</span>
                            <span class="icon">★</span>
                            <span class="icon">★</span>   
                          </label>
                          <label>
                            <input type="radio" name="stars" value="4" />
                            <span class="icon">★</span>
                            <span class="icon">★</span>
                            <span class="icon">★</span>
                            <span class="icon">★</span>
                          </label>
                          <label>
                            <input type="radio" name="stars" value="5" />
                            <span class="icon">★</span>
                            <span class="icon">★</span>
                            <span class="icon">★</span>
                            <span class="icon">★</span>
                            <span class="icon">★</span>
                          </label>
                        </div>
                            
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">                       
                        <asp:TextBox class="Txt" ID="TxtComentario" runat="server" placeholder="COMENTARIO:" Style="text-align-last: left; margin-top: -35px; padding-left: 5px;" Height="100px"></asp:TextBox></td>
                    </td>
                    <td class="auto-style5">
            <asp:Button class="BtnOK" ID="BtnEnviar" runat="server" Text="AGREGAR" style="margin-left: 300px;" OnClick="BtnEnviar_Click" />
                    </td>
                </tr>
            </table>
    </div>
</asp:Content>
