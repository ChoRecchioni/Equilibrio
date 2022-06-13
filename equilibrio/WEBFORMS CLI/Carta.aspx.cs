using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_CLI
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerarArticulo();
            }
        }


        public void GenerarArticulo()
        {
            ArticuloController.CargarArticulo();

            var listado = from ar in ArticuloController.FindAll()
                          select new
                          {
                              Nombre = ar.Nombre,
                              Comentario = ar.Comentario,
                              Precio = ar.Precio
                          };

            foreach (var item in listado)
            {
                //Instanciamos/generamos objeto DIV por cada reseña (con n)
                HtmlGenericControl divNom = new HtmlGenericControl("div");
                HtmlGenericControl divCom = new HtmlGenericControl("div");
                HtmlGenericControl divPre = new HtmlGenericControl("div");

                divNom.Attributes.Add("class", "Art");

                //Si quisieramos generar la etiqueta título:
                //Label labelTitulo = new Label();
                //labelTitulo.Text = item.Puntuacion.ToString();
                //labelTitulo.CssClass = "LblTitulo";
                //divResena.Controls.Add(labelTitulo);

                //Generamos un Lbl con su clase de css de título
                Label labelTituloArticulo = new Label();
                labelTituloArticulo.CssClass = "LblTitulo";
                labelTituloArticulo.Text = item.Nombre;

                //Generamos el comentario de cada reseNa
                Label labelComentario = new Label();
                labelComentario.CssClass = "Lb1";
                labelComentario.Text = "Descripción: " + item.Comentario;

                Label labelPrecio = new Label();
                labelPrecio.CssClass = "Lb1";
                labelPrecio.Text = "Precio: " + item.Precio;

                //Agregamos los objetos al nuevo div instanciado (linea 35)   
                divNom.Controls.Add(labelTituloArticulo);
                divPre.Controls.Add(labelPrecio);
                divCom.Controls.Add(labelComentario);

                //Luego lo agregamos al div que tenemos en aspx "divCarta" (con N)
                divNomArt.Controls.Add(divNom);
                divPrecio.Controls.Add(divPre);
                divComentario.Controls.Add(divCom);
            }
        }
    }
}