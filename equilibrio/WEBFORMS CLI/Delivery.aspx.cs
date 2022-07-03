using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_CLI
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["ActiveUser"];

            if (u == null)
            {
                Response.Redirect("IniciarSesión.aspx");
            }
            else
            {
                GenerarArticulo();
            }



        }

        public void GenerarArticulo()

        { 
            var listadoCat = from cat in CategoriaController.findAll()
                             select new
                             {
                                 Nombre = cat.nombre
                             };

            var listadoArt = from ar in ArticuloController.findAll()
                             select new
                             {
                                 Codigo = ar.codigo,
                                 Nombre = ar.nombre,
                                 Comentario = ar.comentario,
                                 Precio = ar.precio,
                                 Categoria = ar.Categoria.nombre,
                             };


            foreach (var it in listadoCat)
            {
                HtmlGenericControl divCat = new HtmlGenericControl("div");
                divCat.Attributes.Add("class", "Categoria");

                Label LblTitulo = new Label();
                LblTitulo.Attributes.Add("class", "LblTitulo");
                LblTitulo.Style.Add("margin-left", "10px");
                LblTitulo.Text = it.Nombre;

                HtmlGenericControl Table = new HtmlGenericControl("table");
                HtmlGenericControl trTable = new HtmlGenericControl("tr");
                Table.Attributes.Add("class", "ProdXCateg");
                Table.Controls.Add(trTable);

                divCat.Controls.Add(LblTitulo);
                divCat.Controls.Add(new LiteralControl("<br/>"));
                divCat.Controls.Add(new LiteralControl("<br/>"));

                int col = 1;

                foreach (var item in listadoArt.Where(li => li.Categoria == it.Nombre))
                {
                    HtmlGenericControl tdTable = new HtmlGenericControl("td");
                    tdTable.Attributes.Add("class", "auto-style1");

                    HtmlGenericControl Producto = new HtmlGenericControl("div");
                    Producto.Attributes.Add("class", "Producto");

                    HtmlGenericControl NomProd = new HtmlGenericControl("div");
                    NomProd.Attributes.Add("class", "NomProd");

                    Label LblNombreProducto = new Label();
                    LblNombreProducto.Attributes.Add("class", "LblTituloDelivery");
                    LblNombreProducto.Text = item.Nombre;
                    LblNombreProducto.ID = "LblNombreProducto" + item.Codigo;

                    NomProd.Controls.Add(LblNombreProducto);
                    NomProd.Controls.Add(new LiteralControl("<br/>"));

                    HtmlGenericControl InfoProd = new HtmlGenericControl("div");
                    InfoProd.Attributes.Add("class", "InfoProd");

                    Label LblInfoProd = new Label();
                    LblInfoProd.Attributes.Add("class", "LblInfoProd");
                    LblInfoProd.Text = item.Comentario;

                    InfoProd.Controls.Add(LblInfoProd);
                    InfoProd.Controls.Add(new LiteralControl("<br/>"));

                    HtmlGenericControl BotProd = new HtmlGenericControl("div");
                    BotProd.Attributes.Add("class", "BotProd");

                    HtmlGenericControl MMProd = new HtmlGenericControl("div");
                    MMProd.Attributes.Add("class", "MMProd");

                    HtmlGenericControl Restar = new HtmlGenericControl("button");
                    Restar.Attributes.Add("class", "BtnMM");
                    Restar.InnerText = " - ";
                    Restar.Attributes.Add("OnClick", "return Restar('" + item.Codigo + "');");

                    Label LblCant = new Label();
                    LblCant.ID = "LblArticulo" + item.Codigo;
                    LblCant.Text = "0";

                    HtmlGenericControl Sumar = new HtmlGenericControl("button");
                    Sumar.Attributes.Add("class", "BtnMM");
                    Sumar.InnerText = " + ";
                    Sumar.Attributes.Add("OnClick", "return Sumar('" + item.Codigo + "');");

                    Label LblBotProd = new Label();
                    LblBotProd.Attributes.Add("class", "LblTituloP");
                    LblBotProd.Text = "$" + item.Precio + ".-";
                    LblBotProd.ID = "LblBotProd" + item.Codigo;

                    MMProd.Controls.Add(Restar);
                    MMProd.Controls.Add(LblCant);
                    MMProd.Controls.Add(Sumar);
                    BotProd.Controls.Add(MMProd);
                    BotProd.Controls.Add(LblBotProd);

                    Producto.Controls.Add(NomProd);
                    Producto.Controls.Add(InfoProd);
                    Producto.Controls.Add(BotProd);

                    tdTable.Controls.Add(Producto);
                    trTable.Controls.Add(tdTable);

                    if (col >= 2)
                    {
                        Table.Controls.Add(trTable);
                        divCat.Controls.Add(Table);
                        CategoriaDelivery.Controls.Add(divCat);
                        trTable = new HtmlGenericControl("tr");
                        col = 1;
                    }
                    else
                        col++;
                }
            }
        }   
    }
}