using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
            ValidarUser();
            CargarDropComunas();
            CargarDropRegiones();
            }
          
        }

        //Metodo para validar inicio de sesion y rol
        public void ValidarUser()
        {

            if (Session["ActiveUser"] == null)
            {
                Response.Redirect("IniciarSesión.aspx");
            }

            Usuario u = (Usuario)Session["ActiveUser"];
            if (u.Rol.codigo == 2)
            {
                TxtRut.Text = u.rut;
                TxtNombre.Text = u.nombre;
                TxtApellido.Text = u.apellido;
                TxtTeléfono.Text = u.telefono;
                TxtAlias.Text = u.Direccion.alias;
                TxtDireccion.Text = u.Direccion.calleYnum;
                TxtDepto.Text = u.Direccion.depto;
                DropComunas.SelectedValue = u.Direccion.Comuna.codigo.ToString();
                DropRegiones.SelectedValue = u.Direccion.Region.codigo.ToString();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["ActiveUser"] = null;
            Response.Redirect("IniciarSesión.aspx");
        }

        public void CargarDropComunas()
        {

            DropComunas.DataSource = from com in ComunaController.findAll()
                                     select new
                                     {
                                         codigo = com.codigo,
                                         texto = com.nombre,
                                     };
            DropComunas.DataValueField = "codigo";
            DropComunas.DataTextField = "texto";

            DropComunas.DataBind();
        }

        public void CargarDropRegiones()
        {

            DropRegiones.DataSource = from reg in RegionController.findAll()
                                     select new
                                     {
                                         codigo = reg.codigo,
                                         texto = reg.nombre,
                                     };
            DropRegiones.DataValueField = "codigo";
            DropRegiones.DataTextField = "texto";

            DropRegiones.DataBind();
        }

        //public void CargarDirecciones()
        //{
        //    Direccion DirUser = DireccionController.FindDireccion(DropDirecciones.SelectedValue);

        //    TxtAlias.Text = DirUser.Alias;
        //    TxtDireccion.Text = DirUser.CalleYnum;
        //    TxtComuna.Text = DirUser.Comuna.Nombre;
        //    TxtRegion.Text = DirUser.Region.Nombre;

        //}


        //public void CargarDropDirecciones()
        //{
        //    DireccionController.CargarDirección();

        //    Usuario u = (Usuario)Session["ActiveUser"];

        //    int codDirUser = u.Direccion.Codigo;

        //    var ListDirUser = from dire in DireccionController.FindAll()
        //                      select new
        //                      {
        //                          Codigo = dire.Codigo,
        //                          Alias = dire.Alias,                               
        //                      };

        //    DropDirecciones.DataSource = from dir in ListDirUser.Where(dire => dire.Codigo == codDirUser)
        //                             select new
        //                             {
        //                               codigo = dir.Codigo,
        //                               alias = dir.Alias,
        //                             };
        //    DropDirecciones.DataValueField = "codigo";
        //    DropDirecciones.DataTextField = "alias";

        //    DropDirecciones.DataBind();
        //}

        protected void BtnEditarUser_Click(object sender, ImageClickEventArgs e)
        {
            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            TxtTeléfono.Enabled = true;
            BtnEditarUser.Visible = false;
            BtnCheckUser.Visible = true;

        }

        protected void BtnEditarDir_Click(object sender, ImageClickEventArgs e)
        {
            TxtAlias.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtDepto.Enabled = true;
            DropComunas.Enabled = true;
            DropRegiones.Enabled = true;
            BtnEditarDir.Visible = false;
            BtnCheckDir.Visible = true;
        }

        protected void BtnCheckDir_Click(object sender, ImageClickEventArgs e)
        {
            Usuario u = (Usuario)Session["ActiveUser"];
            LbEditDir.Text = DireccionController.editDireccion(u.Direccion.codigo.ToString(), TxtAlias.Text, TxtDireccion.Text, TxtDepto.Text, DropComunas.SelectedValue, DropRegiones.SelectedValue);
            BtnEditarDir.Visible = true;
            BtnCheckDir.Visible = false;
            TxtAlias.Text = u.Direccion.alias;
            TxtDireccion.Text = u.Direccion.calleYnum;
            TxtDepto.Text = u.Direccion.depto;
            TxtAlias.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtDepto.Enabled = false;
            DropComunas.Enabled = false;
            DropRegiones.Enabled = false;
            DropComunas.SelectedValue = u.Direccion.Comuna.codigo.ToString();
            DropRegiones.SelectedValue = u.Direccion.Region.codigo.ToString();

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