using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["ActiveUser"] = null;
            Response.Redirect("~/WEBFORMS CLI/IniciarSesión.aspx");
        }





        protected void BtnEditarUser_Click(object sender, ImageClickEventArgs e)
        {
            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            TxtTeléfono.Enabled = true;
            BtnEditarUser.Visible = false;
            BtnCheckUser.Visible = true;

        }





        protected void BtnCheckUser_Click(object sender, ImageClickEventArgs e)
        {
            Usuario u = (Usuario)Session["ActiveUser"];
            LbEditUser.Text = UsuarioController.editUsuario(u.codigo.ToString(), TxtNombre.Text, TxtApellido.Text, TxtTeléfono.Text);
            BtnEditarUser.Visible = true;
            BtnCheckUser.Visible = false;
            TxtNombre.Text = u.nombre;
            TxtApellido.Text = u.apellido;
            TxtTeléfono.Text = u.telefono;
            TxtNombre.Enabled = false;
            TxtApellido.Enabled = false;
            TxtTeléfono.Enabled = false;
        }
    }
}