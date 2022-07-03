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
            GenerarArticulo();
        }


        public void GenerarArticulo()
        {
            var listadoArt = from ar in ArticuloController.findAll()
                             select new
                             {
                                 Nombre = ar.nombre,
                                 Comentario = ar.comentario,
                                 Precio = ar.precio,
                                 Categoria = ar.Categoria,
                             };

            var listadoCat = from cat in CategoriaController.findAll()
                             select new
                             {
                                 Nombre = cat.nombre
                             };

            foreach (var it in listadoCat)
            {
                HtmlGenericControl divCat = new HtmlGenericControl("div");
                divCat.Attributes.Add("class", "CategoriaCarta");

                Label LblTituloCarta = new Label();
                LblTituloCarta.Attributes.Add("class", "LblTituloCartaCat");
                LblTituloCarta.Text = it.Nombre;

                divCat.Controls.Add(LblTituloCarta);

                foreach (var item in listadoArt.Where(li => li.Categoria.nombre == it.Nombre))
                {
                    //generamos objeto DIV por cada articulo

                    HtmlGenericControl divArt = new HtmlGenericControl("div");
                    divArt.Attributes.Add("class", "ProductoCarta");

                    HtmlGenericControl NomPCarta = new HtmlGenericControl("div");
                    NomPCarta.Attributes.Add("class", "NomPCarta");

                    Label LblTitulo = new Label();
                    LblTitulo.Attributes.Add("class", "LblTituloCarta");
                    LblTitulo.Text = item.Nombre;
                    HtmlGenericControl br = new HtmlGenericControl("br");

                    NomPCarta.Controls.Add(LblTitulo);

                    HtmlGenericControl PrecProd = new HtmlGenericControl("div");
                    PrecProd.Attributes.Add("class", "PrecProd");

                    Label Lblprecio = new Label();
                    Lblprecio.Attributes.Add("class", "Lbl");
                    Lblprecio.Text = "$" + item.Precio + ".-";
                    Lblprecio.Attributes.Add("style", "font-weight: bold;");

                    PrecProd.Controls.Add(Lblprecio);

                    HtmlGenericControl InfoPCarta = new HtmlGenericControl("div");
                    InfoPCarta.Attributes.Add("class", "InfoPCarta");

                    Label LblInfo = new Label();
                    LblInfo.Attributes.Add("class", "Lbl");
                    LblInfo.Text = item.Comentario;

                    InfoPCarta.Controls.Add(LblInfo);

                    divArt.Controls.Add(NomPCarta);
                    divArt.Controls.Add(new LiteralControl("<br/>"));
                    divArt.Controls.Add(PrecProd);
                    divArt.Controls.Add(new LiteralControl("<br/>"));
                    divArt.Controls.Add(InfoPCarta);

                    divCat.Controls.Add(divArt);
                }
                divCartas.Controls.Add(divCat);

            }
        }
    }
}