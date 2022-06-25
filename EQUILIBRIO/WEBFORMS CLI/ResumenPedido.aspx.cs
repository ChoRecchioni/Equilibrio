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
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string cod = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(cod))
                {

                    OrdenCompra orden = OrdenCompraController.FindOrden(cod);
                    CarroCompras carroCompras = CarroComprasController.FindCarro(orden.Carro.Codigo.ToString());

                    Usuario user = UsuarioController.FindUser(carroCompras.user.Codigo);
                    LbRutu.Text = user.RUT;
                    LbNombreu.Text = user.Nombre;
                    LbApellidou.Text = user.Apellido;
                    LbTelefonou.Text = user.Telefono;
                    LbDireccionu.Text = user.Direccion.CalleYnum;
                    LbComunau.Text = user.Direccion.Comuna.Nombre;
                    LbRegionu.Text = user.Direccion.Region.Nombre;
            
                    foreach (Articulo_Carro ar in carroCompras.ArtCar)

                    {
                        HtmlGenericControl div = new HtmlGenericControl("div");
                        div.Attributes.Add("class", "divC");

                        Label LblNomP= new Label();
                        LblNomP.Attributes.Add("class", "Lbl");
                        LblNomP.ID = "LblNomP";
                        LblNomP.Text = ar.Artículo.Nombre;
                        div.Controls.Add(LblNomP);
                        div.Controls.Add(new LiteralControl("<br/>"));

                        Label LblCant = new Label();
                        LblCant.Attributes.Add("class", "Lbl");
                        LblCant.ID = "LblCant";
                        LblCant.Text = ar.Cantidad.ToString();
                        div.Controls.Add(LblCant);
                        div.Controls.Add(new LiteralControl("<br/>"));

                        Label LblPrecio = new Label();
                        LblPrecio.Attributes.Add("class", "Lbl");
                        LblPrecio.ID = "LblPrecio";
                        LblPrecio.Text = ar.Artículo.Precio;
                        div.Controls.Add(LblPrecio);
                        div.Controls.Add(new LiteralControl("<br/>"));
                        divC.Controls.Add(div);
                    }
                    LblTotal.Text = orden.Total.ToString();

                }
            }

        }
    }
}