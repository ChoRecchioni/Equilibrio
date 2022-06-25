<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="CarroCompras.aspx.cs" Inherits="equilibrio.WEBFORMS.Formulario_web110" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        table {
            margin-top: 20px;
            width: 100%;
        }

        .auto-style3 {
            width: 163px;
        }

        .auto-style4 {
            width: 100%;
        }

        .auto-style5 {
            height: 52px;
        }

        .auto-style7 {
            width: 608px;
        }

        .auto-style8 {
            margin-top: 20px;
            width: 60%;
            height: 35px;
        }

        .auto-style9 {
            width: 100px;
            height: 35px;
        }

        .auto-style10 {
            width: 163px;
            height: 35px;
        }

        .tr1 {
            height: 50px;
        }

        .tr2 {
            height: 35px
        }

        .auto-style11 {
            margin-top: 20px;
            width: 55%;
        }

        .auto-style12 {
            width: 100px;
            padding-left: 10px;
        }

        .auto-style13 {
            width: 128px;
        }

        .auto-style14 {
            width: 128px;
            height: 35px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label4" runat="server" Text="CARRO DE COMPRAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdateMain" runat="server">
        <ContentTemplate>
            <div class="Contenedor" runat="server">

                <table id="TablaCarro" runat="server">
                    <tr class="tr1" style="height: 50px;">
                        <td class="auto-style11">
                            <asp:Label class="LblTituloCarro" ID="LbProducto" runat="server" Text="PRODUCTO"></asp:Label></td>
                        <td class="auto-style12">
                            <asp:Label class="LblTituloCarro" ID="LbCantidad" runat="server" Text="CANTIDAD  "></asp:Label></td>
                        <td class="auto-style13">
                            <asp:Label class="LblTituloCarro" ID="LbPrecio" runat="server" Text="PRECIO U."></asp:Label>&nbsp;</td>
                        <td class="auto-style3">
                            <asp:Label ID="LbPrecio0" runat="server" class="LblTituloCarro" Text="SUBTOTAL"></asp:Label>
                        </td>
                    </tr>

                </table>

                <br />

                <div id="divDir" runat="server">
                    <asp:Label ID="Label1" runat="server" class="LblTituloCarro" Text="SELECCIONE SU SEDE MAS CERCANA:"></asp:Label>
                    <br />
                    <asp:DropDownList ID="DropLocal" class="Drop" runat="server"></asp:DropDownList>
                    <br />
                </div>
                <div style="text-align: -webkit-right;">
                    <asp:Label ID="LblAdd" runat="server" class="LblTituloCarro" style="display:none;" Text=""></asp:Label>
                    <asp:Button class="BtnOKDir" ID="BtnPagar" runat="server" Text="PAGAR" OnClick="BtnPagar_Click" />
                </div>
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
