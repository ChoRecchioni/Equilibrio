using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_CLI
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDropSedes();
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

            foreach (var item in listado)
            {
                //Instanciamos/generamos objeto DIV por cada reseña (con n)
                HtmlGenericControl divResena = new HtmlGenericControl("div");
                
                divResena.Attributes.Add("class", "Reseña");

                //Si quisieramos generar la etiqueta título:
                //Label labelTitulo = new Label();
                //labelTitulo.Text = item.Puntuacion.ToString();
                //labelTitulo.CssClass = "LblTitulo";
                //divResena.Controls.Add(labelTitulo);

                //Recorremos las puntuaciones que trae, para generar
                //la cantidad de estrellas correspondiente
                for (int i = 0 ; i < item.Puntuacion ; i++)
                {
                    //Generamos la imagen de estrella
                    Image imgTitulo = new Image();
                    imgTitulo.Height = 20;
                    imgTitulo.Width = 20;
                    imgTitulo.Style.Add("vertical-align", "bottom");
                    imgTitulo.ImageUrl = "~/IMG/full-star.png";
                    
                    divResena.Controls.Add(imgTitulo);
                }

                //Generamos un Lbl con su clase de css de título
                Label labelTituloComentario = new Label();
                labelTituloComentario.CssClass = "LblTitulo";
                labelTituloComentario.Text = "  - COMENTARIO: ";

                //Generamos el comentario de cada reseNa
                Label labelComentario = new Label();
                labelComentario.CssClass = "Lbl";
                labelComentario.Text = item.Comentario;

                //Agregamos los objetos al nuevo div instanciado (linea 35)   
                divResena.Controls.Add(labelTituloComentario);
                divResena.Controls.Add(labelComentario);

                //Luego lo agregamos al div que tenemos en aspx "DivResenas" (con N)
                DivResenas.Controls.Add(divResena);
            }
        }



        public void CargarDropSedes()
        {
            SedeController.CargarSedes();

            FiltroLocal.DataSource = from sed in SedeController.FindAll()
                                     select new
                                     {
                                         codigo = sed.Codigo,
                                         texto = sed.Nombre,
                                     };
            FiltroLocal.DataValueField = "codigo";
            FiltroLocal.DataTextField = "texto";

            FiltroLocal.DataBind();
        }
    }
}