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
            
            ValidarUser();
        }

        //Metodo para validar inicio de sesion y rol
        public void ValidarUser()
        {


            if (Session["ActiveUser"] == null)
            {
                Response.Redirect("IniciarSesión.aspx");
            }

            Usuario u = (Usuario)Session["ActiveUser"];
            if (u.Rol.Codigo == 2)
            {
                TxtAlias.Text = u.Direccion.Alias;
                TxtDireccion.Text = u.Direccion.CalleYnum;
                TxtComuna.Text = u.Direccion.Comuna.Nombre;
                TxtRegion.Text = u.Direccion.Region.Nombre;
                TxtRut.Text = u.RUT;
                TxtNombre.Text = u.Nombre;
                TxtApellido.Text = u.Apellido;
                TxtTeléfono.Text = u.Telefono;
            }
            else
            {
                Response.Redirect("IniciarSesión.aspx");
            }
        }

        protected void BtnAgregar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AgregarDireccion.aspx");
        }

    }
}