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
            }
        }

        protected void BtnPagar_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://webpay.cl");
        }

        public void GenerarArticulo(string idCarro)
        {
            CarroCompras carroCompras = CarroComprasController.FindCarro(idCarro);

            foreach (Articulo_Carro ar in carroCompras.ArtCar)
            {
                HtmlGenericControl tr = new HtmlGenericControl("tr");
                tr.Attributes.Add("class", "tr1");

                HtmlGenericControl td = new HtmlGenericControl("td");
                td.Attributes.Add("class", "auto-style11");
                Label LblTitulo = new Label();
                LblTitulo.Attributes.Add("class", "LblTitulo");
                LblTitulo.Text = "PRODUCTO";
                td.Controls.Add(LblTitulo);

                HtmlGenericControl td2 = new HtmlGenericControl("td");
                td2.Attributes.Add("class", "auto-style12");
                Label LblCant = new Label();
                LblCant.Attributes.Add("class", "LblTitulo");
                LblCant.Text = "CANTIDAD";
                td2.Controls.Add(LblCant);

                HtmlGenericControl td3 = new HtmlGenericControl("td");
                td3.Attributes.Add("class", "auto-style13");
                Label LblPrecio = new Label();
                LblPrecio.Attributes.Add("class", "LblTitulo");
                LblPrecio.Text = "PRECIO U.";
                td3.Controls.Add(LblPrecio);

                HtmlGenericControl td4 = new HtmlGenericControl("td");
                td4.Attributes.Add("class", "auto-style3");
                Label LblPrecioS = new Label();
                LblPrecioS.Text = "SUBTOTAL";
                td4.Controls.Add(LblPrecioS);

                tr.Controls.Add(td);
                tr.Controls.Add(td2);
                tr.Controls.Add(td3);
                tr.Controls.Add(td4);

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
                LblPrecioU.Text = "$"+ar.Precio+".-";

                HtmlGenericControl td8 = new HtmlGenericControl("td");
                td7.Attributes.Add("class", "auto-style13");
                Label LblPrecioST = new Label();
                LblPrecioST.Text = "$" + int.Parse(ar.Precio)*ar.Cantidad + ".-";

                tr2.Controls.Add(td5);
                tr2.Controls.Add(td6);
                tr2.Controls.Add(td7);
                tr2.Controls.Add(td8);
            }

            HtmlGenericControl tr3 = new HtmlGenericControl("tr");
            tr3.Attributes.Add("class", "tr3");
            HtmlGenericControl td9 = new HtmlGenericControl("td");
            //td9.Attributes.Add("class", "auto-style11");            
            Label LblPrecioTot = new Label();
            LblPrecioTot.Text = "$" + /*total calcular!*/ + ".-";




        }

        [WebMethod]
        public static object GenerarCarro(string usuario, List<jsonProductosCarro> lista)
        {
            //Controller de Generar Carro

            ///Usar controller de Articulo-Carro
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