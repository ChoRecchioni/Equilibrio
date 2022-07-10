using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pendientes();
        }

        public void Pendientes()
        {
            Usuario u = (Usuario)Session["ActiveUser"];

            var listaDelivery = DeliveryController.findAll();

            foreach (Delivery item in listaDelivery.Where(L => L.EstadoDelivery.codigo == 1 && L.OrdenCompra.Sede.codigo == u.Sede.codigo))
            {

                HtmlGenericControl divDet = new HtmlGenericControl("div");
                divDet.Attributes.Add("class", "divDet");
                divDet.Style.Add("float", "left");
                divDet.Style.Add("width", "40%");

                Label lblNPed = new Label();
                lblNPed.Attributes.Add("class", "Lbl");
                lblNPed.Text = "N° DE PEDIDO: " + item.numPedido;
                Label lblNombreC = new Label();
                lblNombreC.Attributes.Add("class", "Lbl");
                lblNombreC.Text = "CLIENTE: " + item.OrdenCompra.CarroCompras.Usuario.nombre + " " + item.OrdenCompra.CarroCompras.Usuario.apellido;
                Label lblTelC = new Label();
                lblTelC.Attributes.Add("class", "Lbl");
                lblTelC.Text = "TELÉFONO: " + item.OrdenCompra.CarroCompras.Usuario.telefono;
                Label lblDireC = new Label();
                lblDireC.Attributes.Add("class", "Lbl");
                lblDireC.Text = "DIRECCIÓN: " + item.OrdenCompra.CarroCompras.Usuario.Direccion.calleYnum + ", " + item.OrdenCompra.CarroCompras.Usuario.Direccion.depto + ", " + item.OrdenCompra.CarroCompras.Usuario.Direccion.Comuna.nombre;

                divDet.Controls.Add(lblNPed);
                divDet.Controls.Add(new LiteralControl("<br/>"));
                divDet.Controls.Add(lblNombreC);
                divDet.Controls.Add(new LiteralControl("<br/>"));
                divDet.Controls.Add(lblTelC);
                divDet.Controls.Add(new LiteralControl("<br/>"));
                divDet.Controls.Add(lblDireC);
                divDet.Controls.Add(new LiteralControl("<br/>"));

                HtmlGenericControl divArt = new HtmlGenericControl("div");
                divArt.Attributes.Add("class", "divArt");
                divArt.Style.Add("float", "left");
                divArt.Style.Add("width", "40%");

                List<ArticuloCarro> articulos = OrdenCompraController.FindOrden(item.OrdenCompra.codigo).CarroCompras.ArticuloCarro.ToList();

                foreach (ArticuloCarro ar in articulos)
                {
                    Label lblArt = new Label();
                    lblArt.Attributes.Add("class", "Lbl");
                    lblArt.Text = ar.Artículo.nombre;
                    lblArt.Style.Add("font-weight", "bold");
                    Label lblCant = new Label();
                    lblCant.Attributes.Add("class", "Lbl");
                    lblCant.Text = "x " + ar.cantidad.ToString();
                    lblCant.Style.Add("font-weight", "bold");
                    lblCant.Style.Add("float", "right");

                    divArt.Controls.Add(lblArt);
                    divArt.Controls.Add(lblCant);
                    divArt.Controls.Add(new LiteralControl("<br/>"));
                }

                HtmlGenericControl divBut = new HtmlGenericControl("div");
                divBut.Attributes.Add("class", "divBut");
                divBut.Style.Add("float", "right");

                ImageButton btnCheck = new ImageButton();
                btnCheck.CssClass = "BtnForm";
                btnCheck.Height = 30;
                btnCheck.Width = 30;
                btnCheck.ImageUrl = "~/IMG/check.png";
                btnCheck.OnClientClick = "return EditarDelivery('" + item.codigo.ToString() + "');";
                btnCheck.ID = item.codigo.ToString();
                divBut.Controls.Add(btnCheck);

                Deliverys.Controls.Add(divDet);
                Deliverys.Controls.Add(divArt);
                Deliverys.Controls.Add(divBut);
            }

        }

        [WebMethod]
        public static object FinalizarDelivery(string id)
        {
            try
            {
                Delivery delivery = DeliveryController.FindDelivery(int.Parse(id));
                DeliveryController.editDelivery(delivery.codigo.ToString(), "2");

                return new
                {
                    error = false,
                    msg = ""
                };
            }
            catch (Exception e)
            {
                return new
                {
                    error = true,
                    msg = e.Message
                };
            }
        }
    }

}