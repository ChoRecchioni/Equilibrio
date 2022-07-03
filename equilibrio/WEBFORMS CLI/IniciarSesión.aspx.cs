using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Controller;
using System.Windows.Forms;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LnkRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarUsuario.aspx");
        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            Usuario u = LoginController.Login(TxtUser.Text, TxtPass.Text);
            if (u != null)
            {
                if (u.Rol != null)
                {
                    if (u.Rol.codigo == 1)
                    {
                        Session["ActiveUser"] = u;
                        Response.Redirect("../WEBFORMS ADM/InicioAdm.aspx");
                    }
                    else
                    {
                        Session["ActiveUser"] = u;
                        Response.Redirect("Inicio.aspx");
                    }
                }
                else
                {
                    Session["ActiveUser"] = u;
                    Response.Redirect("Inicio.aspx");
                }
            }
            else
            {
                Session["ActiveUser"] = null;
                Response.Redirect("IniciarSesión.aspx");
            }
        }

        
    }
}