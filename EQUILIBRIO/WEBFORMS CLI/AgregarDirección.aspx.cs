using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                cargarDropComuna();
                cargarDropRegion();
            }

        }

        public void cargarDropComuna()
        {

            DropComuna.DataSource = from com in ComunaController.findAll()
                                       select new
                                       {
                                           codigo = com.codigo,
                                           texto = com.nombre,
                                       };
            DropComuna.DataValueField = "codigo";
            DropComuna.DataTextField = "texto";

            DropComuna.DataBind();
        }

        public void cargarDropRegion()
        {

            DropRegion.DataSource = from reg in RegionController.findAll()
                                    select new
                                    {
                                        codigo = reg.codigo,
                                        texto = reg.nombre,
                                    };
            DropRegion.DataValueField = "codigo";
            DropRegion.DataTextField = "texto";

            DropRegion.DataBind();
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            HdnCodigo.Value = "1";
            LbMensaje.Text = DireccionController.AddDireccion(" ", TxtAlias.Text,
              TxtCalle.Text, TxtDpto.Text, DropComuna.SelectedValue);
            Response.Redirect("PerfilUsuario.aspx");
        }
    }
}