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
            ComunaController.CargarComuna();
            RegionController.CargarRegion();
            RoleController.CargarRoles();
            UsuarioController.CargarUsuario();
            DireccionController.CargarDirección();

            if (!Page.IsPostBack)
            {
                CargarDropComuna();
                CargarDropRegion();
            }

        }

        public void CargarDropComuna()
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

        public void CargarDropRegion()
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
            System.Threading.Thread.Sleep(2500);

            int codUser = UsuarioController.UserAI();
            int codDir = DireccionController.DirAI();
            HdnRolCliente.Value = "2";
           
            LbMensaje1.Text = DireccionController.AddDireccion(codDir.ToString(), TextAlias.Text,
            TextCalle.Text, TextDpto.Text, DropComuna.SelectedValue, DropRegion.SelectedValue);

            LbMensaje.Text = UsuarioController.AddUsuario(codUser, TextRut.Text,
            TextNombre.Text, TextApellido.Text, TextTelefono.Text, TextContraseña.Text, codDir.ToString(), HdnRolCliente.Value, "");

            Response.Redirect("IniciarSesión.aspx");
        }

       
    }
}