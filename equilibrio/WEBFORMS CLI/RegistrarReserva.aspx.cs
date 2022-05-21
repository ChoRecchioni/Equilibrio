using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Controller;
using equilibrio.Clases;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReservaController.CargarReserva();
            SedeController.CargarSedes();

            if (!Page.IsPostBack)
            {
                cargarDropSedes();
            }
        }

        public void cargarDropSedes()
        {

            DropLocal.DataSource = from sed in SedeController.FindAll()
                                   select new
                                   {
                                       codigo = sed.Codigo,
                                       texto = sed.Nombre,
                                   };
            DropLocal.DataValueField = "codigo";
            DropLocal.DataTextField = "texto";

            DropLocal.DataBind();
        }
    }
}