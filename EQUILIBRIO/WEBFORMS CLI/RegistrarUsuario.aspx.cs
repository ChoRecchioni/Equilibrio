using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                CargarDropRegion();
                CargarDropComunas();
            }

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

        public void CargarDropComunas()
        {
            

            DropComuna.DataSource = from com in ComunaController.findAll()
                                    select new
                                    {
                                        codigo = com.codigo,
                                        texto = com.nombre,
                                    };
            DropRegion.DataValueField = "codigo";
            DropRegion.DataTextField = "texto";

            DropRegion.DataBind();
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2500);

            HdnRolCliente.Value = "2";

            Direccion dir = DireccionController.AddDireccion(TextAlias.Text,
            TextCalle.Text, TextDpto.Text, DropComuna.SelectedValue.ToString());
            string passMD5 = UsuarioController.GetMD5(TextContraseña.Text);

            LbMensaje.Text = UsuarioController.AddUsuario(TextRut.Text, TextNombre.Text, TextApellido.Text, TextTelefono.Text, passMD5, dir.codigo.ToString(), TextCorreo.Text);

            Response.Redirect("IniciarSesión.aspx");
        }

        protected void DropRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codRegion = DropRegion.SelectedValue;

            var comunas = ComunaController.findAll().Where(c => c.Region.codigo.ToString() == codRegion);

            DropComuna.DataSource = from com in ComunaController.findAll().Where
                                    (c => c.Region.codigo.ToString() == codRegion)
                                    select new
                                    {
                                        codigo = com.codigo,
                                        texto = com.nombre,
                                    };
            DropComuna.DataValueField = "codigo";
            DropComuna.DataTextField = "texto";

            DropComuna.DataBind();
        }


    }
}