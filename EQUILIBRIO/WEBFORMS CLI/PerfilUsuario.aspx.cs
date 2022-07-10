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
            if (u != null)
            {
                TxtRut.Text = u.rut;
                TxtNombre.Text = u.nombre;
                TxtApellido.Text = u.apellido;
                TxtTeléfono.Text = u.telefono;
                TxtAlias.Text = u.Direccion.alias;
                TxtDireccion.Text = u.Direccion.calleYnum;
                TxtDepto.Text = u.Direccion.depto;
                DropComuna.SelectedValue = u.Direccion.Comuna.codigo.ToString();
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


        public void CargarDropRegiones()
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
            DropComuna.Enabled = true;
            DropRegion.Enabled = true;
            BtnEditarDir.Visible = false;
            BtnCheckDir.Visible = true;
        }

        protected void BtnCheckDir_Click(object sender, ImageClickEventArgs e)
        {
            Usuario u = (Usuario)Session["ActiveUser"];
            LbEditDir.Text = DireccionController.editDireccion(u.Direccion.codigo.ToString(), TxtAlias.Text, TxtDireccion.Text, TxtDepto.Text, DropComuna.SelectedValue);
            Direccion DUser = DireccionController.FindDireccion(u.Direccion.codigo);
            BtnEditarDir.Visible = true;
            BtnCheckDir.Visible = false;
            TxtAlias.Text = DUser.alias;
            TxtDireccion.Text = DUser.calleYnum;
            TxtDepto.Text = DUser.depto;
            TxtAlias.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtDepto.Enabled = false;
            DropComuna.Enabled = false;
            DropRegion.Enabled = false;
            DropComuna.SelectedValue = DUser.Comuna.codigo.ToString();
            DropRegion.SelectedValue = DUser.Comuna.Region.codigo.ToString();

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