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
                    direccion();
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

            foreach (Articulo_Carro ar in carroCompras.ArtCar)
            {
                HtmlTableRow tr2 = new HtmlTableRow();
                tr2.Attributes.Add("class", "tr2");

                HtmlTableCell td5 = new HtmlTableCell();
                td5.Attributes.Add("class", "auto-style11");
                Label LblNom = new Label();
                LblNom.Text = ar.Artículo.Nombre;
                td5.Controls.Add(LblNom);

                HtmlTableCell td6 = new HtmlTableCell();
                td6.Attributes.Add("class", "auto-style12");
                Label LblCantidad = new Label();
                LblCantidad.Text = ar.Cantidad.ToString();
                td6.Controls.Add(LblCantidad);

                HtmlTableCell td7 = new HtmlTableCell();
                td7.Attributes.Add("class", "auto-style13");
                Label LblPrecioU = new Label();
                LblPrecioU.Text = "$" + ar.Artículo.Precio + ".-";
                td7.Controls.Add(LblPrecioU);

                HtmlTableCell td8 = new HtmlTableCell();
                td8.Attributes.Add("class", "auto-style13");
                Label LblPrecioST = new Label();
                LblPrecioST.Text = "$" + double.Parse(ar.Artículo.Precio.Replace(".", "")) * ar.Cantidad + ".-";
                td8.Controls.Add(LblPrecioST);

                total = total + (double.Parse(ar.Artículo.Precio.Replace(".", "")) * Convert.ToDouble(ar.Cantidad));

                tr2.Controls.Add(td5);
                tr2.Controls.Add(td6);
                tr2.Controls.Add(td7);
                tr2.Controls.Add(td8);                
                TablaCarro.Controls.Add(tr2);
            }

            HtmlTableRow tr3 = new HtmlTableRow();
            tr3.Attributes.Add("class", "tr3");
            HtmlTableRow tr4 = new HtmlTableRow();
            tr3.Attributes.Add("class", "tr3");
            HtmlTableCell tdtot = new HtmlTableCell();
            tdtot.Attributes.Add("colspan", "2");
            HtmlTableCell tdtot1 = new HtmlTableCell();
            HtmlTableCell tdtot2 = new HtmlTableCell();
            tdtot.Attributes.Add("class", "tdtot");
            Label LblPrecioTot1 = new Label();
            LblPrecioTot1.Attributes.Add("class", "LblTituloCarro");
            LblPrecioTot1.Text = "$" + total.ToString() + ".-";
            Label LblPrecioTot = new Label();
            LblPrecioTot.Attributes.Add("class", "LblTituloCarro");
            LblPrecioTot.Text = "TOTAL: ";

            tdtot1.Controls.Add(LblPrecioTot);
            tdtot2.Controls.Add(LblPrecioTot1);
            tr3.Controls.Add(tdtot);
            tr3.Controls.Add(tdtot1);
            tr3.Controls.Add(tdtot2);

            TablaCarro.Controls.Add(tr4);
            TablaCarro.Controls.Add(tr3);

        }

        public void direccion()
        {
            Usuario u = (Usuario)Session["ActiveUser"];

            Label labelDir = new Label();
            labelDir.Attributes.Add("class", "Lbl");
            labelDir.Text = "DIRECCIÓN: " + u.Direccion.CalleYnum + ", Dpto " + u.Direccion.Depto + ". " + u.Direccion.Comuna.Nombre;

            divDir.Controls.Add(labelDir);
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