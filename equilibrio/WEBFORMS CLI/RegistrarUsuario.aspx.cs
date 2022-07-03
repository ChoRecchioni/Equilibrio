using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                CargarDropComuna();
                CargarDropRegion();
            }

        }

        public void CargarDropComuna()
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

        public void CargarDropRegion()
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
            System.Threading.Thread.Sleep(2500);

            HdnRolCliente.Value = "2";
           
            Direccion dir = DireccionController.AddDireccion("", TextAlias.Text,
            TextCalle.Text, TextDpto.Text, DropComuna.SelectedValue, DropRegion.SelectedValue);

            LbMensaje.Text = UsuarioController.AddUsuario("", TextRut.Text,
            TextNombre.Text, TextApellido.Text, TextTelefono.Text, TextContraseña.Text, dir.codigo.ToString(), HdnRolCliente.Value, "", TextCorreo.Text);

            Response.Redirect("IniciarSesión.aspx");
        }

       
    }
}