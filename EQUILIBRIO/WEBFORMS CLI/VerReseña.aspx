<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS CLI/Cliente.Master" AutoEventWireup="true" CodeBehind="VerReseña.aspx.cs" Inherits="equilibrio.WEBFORMS_CLI.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="RESEÑAS"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdateMain" runat="server">

        <ContentTemplate>
            <asp:HiddenField ID="HdnRolCliente" runat="server" />

            <div class="Contenedor">
                <asp:UpdatePanel ID="UPC" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList class="Drop" ID="FiltroLocal" runat="server" OnSelectedIndexChanged="FiltroLocal_SelectedIndexChanged" AutoPostBack="true" AppendDataBoundItems="true">
                            <asp:ListItem Text="SELECCIONE UN LOCAL" Value="-1" />
                            <asp:ListItem Text="TODOS LOS LOCALES" Value="1" />
                            
                        </asp:DropDownList>
                    </ContentTemplate>
                </asp:UpdatePanel>

                <asp:UpdatePanel ID="UPR" runat="server">
                    <ContentTemplate>
                        <div id="DivResenas" runat="server">
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="FiltroLocal" EventName="selectedindexchanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
 </asp:Content>
