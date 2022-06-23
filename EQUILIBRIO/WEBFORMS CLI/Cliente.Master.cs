using System;
using System.Collections.Generic;
using System.Web.Services;
using equilibrio.Clases;

namespace equilibrio.WEBFORMS_CLI
{
    public partial class Cliente : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["ActiveUser"];

            if (u != null)
            {
                usericon.HRef = "PerfilUsuario.aspx";
            }
            else
            {
                usericon.HRef = "IniciarSesión.aspx";
            }
        }

    }
}