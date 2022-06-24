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
            width: 60%;
        }

        .auto-style12 {
            width: 100px;
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
            <div class="Contenedor" id="TablaCarro" runat="server">

                <br />
                <br />

                <table class="auto-style4">
                    <tr>
                        <td class="auto-style7" rowspan="2">DIRECCIÓN: </td>
                        <td class="auto-style5">
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Button class="BtnOK" ID="BtnPagar" runat="server" Text="PAGAR" OnClick="BtnPagar_Click" />
                        </td>
                    </tr>
                </table>
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
