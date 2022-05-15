using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            if (TxtUser.Text == "admin" && TxtPass.Text == "admin")
            {
                Response.Redirect("../WEBFORMS ADM/InicioAdm.aspx");
            }
            else
            {
            }
        }
    }
}