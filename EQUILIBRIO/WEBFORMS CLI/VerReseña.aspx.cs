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
                //Se crear un objeto DIV dinamico por cada reseña
                HtmlGenericControl divResena = new HtmlGenericControl("div");
                
                divResena.Attributes.Add("class", "Reseña");

                ///Genero la etiqueta titulo
                //Label labelTitulo = new Label();
                //labelTitulo.Text = item.Puntuacion.ToString();
                //labelTitulo.CssClass = "LblTitulo";
                //divResena.Controls.Add(labelTitulo);

                for (int i = 0 ; i < item.Puntuacion ; i++)
                {
                    //Genero Imagen de estrella
                    Image imgTitulo = new Image();
                    imgTitulo.Height = 20;
                    imgTitulo.Width = 20;
                    imgTitulo.Style.Add("vertical-align", "bottom");
                    imgTitulo.ImageUrl = "~/IMG/full-star.png";
                    
                    divResena.Controls.Add(imgTitulo);
                }

                //Genero Label tirulo Comentario
                Label labelTituloComentario = new Label();
                labelTituloComentario.CssClass = "LblTitulo";
                labelTituloComentario.Text = "  - COMENTARIO:";

                //Genero Label de comenario
                Label labelComentario = new Label();
                labelComentario.CssClass = "Lbl";
                labelComentario.Text = item.Comentario;

                //Agrego los objetos al nuevo DIV
                
                
                divResena.Controls.Add(labelTituloComentario);
                divResena.Controls.Add(labelComentario);

                //Luego agrego el nuevo div con 1 comentario al DIV principal
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