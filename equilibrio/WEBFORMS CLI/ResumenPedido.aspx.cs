using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
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
                    OrdenCompra orden = OrdenCompraController.FindOrden(int.Parse(cod));

                    CarroCompras carroCompras = CarroComprasController.FindCarroCompras(orden.CarroCompras.codigo);

                    Usuario user = UsuarioController.FindUsuario(carroCompras.Usuario.codigo);
                    LbRutu.Text = user.rut;
                    LbNombreu.Text = user.nombre;
                    LbApellidou.Text = user.apellido;
                    LbTelefonou.Text = user.telefono;
                    LbDireccionu.Text = user.Direccion.calleYnum;
                    LbComunau.Text = user.Direccion.Comuna.nombre;
            
                    foreach (ArticuloCarro ar in carroCompras.ArticuloCarro)

                    {
                        HtmlGenericControl div = new HtmlGenericControl("div");
                        div.Attributes.Add("class", "divC");

                        Label LblNomP= new Label();
                        LblNomP.Attributes.Add("class", "Lbl");
                        LblNomP.ID = "LblNomP";
                        LblNomP.Text = ar.Artículo.nombre;

                        Label LblCant = new Label();
                        LblCant.Attributes.Add("class", "Lbl");
                        LblCant.ID = "LblCant";
                        LblCant.Text = "Cantidad: " + ar.cantidad.ToString();
                        LblCant.Style.Add("font-size", "large");

                        Label LblPrecio = new Label();
                        LblPrecio.Attributes.Add("class", "Lbl");
                        LblPrecio.ID = "LblPrecio";
                        LblPrecio.Text = "$" + ar.Artículo.precio + ".-";
                        LblPrecio.Style.Add("float", "right");
                        div.Controls.Add(LblNomP);
                        div.Controls.Add(LblPrecio);
                        div.Controls.Add(new LiteralControl("<br/>"));
                        div.Controls.Add(LblCant);
                        divC.Controls.Add(div);
                    }

                    LblTotal.Text = "$" + orden.total.ToString() + ".-";

                }
            }

        }
    }
}