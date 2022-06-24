using equilibrio.Clases;
using equilibrio.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web110 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idCarro = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(idCarro))
                {
                    GenerarArticulo(idCarro);
                }
            }
        }

        protected void BtnPagar_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://webpay.cl");
        }

        public void GenerarArticulo(string idCarro)
        {
            CarroCompras carroCompras = CarroComprasController.FindCarro(idCarro);
            double total = 0;
            HtmlGenericControl table = new HtmlGenericControl("table");

            foreach (Articulo_Carro ar in carroCompras.ArtCar)
            {
                HtmlGenericControl tr = new HtmlGenericControl("tr");
                tr.Attributes.Add("class", "tr1");

                HtmlGenericControl td = new HtmlGenericControl("td");
                td.Attributes.Add("class", "auto-style11");
                Label LblTitulo = new Label();
                LblTitulo.Attributes.Add("class", "LblTituloCarro");
                LblTitulo.Text = "PRODUCTO";
                td.Controls.Add(LblTitulo);

                HtmlGenericControl td2 = new HtmlGenericControl("td");
                td2.Attributes.Add("class", "auto-style12");
                Label LblCant = new Label();
                LblCant.Attributes.Add("class", "LblTituloCarro");
                LblCant.Text = "CANTIDAD";
                td2.Controls.Add(LblCant);

                HtmlGenericControl td3 = new HtmlGenericControl("td");
                td3.Attributes.Add("class", "auto-style13");
                Label LblPrecio = new Label();
                LblPrecio.Attributes.Add("class", "LblTituloCarro");
                LblPrecio.Text = "PRECIO U.";
                td3.Controls.Add(LblPrecio);

                HtmlGenericControl td4 = new HtmlGenericControl("td");
                td4.Attributes.Add("class", "auto-style3");
                Label LblPrecioS = new Label();
                LblPrecioS.Attributes.Add("class", "LblTituloCarro");
                LblPrecioS.Text = "SUBTOTAL";
                td4.Controls.Add(LblPrecioS);

                tr.Controls.Add(td);
                tr.Controls.Add(td2);
                tr.Controls.Add(td3);
                tr.Controls.Add(td4);
                table.Controls.Add(tr);

                HtmlGenericControl tr2 = new HtmlGenericControl("tr");
                tr.Attributes.Add("class", "tr2");

                HtmlGenericControl td5 = new HtmlGenericControl("td");
                td5.Attributes.Add("class", "auto-style11");
                Label LblNom = new Label();
                LblNom.Text = ar.Artículo.Nombre;
                td4.Controls.Add(LblNom);

                HtmlGenericControl td6 = new HtmlGenericControl("td");
                td6.Attributes.Add("class", "auto-style12");
                Label LblCantidad = new Label();
                LblCantidad.Text = ar.Cantidad.ToString();

                HtmlGenericControl td7 = new HtmlGenericControl("td");
                td7.Attributes.Add("class", "auto-style13");
                Label LblPrecioU = new Label();
                LblPrecioU.Text = "$" + ar.Artículo.Precio + ".-";

                HtmlGenericControl td8 = new HtmlGenericControl("td");
                td7.Attributes.Add("class", "auto-style13");
                Label LblPrecioST = new Label();
                LblPrecioST.Text = "$" + double.Parse(ar.Artículo.Precio.Replace(".", "")) * ar.Cantidad + ".-";
                total = total + (double.Parse(ar.Artículo.Precio.Replace(".", "")) * Convert.ToDouble(ar.Cantidad));

                tr2.Controls.Add(td5);
                tr2.Controls.Add(td6);
                tr2.Controls.Add(td7);
                tr2.Controls.Add(td8);
                table.Controls.Add(tr2);
                TablaCarro.Controls.Add(table);
            }

            HtmlGenericControl tr3 = new HtmlGenericControl("tr");
            tr3.Attributes.Add("class", "tr3");
            HtmlGenericControl td9 = new HtmlGenericControl("td");
            td9.Attributes.Add("class", "auto-style0");
            Label LblPrecioTot = new Label();
            LblPrecioTot.Attributes.Add("class", "LblTituloCarro");
            LblPrecioTot.Text = "$" + total.ToString() + ".-";

            td9.Controls.Add(LblPrecioTot);
            tr3.Controls.Add(td9);
            table.Controls.Add(tr3);

        }

        [WebMethod]
        public static object GenerarCarro(string usuario, List<jsonProductosCarro> lista)
        {
            List<Articulo_Carro> articulos = new List<Articulo_Carro>();

            foreach (jsonProductosCarro item in lista)
            {
                Artículo artículo = ArticuloController.FindArticulo(item.id);
                Articulo_Carro articulo_Carro = new Articulo_Carro();
                articulo_Carro.Codigo = Art_CarroController.ArtCarroAI();
                articulo_Carro.Cantidad = int.Parse(item.cantidad);
                articulo_Carro.Artículo = artículo;
                articulos.Add(articulo_Carro);
            }

            string codCarro = CarroComprasController.CarroAI().ToString();
            CarroComprasController.AddCarro(codCarro, usuario, articulos);

            return new
            {
                error = false,
                msg = "ok",
                idCarro = codCarro
            };
        }
    }
    public class jsonProductosCarro
    {
        public string id { get; set; }
        public string cantidad { get; set; }
    }
}