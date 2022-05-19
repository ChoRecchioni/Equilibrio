using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_CLI
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SedeController.CargarSedes();
            CargarGrid();
        }

        public void CargarGrid()
        {

           var listado = from re in ReseñaController.FindAll()
                                   select new
                                   {
                                       Sede = re.Sede.Nombre,
                                       Puntuacion = re.Puntuacion,
                                       Comentario = re.Comentario
                                   };
            GrdReseña.DataSource = listado.ToList();

            GrdReseña.DataBind();
        }
    }
}