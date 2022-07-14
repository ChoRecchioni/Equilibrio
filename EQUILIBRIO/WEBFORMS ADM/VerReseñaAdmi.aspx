<%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="VerReseñaAdmi.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 400%;
        }
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
    <asp:DropDownList class="DropStars" ID="FiltroEstrellas" runat="server" OnSelectedIndexChanged="FiltroEstrellas_SelectedIndexChanged" AutoPostBack="true" AppendDataBoundItems="true">
       <asp:ListItem Text="TODOS LAS RESEÑAS" Value="0" />
        <asp:ListItem Value="1" >★</asp:ListItem>
        <asp:ListItem Value="2" >★★</asp:ListItem>
        <asp:ListItem Value="3" >★★★</asp:ListItem>
        <asp:ListItem Value="4" >★★★★</asp:ListItem>
        <asp:ListItem Value="5" >★★★★★</asp:ListItem>        
    </asp:DropDownList>
 </ContentTemplate>
                </asp:UpdatePanel>

                <asp:UpdatePanel ID="UPR" runat="server">
                    <ContentTemplate>
                        <div id="DivResenas" runat="server">
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="FiltroEstrellas" EventName="selectedindexchanged" />
                    </Triggers>
                </asp:UpdatePanel>
  
             </div>
     </ContentTemplate>
         </asp:UpdatePanel>
</asp:Content>
