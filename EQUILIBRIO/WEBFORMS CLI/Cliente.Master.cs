using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Clases;
using equilibrio.Controller;

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
            } else {
                usericon.HRef = "IniciarSesión.aspx";
            }

        }
    }
}