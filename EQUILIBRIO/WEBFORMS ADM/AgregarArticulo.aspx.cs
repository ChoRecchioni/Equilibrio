using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Controller;
using equilibrio.Clases;

namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["ActiveUser"];

            if (u == null)
            {
                Response.Redirect("IniciarSesión.aspx");
            }

            ArticuloController.CargarArticulo();
            CategoriaController.CargarCategoria();


            if (!Page.IsPostBack)
            {
                cargarDropCat();
            }

        }

        public void cargarDropCat()
        {
            CategoriaController.CargarCategoria();

            DropCategorias.DataSource = from cat in CategoriaController.FindAll()
                                   select new
                                   {
                                       codigo = cat.Codigo,
                                       texto = cat.Nombre,
                                   };
            DropCategorias.DataValueField = "codigo";
            DropCategorias.DataTextField = "texto";

            DropCategorias.DataBind();
        }
    }
}