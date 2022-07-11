using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Controller;


namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarDropCat();
            }

            GenerarArticulo();
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

        public void GenerarArticulo()
        {
            var listadoArt = from ar in ArticuloController.findAll()
                             select new
                             {
                                 Codigo = ar.codigo,
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

                    TextBox TxtTitulo = new TextBox();
                    TxtTitulo.Attributes.Add("class", "Txt");
                    TxtTitulo.Attributes.Add("Disabled", "Disabled");
                    TxtTitulo.Text = item.Nombre;
                    HtmlGenericControl br = new HtmlGenericControl("br");

                    NomPCarta.Controls.Add(TxtTitulo);

                    HtmlGenericControl PrecProd = new HtmlGenericControl("div");
                    PrecProd.Attributes.Add("class", "PrecProd");

                     TextBox Txtprecio = new TextBox();
                    Txtprecio.Attributes.Add("class", "Txt");
                    Txtprecio.Attributes.Add("Disabled", "Disabled");
                    Txtprecio.Text = "$" + item.Precio + ".-";
                    Txtprecio.Attributes.Add("style", "font-weight: bold;");

                    ImageButton btnEditar = new ImageButton
                    {
                        CssClass = "BtnFormCA",
                        Height = 20,
                        Width = 20,
                        ImageUrl = "~/IMG/edit.png",
                        OnClientClick = "return ModificarArticulo('" + item.Codigo.ToString() + "');",
                        ID ="btneditar"+item.Codigo.ToString()
                    };

                    ImageButton btnEliminar = new ImageButton
                    {
                        CssClass = "BtnFormCA",
                        Height = 20,
                        Width = 20,
                        ImageUrl = "~/IMG/delete.png",
                        OnClientClick = "return EliminarArticulo('" + item.Codigo.ToString() + "');",
                        ID = "btneliminar"+item.Codigo.ToString()
                    };



                    PrecProd.Controls.Add(btnEliminar);
                    PrecProd.Controls.Add(btnEditar);

                    PrecProd.Controls.Add(new LiteralControl("<br/>"));
                    PrecProd.Controls.Add(Txtprecio);

                    HtmlGenericControl InfoPCarta = new HtmlGenericControl("div");
                    InfoPCarta.Attributes.Add("class", "InfoPCarta");

                    TextBox TxtInfo = new TextBox();
                    TxtInfo.Attributes.Add("class", "Txt");
                    TxtInfo.Attributes.Add("Disabled", "Disabled");
                    TxtInfo.Text = item.Comentario;

                    InfoPCarta.Controls.Add(TxtInfo);

                    divArt.Controls.Add(NomPCarta);
                    divArt.Controls.Add(new LiteralControl("<br/>"));
                    divArt.Controls.Add(PrecProd);
                    divArt.Controls.Add(new LiteralControl("<br/>"));
                    divArt.Controls.Add(InfoPCarta);

                    divCat.Controls.Add(divArt);
                }
                DivCartas.Controls.Add(divCat);

            }
        }

        protected void BtnCrearArt_Click(object sender, EventArgs e)
        {
            LbAddArt.Text = ArticuloController.AddArticulo( TxtNombreArt.Text, TxtPrecioArt.Text, TxtDescripcionArt.Text, DropCategoria.SelectedValue);
            Response.Redirect("CartaAdmi.aspx");
        }

        [WebMethod]
        public static object BorrarArticulo(string id)
        {
            try
            {

                ArticuloController.removeArticulo(int.Parse(id));
                return new
                {
                    error = false,
                    msg = "Articulo eliminada"
                };
            }
            catch (Exception e)
            {
                return new
                {
                    error = true,
                    msg = e.Message
                };
            }
        }


    }

}