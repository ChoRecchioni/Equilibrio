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
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Direccion dir = DireccionController.FindDireccion("1");
            Usuario usu = UsuarioController.FindUsuario("1");

            if (dir != null || usu !=null)
            {

                TxtAlias.Text = dir.Alias;
                TxtDireccion.Text = dir.CalleYnum;
                TxtComuna.Text = dir.Comuna.Nombre;
                TxtRegion.Text = dir.Region.Nombre;
                TxtRut.Text = usu.RUT;
                TxtNombre.Text = usu.Nombre;
                TxtApellido.Text = usu.Apellido;
                TxtTeléfono.Text = usu.Telefono;

                Session["masc"] = dir;
                Session["Usur"] = usu;

            }
            else
            {
                Session["masc"] = null;
                Session["Usur"] = null;
            }

        }

        protected void BtnAgregar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AgregarDireccion.aspx");
        }
    }
}