using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Finalizados();
        }

        public void Finalizados()
        {
            Usuario u = (Usuario)Session["ActiveUser"];
            List<Delivery> listaDelivery = DeliveryController.findAll();

            foreach (Delivery item in listaDelivery.Where(L => L.fk_estadoDeli == 4 && L.OrdenCompra.fk_sede == u.fk_sede))
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

                Deliverys.Controls.Add(divDet);
                Deliverys.Controls.Add(divArt);
            }
        }
    }
}