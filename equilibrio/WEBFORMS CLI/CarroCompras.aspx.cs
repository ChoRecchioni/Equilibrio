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
                    Direccion();
                }
            }


            if (!Page.IsPostBack)
            {
                cargarDropLocales();
            }
        }

        protected void BtnPagar_Click(object sender, EventArgs e)
        {
            string idCarro = Request.QueryString["ID"];
            CarroCompras carroCompras = CarroComprasController.FindCarroCompras(int.Parse(idCarro));

            double total = 0;
            foreach (ArticuloCarro ar in carroCompras.ArticuloCarro)
            {
                total = total + (double.Parse(ar.Artículo.precio.Replace(".", "")) * Convert.ToDouble(ar.cantidad));
            }
            //Response.Redirect("http://webpay.cl");
            //if (pago != null) {
            OrdenCompra orden = OrdenCompraController.AddOrden(total.ToString(), idCarro, DropLocal.SelectedValue.ToString());

            Random random = new Random();
            int numero = random.Next(1, 100000);
            DeliveryController.AddDelivery(numero.ToString(), orden.codigo.ToString(), "1");
            Response.Redirect("ResumenPedido.aspx?ID=" + orden.codigo);
            //}

        }

        public void GenerarArticulo(string idCarro)
        {
            CarroCompras carroCompras = CarroComprasController.FindCarroCompras(int.Parse(idCarro));
            double total = 0;

            foreach (ArticuloCarro ar in carroCompras.ArticuloCarro)
            {
                HtmlTableRow tr2 = new HtmlTableRow();
                tr2.Attributes.Add("class", "tr2");

                HtmlTableCell td5 = new HtmlTableCell();
                td5.Attributes.Add("class", "auto-style11");
                Label LblNom = new Label();
                LblNom.Text = ar.Artículo.nombre;
                td5.Controls.Add(LblNom);

                HtmlTableCell td6 = new HtmlTableCell();
                td6.Attributes.Add("class", "auto-style12");
                Label LblCantidad = new Label();
                LblCantidad.Text = ar.cantidad.ToString();
                td6.Controls.Add(LblCantidad);

                HtmlTableCell td7 = new HtmlTableCell();
                td7.Attributes.Add("class", "auto-style13");
                Label LblPrecioU = new Label();
                LblPrecioU.Text = "$" + ar.Artículo.precio + ".-";
                td7.Controls.Add(LblPrecioU);

                HtmlTableCell td8 = new HtmlTableCell();
                td8.Attributes.Add("class", "auto-style13");
                Label LblPrecioST = new Label();
                LblPrecioST.Text = "$" + double.Parse(ar.Artículo.precio.Replace(".", "")) * ar.cantidad + ".-";
                td8.Controls.Add(LblPrecioST);

                total = total + (double.Parse(ar.Artículo.precio.Replace(".", "")) * Convert.ToDouble(ar.cantidad));

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

        public void Direccion()
        {
            Usuario u = (Usuario)Session["ActiveUser"];

            Label labelDir = new Label();
            labelDir.Attributes.Add("class", "LblTituloCarro");
            labelDir.Text = "DIRECCIÓN: " + u.Direccion.calleYnum + ", Dpto " + u.Direccion.depto + ". " + u.Direccion.Comuna.nombre;

            divDir.Controls.Add(labelDir);
        }

        public void cargarDropLocales()
        {

            DropLocal.DataSource = from sed in LocalController.findAll()
                                   select new
                                   {
                                       codigo = sed.codigo,
                                       texto = sed.nombre,
                                   };
            DropLocal.DataValueField = "codigo";
            DropLocal.DataTextField = "texto";

            DropLocal.DataBind();
        }

        [WebMethod]
        public static object GenerarCarro(string usuario, List<jsonProductosCarro> lista)
        {
            List<ArticuloCarro> articulos = new List<ArticuloCarro>();
            CarroCompras carro = CarroComprasController.AddCarro(usuario);

            foreach (jsonProductosCarro item in lista)
            {

                Artículo artículo = ArticuloController.FindArticulo(int.Parse(item.id));
                ArticuloCarro articulo_Carro = new ArticuloCarro();
                articulo_Carro.codigo = int.Parse(" ");
                articulo_Carro.cantidad = int.Parse(item.cantidad);
                articulo_Carro.fk_articulo = artículo.codigo;
                articulo_Carro.fk_carro = carro.codigo;
                articulos.Add(articulo_Carro);
            }

            return new
            {
                error = false,
                msg = "ok",
                idCarro = carro.codigo,
            };
        }
    }
    public class jsonProductosCarro
    {
        public string id { get; set; }
        public string cantidad { get; set; }
    }
}