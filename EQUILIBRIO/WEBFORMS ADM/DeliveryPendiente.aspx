                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <%@ Page Title="" Language="C#" MasterPageFile="~/WEBFORMS ADM/Admin.Master" AutoEventWireup="true" CodeBehind="DeliveryPendiente.aspx.cs" Inherits="equilibrio.WEBFORMS_ADM.Formulario_web12" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function EditarDelivery(id) {
            if (confirm("Finalizada?")) {
                $.ajax({
                    type: "post",
                    url: "DeliveryPendiente.aspx/FinalizarDelivery",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify({ id: id }),
                    dataType: "json",
                    success: function (response) {
                        if (!response.d.error) {
                            alert(response.d.msg);
                            window.location.reload();
                        }
                        else {
                            alert(response.d.msg);
                        }
                    },
                    error: function (response) {
                        alert("Error: " + response.d.msg);
                    },
                    async: true
                });
            }
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHtitulos" runat="server">
    <asp:Label class="titulos" ID="Label1" runat="server" Text="DELIVERY PENDIENTE"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdateMain" runat="server">
        <ContentTemplate>
            <div class="Contenedor" runat="server">
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
