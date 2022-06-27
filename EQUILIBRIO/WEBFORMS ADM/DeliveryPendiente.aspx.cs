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
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Pendientes()
        {
            EstadoDeliveryController.CargarEstado();
            DeliveryController.CargarDelivery();
            List<Delivery> listaDelivery =  DeliveryController.FindAll();

            foreach (Delivery item in listaDelivery.Where(L => L.Estado.Codigo == 1))
            {
                HtmlGenericControl divDet = new HtmlGenericControl("div");
                divDet.Attributes.Add("class", "divDet");
            }            
        }

    }
}