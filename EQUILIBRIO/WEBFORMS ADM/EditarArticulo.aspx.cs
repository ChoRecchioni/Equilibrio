using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarDropCat();
                cargarTxt();
            }

        }

        protected void Bnt_Actualizar(object sender, EventArgs e)
        {
            string IdA = Request.QueryString["ID"];

            ArticuloController.editArticulo(IdA, TxtTitulo.Text, Txtprecio.Text, TxtInfo.Text, DropCategoria.SelectedValue);
            Response.Redirect("CartaAdmi.aspx");
        }

        public void cargarDropCat()
        {

            DropCategoria.DataSource = from cat in CategoriaController.findAll()
                                       select new
                                       {
                                           codigo = cat.codigo,
                                           texto = cat.nombre,
                                       };
            DropCategoria.DataValueField = "codigo";
            DropCategoria.DataTextField = "texto";

            DropCategoria.DataBind();
        }

        public void cargarTxt() {

            string IdA = Request.QueryString["ID"];

            Artículo artículo = ArticuloController.FindArticulo(int.Parse(IdA));

            TxtTitulo.Text = artículo.nombre;
            Txtprecio.Text = artículo.precio;
            TxtInfo.Text = artículo.comentario;


        }
    }
}