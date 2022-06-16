using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Controller;
using equilibrio.Clases;

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
            CategoriaController.CargarCategoria();
            ArticuloController.CargarArticulo();

            var listadoArt = from ar in ArticuloController.FindAll()
                             select new
                             {
                                 Nombre = ar.Nombre,
                                 Comentario = ar.Comentario,
                                 Precio = ar.Precio,
                                 Categoria = ar.Categoria,
                             };

            var listadoCat = from cat in CategoriaController.FindAll()
                             select new
                             {
                                 Nombre = cat.Nombre
                             };

            foreach (var it in listadoCat)
            {
                HtmlGenericControl divCat = new HtmlGenericControl("div");
                divCat.Attributes.Add("class", "CategoriaCarta");

                Label LblTituloCarta = new Label();
                LblTituloCarta.Attributes.Add("class", "LblTituloCarta");
                LblTituloCarta.Text = it.Nombre;

                divCat.Controls.Add(LblTituloCarta);

                foreach (var item in listadoArt.Where(li => li.Categoria.Nombre == it.Nombre))
                {
                    //generamos objeto DIV por cada articulo

                    HtmlGenericControl divArt = new HtmlGenericControl("div");
                    divArt.Attributes.Add("class", "ProductoCarta");

                    HtmlGenericControl NomPCarta = new HtmlGenericControl("div");
                    NomPCarta.Attributes.Add("class", "NomPCarta");

                    Label LblTitulo = new Label();
                    LblTitulo.Attributes.Add("class", "LblTitulo");
                    LblTitulo.Text = item.Nombre;

                    NomPCarta.Controls.Add(LblTitulo);

                    HtmlGenericControl PrecProd = new HtmlGenericControl("div");
                    PrecProd.Attributes.Add("class", "PrecProd");

                    Label Lblprecio = new Label();
                    Lblprecio.Attributes.Add("class", "Lbl");
                    Lblprecio.Text = item.Precio;

                    PrecProd.Controls.Add(Lblprecio);

                    HtmlGenericControl InfoPCarta = new HtmlGenericControl("div");
                    InfoPCarta.Attributes.Add("class", "InfoPCarta");

                    Label LblInfo = new Label();
                    LblInfo.Attributes.Add("class", "Lbl");
                    LblInfo.Text = item.Comentario;

                    InfoPCarta.Controls.Add(LblInfo);

                    divArt.Controls.Add(NomPCarta);
                    divArt.Controls.Add(PrecProd);
                    divArt.Controls.Add(InfoPCarta);

                    divCat.Controls.Add(divArt);                    
                }
                divCartas.Controls.Add(divCat);

            }
        }
    }
}