<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="DeliveryFinalizados.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1000px;
        }

        .auto-style2 {
            width: 300px;
        }

        .auto-style3 {
            width: 50px;
        }

        .auto-style4 {
            width: 206px;
        }

        .auto-style5 {
            width: 40px;
        }

        .auto-style6 {
            width: 71px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="DELIVERYS FINALIZADOS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdateMain" runat="server">
        <ContentTemplate>
    <div class="Contenedor" runat="server">

      <%--  <br />
        <asp:TextBox ID="TxtNpedido" runat="server" placeholder="N° PEDIDO"></asp:TextBox><asp:Button class="btn" ID="Button1" runat="server" Text="Buscar" />
        <asp:TextBox ID="TxtCliente" runat="server" placeholder="CLIENTE"></asp:TextBox><asp:Button class="btn" ID="Button2" runat="server" Text="Buscar" />
        <asp:TextBox ID="TxtFecha" runat="server" placeholder="FECHA"></asp:TextBox><asp:Button class="btn" ID="Button3" runat="server" Text="Buscar" />--%>

        <div id="Deliverys" runat="server">

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
