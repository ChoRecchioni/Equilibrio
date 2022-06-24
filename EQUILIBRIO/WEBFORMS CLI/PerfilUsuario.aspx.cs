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
            if (u.Rol.Codigo == 2)
            {
                TxtRut.Text = u.RUT;
                TxtNombre.Text = u.Nombre;
                TxtApellido.Text = u.Apellido;
                TxtTeléfono.Text = u.Telefono;
                TxtAlias.Text = u.Direccion.Alias;
                TxtDireccion.Text = u.Direccion.CalleYnum;
                TxtDepto.Text = u.Direccion.Depto;
                DropComunas.SelectedValue = u.Direccion.Comuna.Codigo.ToString();
                DropRegiones.SelectedValue = u.Direccion.Region.Codigo.ToString();
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
            ComunaController.CargarComuna();

            DropComunas.DataSource = from com in ComunaController.FindAll()
                                     select new
                                     {
                                         codigo = com.Codigo,
                                         texto = com.Nombre,
                                     };
            DropComunas.DataValueField = "codigo";
            DropComunas.DataTextField = "texto";

            DropComunas.DataBind();
        }

        public void CargarDropRegiones()
        {
            RegionController.CargarRegion();

            DropRegiones.DataSource = from reg in RegionController.FindAll()
                                     select new
                                     {
                                         codigo = reg.Codigo,
                                         texto = reg.Nombre,
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
            LbEditDir.Text = DireccionController.EditDireccion(u.Direccion.Codigo.ToString(), TxtAlias.Text, TxtDireccion.Text, TxtDepto.Text, DropComunas.SelectedValue, DropRegiones.SelectedValue);
            BtnEditarDir.Visible = true;
            BtnCheckDir.Visible = false;
            TxtAlias.Text = u.Direccion.Alias;
            TxtDireccion.Text = u.Direccion.CalleYnum;
            TxtDepto.Text = u.Direccion.Depto;
            TxtAlias.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtDepto.Enabled = false;
            DropComunas.Enabled = false;
            DropRegiones.Enabled = false;
            DropComunas.SelectedValue = u.Direccion.Comuna.Codigo.ToString();
            DropRegiones.SelectedValue = u.Direccion.Region.Codigo.ToString();

        }

        protected void BtnCheckUser_Click(object sender, ImageClickEventArgs e)
        {
            Usuario u = (Usuario)Session["ActiveUser"];
            LbEditUser.Text = UsuarioController.EditUsuario(u.Codigo.ToString(), TxtNombre.Text, TxtApellido.Text, TxtTeléfono.Text);
            BtnEditarUser.Visible = true;
            BtnCheckUser.Visible = false;
            TxtNombre.Text = u.Nombre;
            TxtApellido.Text = u.Apellido;
            TxtTeléfono.Text = u.Telefono;
            TxtNombre.Enabled = false;
            TxtApellido.Enabled = false;
            TxtTeléfono.Enabled = false;
        }
    }
}