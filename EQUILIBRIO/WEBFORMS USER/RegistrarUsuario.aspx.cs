using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ComunaController.CargarComuna();
            RegionController.CargarRegion();

            if (!Page.IsPostBack)
            {
                cargarDropComuna();
                cargarDropRegion();
            }

        }

        public void cargarDropComuna()
        {

            DropComuna.DataSource = from com in ComunaController.FindAll()
                                    select new
                                    {
                                        codigo = com.Codigo,
                                        texto = com.Nombre,
                                    };
            DropComuna.DataValueField = "codigo";
            DropComuna.DataTextField = "texto";

            DropComuna.DataBind();
        }

        public void cargarDropRegion()
        {

            DropRegion.DataSource = from reg in RegionController.FindAll()
                                    select new
                                    {
                                        codigo = reg.Codigo,
                                        texto = reg.Nombre,
                                    };
            DropRegion.DataValueField = "codigo";
            DropRegion.DataTextField = "texto";

            DropRegion.DataBind();
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            HdnCodigoU.Value = "1";
            HdnCodigoD.Value = "1";

            LbMensaje1.Text = DireccionController.AddDireccion(HdnCodigoD.Value, TextAlias.Text,
              TextCalle.Text, TextDpto.Text, DropComuna.SelectedValue, DropRegion.SelectedValue);

            LbMensaje.Text = UsuarioController.AddUsuario(HdnCodigoU.Value, TextRut.Text,
              TextNombre.Text, TextApellido.Text, TextTelefono.Text, TextContraseña.Text, HdnCodigoD.Value);

            Response.Redirect("PerfilUsuario.aspx");
        }
    }
}