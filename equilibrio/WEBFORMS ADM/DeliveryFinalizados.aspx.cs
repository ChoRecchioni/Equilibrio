using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Clases;
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
            EstadoDeliveryController.CargarEstado();
            DeliveryController.CargarDelivery();
            List<Delivery> listaDelivery = DeliveryController.FindAll();

            foreach (Delivery item in listaDelivery.Where(L => L.Estado.Codigo == 4 && L.Orden.Local.Codigo == u.Local.Codigo))
            {

                HtmlGenericControl divDet = new HtmlGenericControl("div");
                divDet.Attributes.Add("class", "divDet");
                Label lblNPed = new Label();
                lblNPed.Attributes.Add("class", "Lbl");
                lblNPed.Text = "N° DE PEDIDO: " + item.NumPedido;
                Label lblNombreC = new Label();
                lblNombreC.Attributes.Add("class", "Lbl");
                lblNombreC.Text = "CLIENTE: " + item.Orden.Carro.user.Nombre + " " + item.Orden.Carro.user.Apellido;
                Label lblTelC = new Label();
                lblTelC.Attributes.Add("class", "Lbl");
                lblTelC.Text = "TELÉFONO: " + item.Orden.Carro.user.Telefono;
                Label lblDireC = new Label();
                lblDireC.Attributes.Add("class", "Lbl");
                lblDireC.Text = "DIRECCIÓN: " + item.Orden.Carro.user.Direccion.CalleYnum + ", " + item.Orden.Carro.user.Direccion.Depto + ", " + item.Orden.Carro.user.Direccion.Comuna;
                divDet.Controls.Add(lblNPed);
                divDet.Controls.Add(lblNombreC);
                divDet.Controls.Add(lblTelC);
                divDet.Controls.Add(lblDireC);

                HtmlGenericControl divArt = new HtmlGenericControl("div");
                divArt.Attributes.Add("class", "divArt");

                List<Articulo_Carro> articulos = OrdenCompraController.FindOrden(item.Orden.Codigo.ToString()).Carro.ArtCar;

                foreach (Articulo_Carro ar in articulos)
                {
                    Label lblArt = new Label();
                    lblArt.Attributes.Add("class", "Lbl");
                    lblArt.Text = ar.Artículo.Nombre;
                    Label lblCant = new Label();
                    lblCant.Attributes.Add("class", "Lbl");
                    lblCant.Text = "X " + ar.Cantidad.ToString();

                    divArt.Controls.Add(lblArt);
                    divArt.Controls.Add(lblCant);
                }

                //HtmlGenericControl divBut = new HtmlGenericControl("div");
                //divBut.Attributes.Add("class", "divBot");
                //ImageButton btnCheck = new ImageButton();
                //btnCheck.CssClass = "BtnForm";
                //btnCheck.Height = 20;
                //btnCheck.Width = 20;
                //btnCheck.ImageUrl = "~/IMG/check.png";
                //btnCheck.OnClientClick = "return EditarDelivery('" + item.Codigo.ToString() + "');";
                //btnCheck.ID = item.Codigo.ToString();
                //divBut.Controls.Add(btnCheck);

                Deliverys.Controls.Add(divDet);
                Deliverys.Controls.Add(divArt);
                //Deliverys.Controls.Add(divBut);
            }

        }

    }
}